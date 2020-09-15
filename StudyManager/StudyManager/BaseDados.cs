using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace StudyManager
{
    public static class BaseDados
    {
        private static string server = "127.0.0.1";
        private static string dataBase = "study_manager";
        private static string user = "root";
        private static string password = "logan";

        // Criar Conexão com a base de dados
        public static MySqlConnection conexao = new MySqlConnection("server=" + server + ";User Id=" + user + ";database=" + dataBase + ";password=" + password);
        
        public static void Listar(ListBox listBox)
        {
            try
            {
                // Criar a tabela para armazenar os dados.
                DataTable dados = new DataTable();

                // Adaptador para executar as MySql Query.
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM aulas", conexao);

                // Abrir a conexão com a base de dados.
                conexao.Open();

                // Colocar os dados na tabela.
                adapter.Fill(dados);

                // Apresentar os dados.
                listBox.Items.Clear();
                foreach (DataRow linha in dados.Rows)
                {
                    listBox.Items.Add(linha["aula_id"].ToString() + " - " + linha["curso"].ToString() + " - " + linha["bimestre"].ToString() +
                        " - " + linha["materia"].ToString() + " - " + linha["titulo"].ToString() + " - " + linha["assistido"].ToString() +
                        " - " + linha["link_1"].ToString() + " - " + linha["link_2"].ToString());
                }
            }
            catch (Exception ex)
            {
                listBox.Items.Clear();
                MessageBox.Show("Erro: \n" + ex);
            }
            finally
            {
                // Fechar a conexão.
                conexao.Close();
            }
        }

        public static void Inserir(ListBox listBox)
        {
            try
            {
                // Abrir a conexão com a base de dados.
                conexao.Open();

                // Inserir dados na tabela.
                string query = "INSERT INTO aulas (aula_id, curso, bimestre, materia, titulo, assistido, link_1, link_2) VALUES " +
                    "(NULL, 'curso 1', 'bimestre 1', 'materia 1', 'titulo 1', " + false + ", 'link1 1', 'link2 1'); ";

                // Criar o executador do comando.
                MySqlCommand execQuery = new MySqlCommand(query, conexao);
                execQuery.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                listBox.Items.Clear();
                MessageBox.Show("Erro: \n" + ex);
            }
            finally
            {
                // Fechar a conexão.
                conexao.Close();
            }

            Listar(listBox);
        }

        public static void Editar(ListBox listBox, int aula_id = -1)
        {
            try
            {
                // Abrir a conexão com a base de dados.
                conexao.Open();

                string query = "";

                if (aula_id != -1)
                {
                    // Atualizar a tabela.
                    query = "UPDATE aulas SET " +
                                        "curso = 'aaa', " +
                                        "bimestre = 'aaa', " +
                                        "materia = 'aaa', " +
                                        "titulo = 'aaa', " +
                                        "assistido = " + true + ", " +
                                        "link_1 = 'aaa', " +
                                        "link_2 = 'aaa' " +
                                    "WHERE aulas.aula_id = " + aula_id;

                    int res = new MySqlCommand(query, conexao).ExecuteNonQuery();

                    if (res > 0)
                    {
                        MessageBox.Show(res + " linhas afetadas");
                    }
                    else
                    {
                        MessageBox.Show("0 linhas afetadas");
                    }
                }
                else
                {
                    MessageBox.Show("0 linhas afetadas");
                }
            }
            catch (Exception ex)
            {
                listBox.Items.Clear();
                MessageBox.Show("Erro: \n" + ex);
            }
            finally
            {
                // Fechar a conexão.
                conexao.Close();
            }

            Listar(listBox);
        }

        public static void Excluir(ListBox listBox, int aula_id = -1)
        {
            try
            {
                // Abrir a conexão com a base de dados.
                conexao.Open();

                // Eliminar todos os registros da tabela.
                string query = "DELETE FROM aulas";

                if (aula_id != -1)
                {
                    // Eliminar um registro especifico da tabela.
                    query = "DELETE FROM aulas WHERE aula_id = " + aula_id;
                }

                int res = new MySqlCommand(query, conexao).ExecuteNonQuery();

                if (res > 0)
                {
                    MessageBox.Show(res + " registros excluidos");
                }
                else
                {
                    MessageBox.Show("0 registros excluidos");
                }
            }
            catch (Exception ex)
            {
                listBox.Items.Clear();
                MessageBox.Show("Erro: \n" + ex);
            }
            finally
            {
                // Fechar a conexão.
                conexao.Close();
            }

            Listar(listBox);
        }
    }    
}
