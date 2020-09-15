using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyManager.UI
{
    public partial class FormStart : Form
    {
        int curso_id, aula_id;

        public FormStart(Form formParent)
        {
            InitializeComponent();
            #region Metódo Necessário em todas as Forms
            MdiParent = formParent;
            formParent.Resize += new EventHandler(FormStart_Resize);
            panelContent.Location = new Point((Width - panelContent.Width) / 2, (Height - panelContent.Height) / 2);
            #endregion
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            label_Matricula.Text = Class_Login.Matricula;

            Class_DataBase.ListarCursosUsuario(dataGridCursosUsuario);
            label_Curso.Width = CalcularLargura(panel_Cursos, 40);
            label_Nivel.Width = CalcularLargura(panel_Cursos, 20);
            label_DataInscricao.Width = CalcularLargura(panel_Cursos, 20);
            label_UltimoAcesso.Width = CalcularLargura(panel_Cursos, 20);

            label_Curso.Location = new Point(0, 0);
            label_Nivel.Location = new Point(label_Curso.Location.X + label_Curso.Size.Width, 0);
            label_DataInscricao.Location = new Point(label_Nivel.Location.X + label_Nivel.Size.Width, 0);
            label_UltimoAcesso.Location = new Point(label_DataInscricao.Location.X + label_DataInscricao.Size.Width, 0);

            DataGridCursosUsuario_SelectionChanged(dataGridCursosUsuario, EventArgs.Empty);
        }

        #region Metódo Necessário em todas as Forms
        private void FormStart_Resize(object sender, EventArgs e)
        {
            Size = new Size(Class_Settings.ParentSize.Width - 4, Class_Settings.ParentSize.Height - 4);
            Location = new Point(0, 0);
            panelContent.Location = new Point((Width - panelContent.Width) / 2, (Height - panelContent.Height) / 2);
        }
        #endregion

        private void cmd_MeusCursos(object sender, EventArgs e)
        {

        }

        private void cmd_Sair(object sender, EventArgs e)
        {
            Class_Login.Logout();
            FormLogin f = new FormLogin(MdiParent);
            f.Show();
            Close();
        }

        private static int CalcularLargura(Control controle, int percentagem)
        {
            int larguraGrade = controle.Width - 20;
            int resultado = (larguraGrade * percentagem) / 100;
            return resultado;
        }

        private void DataGridCursosUsuario_DoubleClick(object sender, EventArgs e)
        {
            Btn_AssistirProximaAula_Click(btn_AssistirProximaAula, EventArgs.Empty);
        }

        private void Btn_AssistirProximaAula_Click(object sender, EventArgs e)
        {
            FormCursoDetalhes f = new FormCursoDetalhes(MdiParent, this.curso_id, this.aula_id);
            f.Show();
            Close();
        }

        private void Btn_Configuracoes_Click(object sender, EventArgs e)
        {
            FormSettings f = new FormSettings(MdiParent);
            f.Show();
            Close();
        }

        private void DataGridCursosUsuario_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCursosUsuario.CurrentRow != null)
            {
                int index = dataGridCursosUsuario.CurrentRow.Index;
                if (index > -1)
                {
                    Class_DataBase.DetalhesAula((int)dataGridCursosUsuario.CurrentRow.Cells["ultima_aula_assistida"].Value);

                    if (Class_Aula_Selecionada.Aula_Id > 0)
                    {
                        txt_UltimaAulaAssistida.Text = Class_Aula_Selecionada.Aula_Titulo;
                    }
                    else
                    {
                        txt_UltimaAulaAssistida.Text = "Nenhuma aula assistida";
                    }

                    this.curso_id = (int)dataGridCursosUsuario.CurrentRow.Cells["curso_id"].Value;
                    this.aula_id = (int)dataGridCursosUsuario.CurrentRow.Cells["ultima_aula_assistida"].Value;

                    txt_Curso.Text = dataGridCursosUsuario.CurrentRow.Cells["curso"].Value.ToString();
                    txt_Nivel.Text = dataGridCursosUsuario.CurrentRow.Cells["curso_nivel"].Value.ToString();
                    txt_CursoStatus.Text = dataGridCursosUsuario.CurrentRow.Cells["usuarios_cursos_status"].Value.ToString();
                    txt_DataInscricao.Text = dataGridCursosUsuario.CurrentRow.Cells["usuarios_cursos_data_inscricao"].Value.ToString();
                    txt_UtimoAcesso.Text = dataGridCursosUsuario.CurrentRow.Cells["usuarios_cursos_ultimo_acesso"].Value.ToString();
                }
            }
        }
    }
}
