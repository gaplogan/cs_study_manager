namespace StudyManager.UI
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContent = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FolderRoot = new System.Windows.Forms.Label();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.folderBrowserFolderRoot = new System.Windows.Forms.FolderBrowserDialog();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.txt_FolderRoot);
            this.panelContent.Controls.Add(this.btn_Fechar);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1245, 675);
            this.panelContent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pasta Raiz dos Cursos";
            // 
            // txt_FolderRoot
            // 
            this.txt_FolderRoot.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_FolderRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FolderRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FolderRoot.ForeColor = System.Drawing.Color.Aqua;
            this.txt_FolderRoot.Location = new System.Drawing.Point(37, 46);
            this.txt_FolderRoot.Name = "txt_FolderRoot";
            this.txt_FolderRoot.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txt_FolderRoot.Size = new System.Drawing.Size(1168, 35);
            this.txt_FolderRoot.TabIndex = 22;
            this.txt_FolderRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_FolderRoot.Click += new System.EventHandler(this.Txt_FolderRoot_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fechar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_Fechar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.ForeColor = System.Drawing.Color.Lime;
            this.btn_Fechar.Location = new System.Drawing.Point(946, 598);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(294, 72);
            this.btn_Fechar.TabIndex = 2;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1270, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.Resize += new System.EventHandler(this.FormSettings_Resize);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_FolderRoot;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserFolderRoot;
    }
}