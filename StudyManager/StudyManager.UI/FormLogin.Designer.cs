namespace StudyManager.UI
{
    partial class FormLogin
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
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.label_Head = new System.Windows.Forms.Label();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label_Retorno = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.Lime;
            this.btn_Entrar.Location = new System.Drawing.Point(391, 183);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(147, 35);
            this.btn_Entrar.TabIndex = 2;
            this.btn_Entrar.Text = "entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.cmd_Login);
            // 
            // label_Head
            // 
            this.label_Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Head.ForeColor = System.Drawing.Color.Turquoise;
            this.label_Head.Location = new System.Drawing.Point(9, 33);
            this.label_Head.Name = "label_Head";
            this.label_Head.Size = new System.Drawing.Size(759, 75);
            this.label_Head.TabIndex = 0;
            this.label_Head.Text = "Acesso ao Sistema";
            this.label_Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Login
            // 
            this.txt_Login.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Login.ForeColor = System.Drawing.Color.Turquoise;
            this.txt_Login.Location = new System.Drawing.Point(238, 145);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(300, 32);
            this.txt_Login.TabIndex = 1;
            this.txt_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Login_KeyPress);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.Lime;
            this.btn_Cancelar.Location = new System.Drawing.Point(238, 183);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(147, 35);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.cmd_Cancelar);
            // 
            // label_Retorno
            // 
            this.label_Retorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Retorno.ForeColor = System.Drawing.Color.Lime;
            this.label_Retorno.Location = new System.Drawing.Point(9, 229);
            this.label_Retorno.Name = "label_Retorno";
            this.label_Retorno.Size = new System.Drawing.Size(759, 180);
            this.label_Retorno.TabIndex = 4;
            this.label_Retorno.Text = "Identifique-se";
            this.label_Retorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.label_Head);
            this.panelContent.Controls.Add(this.label_Retorno);
            this.panelContent.Controls.Add(this.btn_Entrar);
            this.panelContent.Controls.Add(this.btn_Cancelar);
            this.panelContent.Controls.Add(this.txt_Login);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(776, 426);
            this.panelContent.TabIndex = 5;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Resize += new System.EventHandler(this.FormLogin_Resize);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Label label_Head;
        private System.Windows.Forms.TextBox txt_Login;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label_Retorno;
        private System.Windows.Forms.Panel panelContent;
    }
}