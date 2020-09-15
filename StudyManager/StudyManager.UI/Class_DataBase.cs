using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace StudyManager.UI
{
    public static class Class_DataBase
    {
        private static string server = "127.0.0.1";
        private static string dataBase = "study_manager";
        private static string user = "root";
        private static string password = "logan";

        public static MySqlConnection Conexao { get; } = new MySqlConnection("server=" + server + ";User Id=" + user + ";database=" + dataBase + ";password=" + password);

        private static List<Class_Cursos_do_Usuario> usuarioCursosInscritos = new List<Class_Cursos_do_Usuario>();

        public static List<Class_Curso_Aulas> cursoAulas;

        public static void ListarCursosUsuario(DataGridView dataGridView)
        {
            try
            {
                // Criar a tabela para armazenar os dados.
                DataTable dadosCursosUsuario = new DataTable();

                // Adaptador para executar as MySql Query.
                string sqlQuery = "SELECT * FROM cursos INNER JOIN usuarios_cursos ON cursos.curso_id = usuarios_cursos.usuarios_cursos_curso_id WHERE usuarios_cursos.usuario_id = '" + Class_Login.User + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, Conexao);

                // Abrir a conexão com a base de dados.
                Conexao.Open();

                // Colocar os dados na tabela.
                adapter.Fill(dadosCursosUsuario);

                // Apresentar os dados.
                dataGridView.Rows.Clear();

                dataGridView.DataSource = dadosCursosUsuario;

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    usuarioCursosInscritos.Add(new Class_Cursos_do_Usuario
                    {
                        Cursos_Curso_id = dataGridView.Rows[i].Cells["curso_id"].ToString(), // Tabela Cursos
                        Cursos_Curso = dataGridView.Rows[i].Cells["curso"].ToString(), // Tabela Cursos
                        Cursos_Curso_Nivel = dataGridView.Rows[i].Cells["curso_nivel"].ToString(), // Tabela Cursos
                        Cursos_Status = dataGridView.Rows[i].Cells["curso_status"].ToString(), // Tabela Cursos
                        Cursos_Cursos_Data_Cadastro = dataGridView.Rows[i].Cells["curso_data_cadastro"].ToString(), // Tabela Cursos
                        Usuarios_Cursos_Usuario_Curso_Id = dataGridView.Rows[i].Cells["usuario_curso_id"].ToString(), // Tabela Usuario Cursos
                        Usuarios_Cursos_Usuario_Id = dataGridView.Rows[i].Cells["usuario_id"].ToString(), // Tabela Usuario Cursos
                        Usuarios_Cursos_Curso_id = dataGridView.Rows[i].Cells["usuarios_cursos_curso_id"].ToString(), // Tabela Usuario Cursos
                        Usuarios_Cursos_Ultima_Aula_Assistida = dataGridView.Rows[i].Cells["ultima_aula_assistida"].ToString(), // Tabela Usuario Cursos
                        Usuarios_Cursos_Status = dataGridView.Rows[i].Cells["usuarios_cursos_status"].ToString(), // Tabela Usuario Cursos
                        Usuarios_Cursos_Data_Inscricao = dataGridView.Rows[i].Cells["usuarios_cursos_data_inscricao"].ToString(), // Tabela Usuario Cursos
                        Usuarios_Cursos_Ultimo_Acesso = dataGridView.Rows[i].Cells["usuarios_cursos_ultimo_acesso"].ToString(), // Tabela Usuario Cursos
                    });
                }

                dataGridView.Columns["curso_id"].Visible = false;
                dataGridView.Columns["curso"].Visible = true;
                dataGridView.Columns["curso_nivel"].Visible = true;
                dataGridView.Columns["curso_status"].Visible = false;
                dataGridView.Columns["curso_data_cadastro"].Visible = false;
                dataGridView.Columns["usuario_curso_id"].Visible = false;
                dataGridView.Columns["usuario_id"].Visible = false;
                dataGridView.Columns["usuarios_cursos_curso_id"].Visible = false;
                dataGridView.Columns["ultima_aula_assistida"].Visible = false;
                dataGridView.Columns["usuarios_cursos_status"].Visible = false;
                dataGridView.Columns["usuarios_cursos_data_inscricao"].Visible = true;
                dataGridView.Columns["usuarios_cursos_ultimo_acesso"].Visible = true;

                dataGridView.Columns["curso"].Width = CalcularLargura(dataGridView, 40);
                dataGridView.Columns["curso_nivel"].Width = CalcularLargura(dataGridView, 20);
                dataGridView.Columns["usuarios_cursos_data_inscricao"].Width = CalcularLargura(dataGridView, 20);
                dataGridView.Columns["usuarios_cursos_ultimo_acesso"].Width = CalcularLargura(dataGridView, 20);

                dataGridView.Columns["curso"].HeaderText = "Curso";
                dataGridView.Columns["curso_nivel"].HeaderText = "Curso Nível";
                dataGridView.Columns["usuarios_cursos_data_inscricao"].HeaderText = "Data Inscrição";
                dataGridView.Columns["usuarios_cursos_ultimo_acesso"].HeaderText = "Último Acesso";
            }
            catch (Exception ex1)
            {
                try
                {
                    dataGridView.Rows.Clear();
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Erro Ao tentar limpar as linhas: \n" + ex2);
                }

                Console.WriteLine("Erro Método ListarCursosUsuario: \n" + ex1);
            }
            finally
            {
                // Fechar a conexão.
                Conexao.Close();
            }
        }

        public static void ListarAulasDoCurso(int curso_id, DataGridView dataGridView)
        {
            cursoAulas = new List<Class_Curso_Aulas>();

            try
            {
                // Criar a tabela para armazenar os dados.
                DataTable cursoSelecionado = new DataTable();

                // Adaptador para executar as MySql Query.
                string sqlQuery = "SELECT * FROM aulas WHERE curso_id = '" + curso_id + "' ORDER BY aula_id ASC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, Conexao);

                // Abrir a conexão com a base de dados.
                Conexao.Open();

                // Colocar os dados na tabela.
                adapter.Fill(cursoSelecionado);

                // Apresentar os dados.
                dataGridView.Rows.Clear();

                dataGridView.DataSource = cursoSelecionado;

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    cursoAulas.Add(new Class_Curso_Aulas()
                    {
                        Aula_Id = Convert.ToInt32(dataGridView.Rows[i].Cells["aula_id"].Value),
                        Curso_Id = Convert.ToInt32(dataGridView.Rows[i].Cells["curso_id"].Value),
                        Aula_Modulo = dataGridView.Rows[i].Cells["aula_modulo"].Value.ToString(),
                        Aula_Materia = dataGridView.Rows[i].Cells["aula_materia"].Value.ToString(),
                        Aula_Titulo = dataGridView.Rows[i].Cells["aula_titulo"].Value.ToString(),
                        Aula_Link_1 = dataGridView.Rows[i].Cells["aula_link_1"].Value.ToString(),
                        Aula_Link_2 = dataGridView.Rows[i].Cells["aula_link_2"].Value.ToString(),
                        Aula_Data_Cadastro = dataGridView.Rows[i].Cells["aula_data_cadastro"].Value.ToString()
                    });
                }

                dataGridView.Columns["aula_id"].Visible = false;
                dataGridView.Columns["curso_id"].Visible = false;
                dataGridView.Columns["aula_modulo"].Visible = false;
                dataGridView.Columns["aula_materia"].Visible = true;
                dataGridView.Columns["aula_titulo"].Visible = true;
                dataGridView.Columns["aula_link_1"].Visible = false;
                dataGridView.Columns["aula_link_2"].Visible = false;
                dataGridView.Columns["aula_data_cadastro"].Visible = false;

                dataGridView.Columns["aula_materia"].Width = CalcularLargura(dataGridView, 30);
                dataGridView.Columns["aula_titulo"].Width = CalcularLargura(dataGridView, 70);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro Método ListarAulasDoCurso: \n" + ex);
            }
            finally
            {
                // Fechar a conexão.
                Conexao.Close();
            }
        }

        public static void DetalhesAula(int aula_id)
        {
            try
            {
                if (aula_id > 0)
                {
                    // Criar a tabela para armazenar os dados.
                    DataTable aulaSelecionada = new DataTable();

                    // Adaptador para executar as MySql Query.
                    string sqlQuery = "SELECT * FROM aulas WHERE aula_id = '" + aula_id + "'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, Conexao);

                    // Abrir a conexão com a base de dados.
                    //Conexao.Open();

                    // Colocar os dados na tabela.
                    adapter.Fill(aulaSelecionada);

                    if (aulaSelecionada.Rows.Count > 0)
                    {
                        Class_Aula_Selecionada.Aula_Id = aulaSelecionada.Rows[0].Field<int>("aula_id");
                        Class_Aula_Selecionada.Curso_Id = aulaSelecionada.Rows[0].Field<int>("curso_id");
                        Class_Aula_Selecionada.Aula_Modulo = aulaSelecionada.Rows[0].Field<string>("aula_modulo");
                        Class_Aula_Selecionada.Aula_Materia = aulaSelecionada.Rows[0].Field<string>("aula_materia");
                        Class_Aula_Selecionada.Aula_Titulo = aulaSelecionada.Rows[0].Field<string>("aula_titulo");
                        Class_Aula_Selecionada.Aula_Link_1 = aulaSelecionada.Rows[0].Field<string>("aula_link_1");
                        Class_Aula_Selecionada.Aula_Link_2 = aulaSelecionada.Rows[0].Field<string>("aula_link_2");
                        Class_Aula_Selecionada.Aula_Data_Cadastro = aulaSelecionada.Rows[0].Field<string>("aula_data_cadastro");
                    }
                    else
                    {
                        Class_Aula_Selecionada.ResetarAulaSelecionada();
                    }
                }
                else
                {
                    Class_Aula_Selecionada.ResetarAulaSelecionada();
                }
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Erro Método DetalhesAula: \n" + ex1);
            }
            finally
            {
                // Fechar a conexão.
                Conexao.Close();
            }
        }

        public static void DetalhesCurso(int curso_id)
        {
            try
            {
                if (curso_id > 0)
                {
                    // Criar a tabela para armazenar os dados.
                    DataTable cursoSelecionada = new DataTable();

                    // Adaptador para executar as MySql Query.
                    string sqlQuery = "SELECT * FROM cursos WHERE curso_id = '" + curso_id + "'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sqlQuery, Conexao);

                    // Colocar os dados na tabela.
                    adapter.Fill(cursoSelecionada);

                    if (cursoSelecionada.Rows.Count > 0)
                    {
                        Class_Curso_Selecionado.Curso_Id = cursoSelecionada.Rows[0].Field<int>("curso_id");
                        Class_Curso_Selecionado.Curso = cursoSelecionada.Rows[0].Field<string>("curso");
                        Class_Curso_Selecionado.Curso_Nivel = cursoSelecionada.Rows[0].Field<string>("curso_nivel");
                        Class_Curso_Selecionado.Curso_Status = cursoSelecionada.Rows[0].Field<string>("curso_status");
                        Class_Curso_Selecionado.Curso_Data_Cadastro = cursoSelecionada.Rows[0].Field<string>("curso_data_cadastro");
                    }
                    else
                    {
                        Class_Curso_Selecionado.ResetarCursoSelecionado();
                    }
                }
                else
                {
                    Class_Curso_Selecionado.ResetarCursoSelecionado();
                }
            }
            catch (Exception ex1)
            {
                Console.WriteLine("Erro Método DetalhesCurso: \n" + ex1);
            }
            finally
            {
                // Fechar a conexão.
                Conexao.Close();
            }
        }

        public static void GravarProximaAula(int aula_id, int curso_id)
        {
            try
            {
                // Abrir a conexão com a base de dados.
                Conexao.Open();

                string sqlQuery = "";

                if (aula_id > 0)
                {
                    // Atualizar a tabela.
                    sqlQuery = "UPDATE usuarios_cursos SET " +
                                "ultima_aula_assistida = '" + aula_id + "' " +
                                "WHERE usuarios_cursos.usuario_id = '" + Class_Login.User + "' AND usuarios_cursos_curso_id = '" + curso_id + "'";

                    int res = new MySqlCommand(sqlQuery, Conexao).ExecuteNonQuery();

                    if (res > 0)
                    {
                        Console.WriteLine("\n ====> " + res + " linhas afetadas\n");
                    }
                    else
                    {
                        Console.WriteLine("\n ====> 0 linhas afetadas\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n ====> 0 linhas afetadas\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro GravarProximaAula: \n" + ex);
            }
            finally
            {
                // Fechar a conexão.
                Conexao.Close();
            }
        }

        private static int CalcularLargura(DataGridView dataGridView, int percentagem)
        {
            int larguraGrade = dataGridView.Width - 20;
            int resultado = (larguraGrade * percentagem) / 100;
            return resultado;
        }
    }
}
