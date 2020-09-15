using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyManager.UI
{
    public partial class FormLogin : Form
    {
        private string userTemp = "";

        public FormLogin(Form formParent)
        {
            InitializeComponent();
            #region Metódo Necessário em todas as Forms
            MdiParent = formParent;
            formParent.Resize += new EventHandler(FormLogin_Resize);
            panelContent.Location = new Point((Width - panelContent.Width) / 2, (Height - panelContent.Height) / 2);
            #endregion
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cmd_Cancelar(sender, EventArgs.Empty);
        }

        private void cmd_Login(object sender, EventArgs e)
        {            
            // Verifica se o campo está vázio.
            if (txt_Login.Text != null && txt_Login.Text != "")
            {
                // Se o campo estiver vázio, Verifica se userTemp está vázio.
                if (userTemp != null && userTemp != "")
                {
                    // Caso userTemp não estiver vázio, verifica e compara os retornos de Login da senha.
                    if (Class_Login.Login(userTemp, txt_Login.Text) == Class_Login.LoginReturn.True)
                    {
                        // Caso usuario e senha ok, retorna e preenche os dados.
                        label_Retorno.ForeColor = Color.Lime;
                        txt_Login.PasswordChar = (char)0;
                        label_Retorno.Text = "";

                        FormStart f = new FormStart(MdiParent);
                        f.Show();
                        Close();
                    }
                    else if (Class_Login.Login(userTemp, txt_Login.Text) == Class_Login.LoginReturn.Senha_Invalida)
                    {
                        // Caso usuario ok, mas senha inválida, informa.
                        label_Retorno.ForeColor = Color.DarkRed;
                        label_Retorno.Text = "Senha Inválida";
                        txt_Login.Text = "";
                        txt_Login.PasswordChar = '*';
                    }
                    else
                    {
                        // Caso erro de acesso, informa.
                        label_Retorno.ForeColor = Color.DarkRed;
                        label_Retorno.Text = "Matricula: " + userTemp + "\nAcesso Negado";
                        txt_Login.Text = "";
                        txt_Login.PasswordChar = '*';
                    }
                }
                else
                {
                    // Caso userTemp estiver vázio, Verifica se o usuário existe.
                    if (Class_Login.VerificaUsuario(txt_Login.Text))
                    {
                        // Caso o usuário exista, armazena a sua Matricula em userTemp e pede a senha.
                        userTemp = txt_Login.Text;
                        label_Retorno.ForeColor = Color.Lime;
                        label_Retorno.Text = "Digite sua senha";                        
                        txt_Login.Text = "";
                        txt_Login.PasswordChar = '*';
                    }
                    else
                    {
                        // Caso o usuário não exista, Informa.
                        label_Retorno.ForeColor = Color.DarkRed;
                        label_Retorno.Text = "Usuário não cadastrado";
                        txt_Login.PasswordChar = (char)0;
                        txt_Login.Text = "";
                    }
                }
            }
            else
            {
                // Se o campo estiver vázio, Verifica se userTemp está vázio.                
                if (userTemp != null && userTemp != "")
                {
                    // Caso userTemp não estiver vázio, pede a senha.
                    label_Retorno.ForeColor = Color.Orange;
                    label_Retorno.Text = "Matricula: " + userTemp + "\nDigite a sua senha";
                    txt_Login.Text = "";
                    txt_Login.PasswordChar = '*';
                }
                else
                {   
                    // Caso userTemp estiver vázio, pede um usuário.
                    label_Retorno.ForeColor = Color.Lime;
                    label_Retorno.Text = "Identifique-se";
                    txt_Login.PasswordChar = (char)0;
                    txt_Login.Text = "";
                }
            }

            txt_Login.Select();
        }

        private void cmd_Cancelar(object sender, EventArgs e)
        {
            Class_Login.Logout();
            userTemp = "";
            label_Retorno.ForeColor = Color.Lime;
            label_Retorno.Text = "Identifique-se" + userTemp;
            txt_Login.Text = "";
            txt_Login.PasswordChar = (char)0;
            txt_Login.Select();
        }

        private void Txt_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                cmd_Login(sender, KeyPressEventArgs.Empty);
            }
        }

        #region Metódo Necessário em todas as Forms
        private void FormLogin_Resize(object sender, EventArgs e)
        {
            // Para redimensionar a form segundo o tamanho do parent.
            Size = new Size(Class_Settings.ParentSize.Width - 4, Class_Settings.ParentSize.Height - 4);
            Location = new Point(0, 0);
            // Para posicionar o conteúdo sempre no meio da form.
            panelContent.Location = new Point((Width - panelContent.Width) / 2, (Height - panelContent.Height) / 2);
        }
        #endregion

    }
}
