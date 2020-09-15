using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StudyManager
{
    public partial class Form1 : Form
    {
        private static string cursoPath = @"E:\Knowledge Project\Ensino Superior";
        string currentPath = cursoPath;
        bool cronograma = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Banco de dados
        private void Btn_Inserir_Click(object sender, EventArgs e)
        {
            BaseDados.Inserir(listBox1);
        }

        private void Btn_Listar_Click(object sender, EventArgs e)
        {
            BaseDados.Listar(listBox1);
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            BaseDados.Editar(listBox1, 28);
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            BaseDados.Excluir(listBox1, 27);
        }
        #endregion

        #region Função para Correções 
        private void Btn_ListarArquivos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string drivePath = @"E:\Knowledge Project\Ensino Superior"; // @"E:\Knowledge Project\Ensino Superior"; //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (Directory.Exists(drivePath))
            {
                List<string> dirs = new List<string>();
                foreach (string dirPath in Directory.GetDirectories(drivePath, "*.*", SearchOption.AllDirectories))
                {
                    foreach (FileInfo item in new DirectoryInfo(dirPath).GetFiles())
                    {
                        dirs.Add(item.FullName);
                    }
                }

                foreach (string file in dirs)
                {
                    listBox1.Items.Add(file);
                }

                listBox1.Items.Add("");
                listBox1.Items.Add("Items Listados: " + dirs.Count);
            }
        }

        private void Btn_CorrigeNomes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string drivePath = @"D:\Users\Gabriel\AndroidStudioProjects\PoomsaeTKD\app\src\main\res\raw";
            List<string> files = new List<string>();
            foreach (FileInfo item in new DirectoryInfo(drivePath).GetFiles())
            {
                if (item.FullName.Contains(".0"))
                {
                    File.Move(item.FullName, item.FullName.Replace(".0", "_0"));
                }

                //for (int i = 28; i < 57; i++)
                //{
                //    if (item.FullName.Contains("- Aula " + i.ToString("00") + " -"))
                //    {
                //        listBox1.Items.Add(item.FullName.Replace("- Aula " + i.ToString("00") + " -", "- Aula " + (i + 1).ToString("00") + " -"));
                //        File.Move(item.FullName, item.FullName.Replace("- Aula " + i.ToString("00") + " -", "- Aula " + (i + 1).ToString("00") + " -"));
                //    }
                //}
            }

            //foreach (string file in files)
            //{
            //    listBox1.Items.Add(file);
            //}

            listBox1.Items.Add("");
            listBox1.Items.Add("Items Listados: " + listBox1.Items.Count);
        }

        private void Btn_NomesFalhados_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string drivePath = @"E:\Knowledge Project\Ensino Superior";
            List<string> files = new List<string>();
            foreach (string dirPath in Directory.GetDirectories(drivePath, "*.*", SearchOption.AllDirectories))
            {
                foreach (FileInfo item in new DirectoryInfo(dirPath).GetFiles())
                {
                    if (!item.FullName.Contains("- Aula 01 -") && !item.FullName.Contains("- Aula 02 -") && !item.FullName.Contains("- Aula 03 -") &&
                        !item.FullName.Contains("- Aula 04 -") && !item.FullName.Contains("- Aula 05 -") && !item.FullName.Contains("- Aula 06 -") &&
                        !item.FullName.Contains("- Aula 07 -") && !item.FullName.Contains("- Aula 08 -") && !item.FullName.Contains("- Aula 09 -") &&
                        !item.FullName.Contains("- Aula 10 -") && !item.FullName.Contains("- Aula 11 -") && !item.FullName.Contains("- Aula 12 -") &&
                        !item.FullName.Contains("- Aula 13 -") && !item.FullName.Contains("- Aula 14 -") && !item.FullName.Contains("- Aula 15 -") &&
                        !item.FullName.Contains("- Aula 16 -") && !item.FullName.Contains("- Aula 17 -") && !item.FullName.Contains("- Aula 18 -") &&
                        !item.FullName.Contains("- Aula 19 -") && !item.FullName.Contains("- Aula 20 -") && !item.FullName.Contains("- Aula 21 -") &&
                        !item.FullName.Contains("- Aula 22 -") && !item.FullName.Contains("- Aula 23 -") && !item.FullName.Contains("- Aula 24 -") &&
                        !item.FullName.Contains("- Aula 25 -") && !item.FullName.Contains("- Aula 26 -") && !item.FullName.Contains("- Aula 27 -") &&
                        !item.FullName.Contains("- Aula 28 -") && !item.FullName.Contains("- Aula 29 -") && !item.FullName.Contains("- Aula 30 -"))
                    {
                        if (!item.FullName.Contains("Apresentação da disciplina") && !item.FullName.Contains("Apresentação.") &&
                           !item.FullName.Contains("Aula Inaugural"))
                        {
                            files.Add(item.FullName);
                        }
                    }
                }
            }

            foreach (string file in files)
            {
                listBox1.Items.Add(file);
            }

            listBox1.Items.Add("");
            listBox1.Items.Add("Items Listados: " + files.Count);
        }
        #endregion

        private void Btn_Bimestres_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            List<string> dirs = new List<string>();

            foreach (string dir in Directory.GetDirectories(currentPath))
            {
                dirs.Add(new DirectoryInfo(dir).Name);
            }

            foreach (string dir in dirs)
            {
                listBox1.Items.Add(dir);
            }

            listBox1.Items.Add("");
            listBox1.Items.Add(" << Voltar");
            listBox1.Items.Add("Items Listados: " + dirs.Count);
        }

        private void Btn_Aulas_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (Directory.Exists(currentPath))
            {
                List<string> dirs = new List<string>();
                foreach (FileInfo item in new DirectoryInfo(currentPath).GetFiles("*.*", SearchOption.AllDirectories))
                {
                    dirs.Add(item.Name);
                }

                foreach (string file in dirs)
                {
                    listBox1.Items.Add(file);
                }

                listBox1.Items.Add("");
                listBox1.Items.Add("Items Listados: " + dirs.Count);
            }
        }

        private void Btn_Cronograma_Click(object sender, EventArgs e)
        {
            cronograma = true;
            listBox1.Items.Clear();

            List<string> dirs = new List<string>();
            foreach (string dirPath in Directory.GetDirectories(currentPath, "*.*", SearchOption.AllDirectories))
            {
                int x = Directory.GetFiles(dirPath).Length;
                dirs.Add(x + " - " + (x / 5) + " - " + new DirectoryInfo(dirPath).Name);

                //foreach (FileInfo item in new DirectoryInfo(dirPath).GetFiles())
                //{
                //    dirs.Add(item.Name);
                //}
            }

            foreach (string file in dirs)
            {
                listBox1.Items.Add(file);
            }

            listBox1.Items.Add("");
            listBox1.Items.Add("Items Listados: " + dirs.Count);
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (!cronograma)
            {
                #region Cronograma false
                if (listBox1.SelectedItem != null)
                {
                    if (listBox1.SelectedItem.ToString() != " << Voltar")
                    {
                        if (Directory.Exists(currentPath + "\\" + listBox1.SelectedItem.ToString()))
                        {
                            try
                            {
                                currentPath += "\\" + listBox1.SelectedItem.ToString();
                                Btn_Bimestres_Click(btn_Bimestres, EventArgs.Empty);
                            }
                            catch { }
                        }
                    }
                    else
                    {
                        if (Directory.Exists(currentPath.Remove(currentPath.LastIndexOf("\\"))))
                        {
                            try
                            {
                                currentPath = currentPath.Remove(currentPath.LastIndexOf("\\"));
                                Btn_Bimestres_Click(btn_Bimestres, EventArgs.Empty);
                            }
                            catch { }
                        }
                    }
                }
                #endregion                
            }
            else
            {
                List<string> aulas = new List<string>();
                MessageBox.Show(currentPath);
                listBox2.Items.Add(listBox1.SelectedItem);
            }
        }

        private void Btn_MontaCronograma_Click(object sender, EventArgs e)
        {
            Hide();
            FormMontaCronograma f = new FormMontaCronograma(currentPath);
            f.ShowDialog();
            Show();
        }
    }
}

