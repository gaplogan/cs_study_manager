using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StudyManager.UI
{
    public partial class FormCursoDetalhes : Form
    {
        int curso_id, aula_id, aula_id_selecionada, proxima_aula = 0;
        bool cursoConcluido = false, gravarProximaAula = false;

        public FormCursoDetalhes(Form formParent, int curso_id, int aula_id)
        {
            InitializeComponent();

            this.curso_id = curso_id;
            this.aula_id = aula_id;

            #region Metódo Necessário em todas as Forms
            MdiParent = formParent;
            formParent.Resize += new EventHandler(FormCursoDetalhes_Resize);
            panelContent.Location = new Point((Width - panelContent.Width) / 2, (Height - panelContent.Height) / 2);
            #endregion
        }

        private void FormCursoDetalhes_Load(object sender, EventArgs e)
        {
            Class_DataBase.ListarAulasDoCurso(curso_id, dataGridViewAulas);

            Btn_IrParaProximaAula_Click(btn_IrParaProximaAula, EventArgs.Empty);
        }

        private static int CalcularLargura(Control controle, int percentagem)
        {
            int larguraGrade = controle.Width - 20;
            int resultado = (larguraGrade * percentagem) / 100;
            return resultado;
        }

        #region Metódo Necessário em todas as Forms
        private void FormCursoDetalhes_Resize(object sender, EventArgs e)
        {
            Size = new Size(Class_Settings.ParentSize.Width - 4, Class_Settings.ParentSize.Height - 4);
            Location = new Point(0, 0);
            panelContent.Location = new Point((Width - panelContent.Width) / 2, (Height - panelContent.Height) / 2);
        }
        #endregion

        private void Btn_AssistirAula_Click(object sender, EventArgs e)
        {
            label_Retorno.ForeColor = Color.Lime;
            label_Retorno.Text = "Abrindo aula...";

            string linkAula = "";

            if (dataGridViewAulas.CurrentRow.Cells["aula_link_1"].Value.ToString() != "" && dataGridViewAulas.CurrentRow.Cells["aula_link_1"].Value.ToString() != null && File.Exists(Class_Settings.FolderPath + dataGridViewAulas.CurrentRow.Cells["aula_link_1"].Value.ToString()))
            {
                linkAula = Class_Settings.FolderPath + dataGridViewAulas.CurrentRow.Cells["aula_link_1"].Value.ToString();
            }
            else if (dataGridViewAulas.CurrentRow.Cells["aula_link_2"].Value.ToString() != "" && dataGridViewAulas.CurrentRow.Cells["aula_link_2"].Value.ToString() != null)
            {
                linkAula = dataGridViewAulas.CurrentRow.Cells["aula_link_2"].Value.ToString();
            }

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = linkAula;
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(startInfo);
                label_Retorno.ForeColor = Color.Lime;
                label_Retorno.Text = "";

                if (gravarProximaAula && proxima_aula > 0)
                {
                    Class_DataBase.GravarProximaAula(proxima_aula, this.curso_id);
                    this.aula_id = proxima_aula;
                    Btn_IrParaProximaAula_Click(btn_IrParaProximaAula, EventArgs.Empty);
                }
            }
            catch (Exception ex)
            {
                label_Retorno.ForeColor = Color.Red;
                label_Retorno.Text = "Erro ao tentar reproduzir a aula";
                Console.WriteLine("Erro ao tentar iniciar a Aula :\n" + ex);
            }
        }

        private void Btn_IrParaProximaAula_Click(object sender, EventArgs e)
        {
            if (this.aula_id == 0)
            {
                // Primeira Aula do Curso
                dataGridViewAulas.FirstDisplayedScrollingRowIndex = 0;
                dataGridViewAulas.Refresh();
                dataGridViewAulas.CurrentCell = dataGridViewAulas.Rows[0].Cells[4];
                dataGridViewAulas.Rows[0].Selected = true;
                aula_id_selecionada = Convert.ToInt32(dataGridViewAulas.Rows[0].Cells["aula_id"].Value.ToString());
                proxima_aula = aula_id_selecionada;
            }
            else
            {
                int linha = 0;

                if (aula_id > Class_DataBase.cursoAulas[Class_DataBase.cursoAulas.Count - 1].Aula_Id)
                {
                    // Curso Concluído
                    linha = dataGridViewAulas.Rows.Count - 1;
                    cursoConcluido = true;
                    proxima_aula = 0;
                }
                else if (aula_id == Class_DataBase.cursoAulas[Class_DataBase.cursoAulas.Count - 1].Aula_Id)
                {
                    // Ultima aula do Curso
                    linha = dataGridViewAulas.Rows.Count - 1;
                    proxima_aula = aula_id + 1;
                }
                else
                {
                    for (int i = 0; i < Class_DataBase.cursoAulas.Count; i++)
                    {
                        if (aula_id == Class_DataBase.cursoAulas[i].Aula_Id)
                        {
                            linha = i + 1;
                            proxima_aula = aula_id + 1;
                        }
                    }
                }

                dataGridViewAulas.FirstDisplayedScrollingRowIndex = linha;
                dataGridViewAulas.Refresh();
                dataGridViewAulas.CurrentCell = dataGridViewAulas.Rows[linha].Cells[4];
                dataGridViewAulas.Rows[linha].Selected = true;
                aula_id_selecionada = Convert.ToInt32(dataGridViewAulas.Rows[linha].Cells["aula_id"].Value.ToString());
            }

            DataGridViewAulas_SelectionChanged(dataGridViewAulas, EventArgs.Empty);
        }

        private void DataGridViewAulas_SelectionChanged(object sender, EventArgs e)
        {
            gravarProximaAula = false;
            label_Retorno.ForeColor = Color.Lime;
            label_Retorno.Text = "";

            if (dataGridViewAulas.CurrentRow != null)
            {
                int index = dataGridViewAulas.CurrentRow.Index;
                if (index > -1)
                {
                    if (!cursoConcluido)
                    {
                        if (Convert.ToInt32(dataGridViewAulas.CurrentRow.Cells["aula_id"].Value) < aula_id_selecionada)
                        {
                            btn_AssistirAula.Text = "Assistir Novamente";
                            btn_AssistirAula.Enabled = true;
                        }
                        else if (Convert.ToInt32(dataGridViewAulas.CurrentRow.Cells["aula_id"].Value) > aula_id_selecionada)
                        {
                            btn_AssistirAula.Text = "Você Ainda Não Chegou Nesta Aula";
                            btn_AssistirAula.Enabled = false;
                        }
                        else
                        {
                            gravarProximaAula = true;
                            btn_AssistirAula.Text = "Assistir Aula";
                            btn_AssistirAula.Enabled = true;
                        }
                    }
                    else
                    {
                        btn_AssistirAula.Text = "Assistir Novamente";
                        btn_AssistirAula.Enabled = true;
                    }

                    Class_DataBase.DetalhesAula(aula_id_selecionada);

                    curso_id = Class_Aula_Selecionada.Curso_Id;

                    Class_DataBase.DetalhesCurso(curso_id);

                    txt_Curso.Text = Class_Curso_Selecionado.Curso;
                    txt_Nivel.Text = Class_Curso_Selecionado.Curso_Nivel;
                    txt_AulaModulo.Text = dataGridViewAulas.CurrentRow.Cells["aula_modulo"].Value.ToString();
                    txt_AulaMateria.Text = dataGridViewAulas.CurrentRow.Cells["aula_materia"].Value.ToString();
                    txt_AulaTitulo.Text = dataGridViewAulas.CurrentRow.Cells["aula_titulo"].Value.ToString();
                }
            }
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            FormStart f = new FormStart(MdiParent);
            f.Show();
            Close();
        }
    }
}
