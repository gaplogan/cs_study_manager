using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyManager.UI
{
    public partial class FormSettings : Form
    {
        public FormSettings(Form formParent)
        {
            InitializeComponent();
            #region Metódo Necessário em todas as Forms
            MdiParent = formParent;
            formParent.Resize += new EventHandler(FormSettings_Resize);
            panelContent.Location = new Point((Width - panelContent.Width) / 2, (Height - panelContent.Height) / 2);
            #endregion

        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }

        #region Metódo Necessário em todas as Forms
        private void FormSettings_Resize(object sender, EventArgs e)
        {
            Size = new Size(Class_Settings.ParentSize.Width - 4, Class_Settings.ParentSize.Height - 4);
            Location = new Point(0, 0);
            panelContent.Location = new Point((Width - panelContent.Width) / 2, (Height - panelContent.Height) / 2);

            txt_FolderRoot.Text = Class_Settings.FolderPath;
        }
        #endregion

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            FormStart f = new FormStart(MdiParent);
            f.Show();
            Close();
        }

        private void Txt_FolderRoot_Click(object sender, EventArgs e)
        {
            folderBrowserFolderRoot.SelectedPath = txt_FolderRoot.Text;
            if (folderBrowserFolderRoot.ShowDialog() != DialogResult.Cancel)
            {
                txt_FolderRoot.Text = folderBrowserFolderRoot.SelectedPath;
                Class_Settings.FolderPath = txt_FolderRoot.Text;
                Class_Settings.CriarSettingsFile();
            }            
        }
    }
}
