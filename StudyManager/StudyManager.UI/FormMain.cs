using System;
using System.Windows.Forms;

namespace StudyManager.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Class_Settings.ParentSize = ClientSize;
            Class_Settings.VerificarSettingsFile();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!Class_Login.Logado)
            {
                FormLogin f = new FormLogin(this);
                f.Show();
            }
            else
            {
                FormStart f = new FormStart(this);
                f.Show();
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            Class_Settings.ParentSize = ClientSize;            
        }
    }
}
