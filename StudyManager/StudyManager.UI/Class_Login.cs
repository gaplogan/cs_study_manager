using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace StudyManager.UI
{
    public static class Class_Login
    {

        public static string User { get; private set; } = "";
        public static string Matricula { get; private set; } = "";
        public static string Nivel { get; private set; } = "";
        public static string Status { get; private set; } = "";
        public static string Data_Cadastro { get; private set; } = "";
        public static bool Logado { get; private set; } = false;

        // Enumerações para Opções de retorno do Método Login
        public enum LoginReturn { False, True, Usuario_Incorreto, Senha_Invalida };

        public static LoginReturn Login(string user, string password)
        {
            User = "";
            Matricula = "";
            Nivel = "";
            Status = "";
            Data_Cadastro = "";

            LoginReturn retorno = LoginReturn.False;

            if (user != null && user != "" && password != null && password != "")
            {
                // Conectar com a base de dados
                MySqlConnection conexao = Class_DataBase.Conexao;

                try
                {
                    // Criar a tabela para armazenar os dados.
                    DataTable dados = new DataTable();

                    // Adaptador para executar as MySql Query.
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT usuario_id, senha, nivel, status, data_cadastro FROM usuarios WHERE matricula = '" + user + "'", conexao);

                    // Abrir a conexão com a base de dados.
                    conexao.Open();

                    // Colocar os dados na tabela.
                    adapter.Fill(dados);

                    if (dados.Rows.Count > 0)
                    {
                        MD5 md5Hash = MD5.Create();

                        if (VerifyMd5Hash(md5Hash, password, dados.Rows[0]["senha"].ToString()))
                        {
                            if (dados.Rows[0]["usuario_id"].ToString() != null && dados.Rows[0]["usuario_id"].ToString() != "")
                            {
                                User = dados.Rows[0]["usuario_id"].ToString();
                                Matricula = user;
                                Nivel = dados.Rows[0]["nivel"].ToString();
                                Status = dados.Rows[0]["status"].ToString();
                                Data_Cadastro = dados.Rows[0]["data_cadastro"].ToString();
                                Logado = true;
                                retorno = LoginReturn.True;
                            }
                            else
                            {
                                retorno = LoginReturn.False;
                            }
                        }
                        else
                        {
                            retorno = LoginReturn.Senha_Invalida;
                        }
                    }
                    else
                    {
                        retorno = LoginReturn.Usuario_Incorreto;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro Login: \n" + ex);
                    User = "";
                    Matricula = "";
                    Nivel = "";
                    Status = "";
                    Data_Cadastro = "";
                    retorno = LoginReturn.False;
                }
                finally
                {
                    // Fechar a conexão.
                    conexao.Close();
                }
            }            

            return retorno;
        }

        public static void Logout()
        {
            User = "";
            Matricula = "";
            Nivel = "";
            Status = "";
            Data_Cadastro = "";
            Logado = false;
        }

        public static bool VerificaUsuario(string user)
        {
            bool retorno = false;

            if (user != null && user != "")
            {
                // Conectar com a base de dados
                MySqlConnection conexao = Class_DataBase.Conexao;

                try
                {
                    // Criar a tabela para armazenar os dados.
                    DataTable dados = new DataTable();

                    // Adaptador para executar as MySql Query.
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM usuarios WHERE matricula = '" + user + "'", conexao);

                    // Abrir a conexão com a base de dados.
                    conexao.Open();

                    // Colocar os dados na tabela.
                    adapter.Fill(dados);

                    if (dados.Rows.Count > 0)
                    {
                        retorno = true;
                    }
                    else
                    {
                        retorno = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro Verifica Usuário: \n" + ex);                    
                    retorno = false;
                }
                finally
                {
                    // Fechar a conexão.
                    conexao.Close();
                }
            }

            return retorno;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Cryptografar(string strCrypt, int strLength = 0)
        {
            string strCrypto = null;

            if (strCrypt != null && strCrypt != "" && strLength < (strCrypt.Length + 2) * 2)
            {
                strLength = (strCrypt.Length + 2) * 2;
            }

            if (strCrypt != null && strCrypt != "" && strLength >= (strCrypt.Length + 2) * 2)
            {
                Random r = new Random();
                int vControl = r.Next(1, 20);

                for (int i = 0; i < strLength / 2; i++)
                {
                    if (i == 0)
                    {
                        strCrypto += Convert.ToByte(vControl).ToString("X2");
                    }
                    else if (i == 1)
                    {
                        strCrypto += Convert.ToByte(strCrypt.Length + vControl).ToString("X2");
                    }
                    else if (i > 1 && i <= (strCrypt.Length + 1))
                    {
                        strCrypto += Convert.ToByte(strCrypt[i - 2] + vControl).ToString("X2");
                    }
                    else
                    {
                        strCrypto += Convert.ToByte(r.Next(1, 100)).ToString("X2");
                    }
                }
            }

            return strCrypto;
        }

        private static string Desryptografar(string strCrypt)
        {
            string strCrypto = null;

            if (strCrypt != null && strCrypt != "" && strCrypt.Length > 5)
            {
                for (int i = 0; i < strCrypt.Length / 2; i++)
                {
                    if (i > 1 && i < (Convert.ToByte(strCrypt.Substring(2, 2), 16) - Convert.ToByte(strCrypt.Substring(0, 2), 16)) + 2)
                    {
                        strCrypto += (char)(Convert.ToByte(strCrypt.Substring(i * 2, 2), 16) - Convert.ToByte(strCrypt.Substring(0, 2), 16));
                    }
                }
            }

            return strCrypto;
        }
                
        public static string CryptografarConst(string strCrypt)
        {
            string strCrypto = null;

            if (strCrypt != null && strCrypt != "")
            {
                Random r = new Random();

                for (int i = 0; i <= strCrypt.Length; i++)
                {
                    if (i < 1)
                    {
                        strCrypto += Convert.ToByte(strCrypt.Length * strCrypt.Length).ToString("X2");
                    }
                    else
                    {
                        strCrypto += Convert.ToByte(strCrypt[i - 1] + strCrypt.Length * strCrypt.Length).ToString("X2");
                    }
                }
            }

            return strCrypto;
        }

        public static string DesryptografarConst(string strCrypt)
        {
            string strCrypto = null;
            if (strCrypt != null && strCrypt != "" && strCrypt.Length > 3)
            {
                for (int i = 0; i < strCrypt.Length / 2; i++)
                {
                    if (i > 0)
                    {
                        strCrypto += (char)(Convert.ToByte(strCrypt.Substring(i * 2, 2), 16) - Convert.ToByte(strCrypt.Substring(0, 2), 16));
                    }
                }
            }

            return strCrypto;
        }

        public static string CryptografarVar(string strCrypt)
        {
            string strCrypto = null;

            if (strCrypt != null && strCrypt != "")
            {
                Random r = new Random();
                int vControl = r.Next(1, 100);

                for (int i = 0; i <= strCrypt.Length; i++)
                {
                    if (i < 1)
                    {
                        strCrypto += Convert.ToByte(vControl).ToString("X2");
                    }
                    else
                    {
                        strCrypto += Convert.ToByte(strCrypt[i - 1] + vControl).ToString("X2");
                    }
                }
            }

            return strCrypto;
        }

        public static string DesryptografarVar(string strCrypt)
        {
            string strCrypto = null;

            if (strCrypt != null && strCrypt != "" && strCrypt.Length > 3)
            {
                for (int i = 0; i < strCrypt.Length / 2; i++)
                {
                    if (i > 0)
                    {
                        strCrypto += (char)(Convert.ToByte(strCrypt.Substring(i * 2, 2), 16) - Convert.ToByte(strCrypt.Substring(0, 2), 16));
                    }
                }
            }

            return strCrypto;
        }
    }
}
