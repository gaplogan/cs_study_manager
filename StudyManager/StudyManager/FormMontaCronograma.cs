using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyManager
{
    public partial class FormMontaCronograma : Form
    {
        private string currentPath = "";
        Dictionary<string, string> aulas = null;
        Dictionary<string, string> aulasCronograma = null;

        public FormMontaCronograma(string path)
        {
            InitializeComponent();

            currentPath = path;
        }

        private void FormMontaCronograma_Load(object sender, EventArgs e)
        {
            aulasCronograma = new Dictionary<string, string>();
            ListaAulas();
        }

        private void ListaAulas()
        {
            listBox1.Items.Clear();

            if (Directory.Exists(currentPath))
            {
                aulas = new Dictionary<string, string>();

                foreach (FileInfo file in new DirectoryInfo(currentPath).GetFiles("*.*", SearchOption.AllDirectories))
                {
                    aulas.Add(file.Name, file.FullName);
                }

                foreach (var aula in aulas)
                {
                    listBox1.Items.Add(aula.Key);
                }

                label1.Text = aulas.Count().ToString() + " Items Listados";
            }
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                aulasCronograma.Add(listBox1.SelectedItem.ToString(), aulas[listBox1.SelectedItem.ToString()]);
                listBox2.Items.Clear();
                foreach (var item in aulasCronograma)
                {
                    listBox2.Items.Add(item.Key);
                }
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void Btn_MontaCronograma_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            Dictionary<string, int> materias = new Dictionary<string, int>();
            aulas = new Dictionary<string, string>();
            Dictionary<string, int> aulaDiv = new Dictionary<string, int>();

            foreach (DirectoryInfo item in new DirectoryInfo(currentPath).GetDirectories())
            {
                materias.Add(item.FullName, item.GetFiles().Length);
                aulaDiv.Add(item.FullName, 0);
            }

            int maxAulas = 0;
            foreach (var item in materias)
            {
                if (item.Value > maxAulas)
                {
                    maxAulas = item.Value;
                }
            }

            for (int i = 0; i < maxAulas; i++)
            {
                foreach (var materia in materias)
                {
                    if (new DirectoryInfo(materia.Key).GetFiles().Length == maxAulas / 2)
                    {
                        if (i % 2 == 0)
                        {
                            if (aulaDiv[materia.Key] < new DirectoryInfo(materia.Key).GetFiles().Length)
                            {
                                aulas.Add(new DirectoryInfo(materia.Key).GetFiles()[aulaDiv[materia.Key]].FullName, materia.Key);
                                listBox2.Items.Add(new DirectoryInfo(materia.Key).GetFiles()[aulaDiv[materia.Key]].FullName + " ======= " + materia.Key);
                                aulaDiv[materia.Key]++;
                            }
                        }
                    }
                    else if (new DirectoryInfo(materia.Key).GetFiles().Length == maxAulas / 4)
                    {
                        if (i % 4 == 0)
                        {
                            if (aulaDiv[materia.Key] < new DirectoryInfo(materia.Key).GetFiles().Length)
                            {
                                aulas.Add(new DirectoryInfo(materia.Key).GetFiles()[aulaDiv[materia.Key]].FullName, materia.Key);
                                listBox2.Items.Add(new DirectoryInfo(materia.Key).GetFiles()[aulaDiv[materia.Key]].FullName + " ======= " + materia.Key);
                                aulaDiv[materia.Key]++;
                            }
                        }
                    }
                    else if (new DirectoryInfo(materia.Key).GetFiles().Length == maxAulas / 8)
                    {
                        if (i % 8 == 0)
                        {
                            if (aulaDiv[materia.Key] < new DirectoryInfo(materia.Key).GetFiles().Length)
                            {
                                aulas.Add(new DirectoryInfo(materia.Key).GetFiles()[aulaDiv[materia.Key]].FullName, materia.Key);
                                listBox2.Items.Add(new DirectoryInfo(materia.Key).GetFiles()[aulaDiv[materia.Key]].FullName + " ======= " + materia.Key);
                                aulaDiv[materia.Key]++;
                            }
                        }
                    }
                    else
                    {
                        if (i < new DirectoryInfo(materia.Key).GetFiles().Length)
                        {
                            aulas.Add(new DirectoryInfo(materia.Key).GetFiles()[i].FullName, materia.Key);
                            listBox2.Items.Add(new DirectoryInfo(materia.Key).GetFiles()[i].FullName + " ======= " + materia.Key);
                        }
                    }
                }
            }

            label2.Text = listBox2.Items.Count.ToString() + " Items Listados - Maximo de Aulas ";
        }

        private void MontaCronograma()
        {
            listBox2.Items.Clear();

            Dictionary<string, int> materias = new Dictionary<string, int>();
            Dictionary<string, string> aulas = new Dictionary<string, string>();

            foreach (DirectoryInfo item in new DirectoryInfo(currentPath).GetDirectories())
            {
                materias.Add(item.FullName, item.GetFiles().Length);
            }

            int maxAulas = 0;
            foreach (var item in materias)
            {
                if (item.Value > maxAulas)
                {
                    maxAulas = item.Value;
                }
            }

            for (int i = 0; i < maxAulas; i++)
            {
                foreach (var materia in materias)
                {
                    if (i < new DirectoryInfo(materia.Key).GetFiles().Length)
                    {
                        aulas.Add(new DirectoryInfo(materia.Key).GetFiles()[i].Name, materia.Key);
                        listBox2.Items.Add(new DirectoryInfo(materia.Key).GetFiles()[i].Name);
                    }
                }
            }
        }

        private void MontaCronograma2()
        {
            listBox2.Items.Clear();

            Dictionary<string, int> materias = new Dictionary<string, int>();
            Dictionary<string, string> aulas = new Dictionary<string, string>();
            Dictionary<string, int> aulaPor2 = new Dictionary<string, int>();

            foreach (DirectoryInfo item in new DirectoryInfo(currentPath).GetDirectories())
            {
                materias.Add(item.FullName, item.GetFiles().Length);
                aulaPor2.Add(item.FullName, 0);
            }

            int maxAulas = 0;
            foreach (var item in materias)
            {
                if (item.Value > maxAulas)
                {
                    maxAulas = item.Value;
                }
            }

            for (int i = 0; i < maxAulas; i++)
            {
                foreach (var materia in materias)
                {
                    if (new DirectoryInfo(materia.Key).GetFiles().Length <= maxAulas / 2)
                    {
                        if (i % 2 == 0)
                        {
                            if (aulaPor2[materia.Key] < new DirectoryInfo(materia.Key).GetFiles().Length)
                            {
                                aulas.Add(new DirectoryInfo(materia.Key).GetFiles()[aulaPor2[materia.Key]].Name, materia.Key);
                                listBox2.Items.Add(new DirectoryInfo(materia.Key).GetFiles()[aulaPor2[materia.Key]].Name);
                                aulaPor2[materia.Key]++;
                            }
                        }
                    }
                    else
                    {
                        if (i < new DirectoryInfo(materia.Key).GetFiles().Length)
                        {
                            aulas.Add(new DirectoryInfo(materia.Key).GetFiles()[i].Name, materia.Key);
                            listBox2.Items.Add(new DirectoryInfo(materia.Key).GetFiles()[i].Name);
                        }
                    }
                }
            }
        }

        private void GerarSQL()
        {
            string sqlQuery = @"INSERT INTO aulas (aula_id, curso_id, modulo, materia, titulo, link_1, link_2, data_cadastro) VALUES ";
            string sqlLines = "";

            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ".sql");
            StreamWriter arquivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".sql", true, Encoding.Default);
            arquivo.WriteLine(sqlQuery);

            int i = 0;
            foreach (var aula in aulas)
            {
                try
                {
                    if (i < aulas.Count - 1)
                    {
                        sqlLines = "(NULL, '1', '" + aula.Key.Substring(aula.Key.LastIndexOf("Módulo"), 9) + "', '" +
                            aula.Value.Substring(aula.Value.LastIndexOf("\\") + 6) + "', '" +
                            aula.Key.Substring(aula.Key.LastIndexOf(" - Aula ") + 13).Replace(".mp4", "") + "', '" +
                            aula.Key.Replace(@"\", @"\\") + "', '', NOW()),";
                    }
                    else
                    {
                        sqlLines = "(NULL, '1', '" + aula.Key.Substring(aula.Key.LastIndexOf("Módulo"), 9) + "', '" +
                            aula.Value.Substring(aula.Value.LastIndexOf("\\") + 6) + "', '" +
                            aula.Key.Substring(aula.Key.LastIndexOf(" - Aula ") + 13).Replace(".mp4", "") + "', '" +
                            aula.Key.Replace(@"\", @"\\") + "', '', NOW());";
                    }
                    i++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na linha: " + i + " " + ex);
                }

                arquivo.WriteLine(sqlLines);
            }
            arquivo.Close();
        }

        private void Btn_GerarSQL_Click(object sender, EventArgs e)
        {
            string sqlQuery = @"INSERT INTO aulas (aula_id, curso_id, aula_modulo, aula_materia, aula_titulo, aula_link_1, aula_link_2, aula_data_cadastro) VALUES ";
            string sqlLines = "";

            StreamWriter arquivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\C++_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".sql", true, Encoding.Default);
            arquivo.WriteLine(sqlQuery);

            int i = 0;
            foreach (var aula in aulas)
            {
                try
                {
                    if (i < aulas.Count - 1)
                    {
                        sqlLines = "(NULL, 2, '" + aula.Key.Substring(aula.Key.LastIndexOf("Módulo"), 9) + "', '" +
                            aula.Value.Substring(aula.Value.LastIndexOf("\\") + 6) + "', '" +
                            aula.Key.Substring(aula.Key.LastIndexOf(" - Aula ") + 14).Replace(".mp4", "") + "', '" +
                            aula.Key.Replace(@"\", @"\\").Remove(0,4) + "', '', NOW()),";
                    }
                    else
                    {
                        sqlLines = "(NULL, 2, '" + aula.Key.Substring(aula.Key.LastIndexOf("Módulo"), 9) + "', '" +
                            aula.Value.Substring(aula.Value.LastIndexOf("\\") + 6) + "', '" +
                            aula.Key.Substring(aula.Key.LastIndexOf(" - Aula ") + 14).Replace(".mp4", "") + "', '" +
                            aula.Key.Replace(@"\", @"\\").Remove(0, 4) + "', '', NOW());";
                    }
                    i++;
                    arquivo.WriteLine(sqlLines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na linha: " + i + " " + ex);
                }                
            }
            arquivo.Close();
        }
    }
}
