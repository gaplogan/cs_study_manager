namespace StudyManager.UI
{
    partial class FormCursoDetalhes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Video = new System.Windows.Forms.Panel();
            this.btn_AssistirAula = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_AulaTitulo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_AulaMateria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AulaModulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nivel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Curso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewAulas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_IrParaProximaAula = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.label_Retorno = new System.Windows.Forms.Label();
            this.panel_Video.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAulas)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Video
            // 
            this.panel_Video.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Video.Controls.Add(this.btn_AssistirAula);
            this.panel_Video.Controls.Add(this.label8);
            this.panel_Video.Controls.Add(this.txt_AulaTitulo);
            this.panel_Video.Controls.Add(this.label10);
            this.panel_Video.Controls.Add(this.txt_AulaMateria);
            this.panel_Video.Controls.Add(this.label4);
            this.panel_Video.Controls.Add(this.txt_AulaModulo);
            this.panel_Video.Controls.Add(this.label3);
            this.panel_Video.Controls.Add(this.txt_Nivel);
            this.panel_Video.Controls.Add(this.label2);
            this.panel_Video.Controls.Add(this.txt_Curso);
            this.panel_Video.Location = new System.Drawing.Point(3, 3);
            this.panel_Video.Name = "panel_Video";
            this.panel_Video.Size = new System.Drawing.Size(720, 405);
            this.panel_Video.TabIndex = 0;
            // 
            // btn_AssistirAula
            // 
            this.btn_AssistirAula.BackColor = System.Drawing.Color.Transparent;
            this.btn_AssistirAula.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_AssistirAula.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_AssistirAula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AssistirAula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AssistirAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AssistirAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AssistirAula.ForeColor = System.Drawing.Color.Lime;
            this.btn_AssistirAula.Location = new System.Drawing.Point(209, 280);
            this.btn_AssistirAula.Name = "btn_AssistirAula";
            this.btn_AssistirAula.Size = new System.Drawing.Size(300, 110);
            this.btn_AssistirAula.TabIndex = 0;
            this.btn_AssistirAula.Text = "Assistir Aula";
            this.btn_AssistirAula.UseVisualStyleBackColor = false;
            this.btn_AssistirAula.Click += new System.EventHandler(this.Btn_AssistirAula_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(64, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Titulo";
            // 
            // txt_AulaTitulo
            // 
            this.txt_AulaTitulo.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_AulaTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AulaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AulaTitulo.ForeColor = System.Drawing.Color.Aqua;
            this.txt_AulaTitulo.Location = new System.Drawing.Point(59, 233);
            this.txt_AulaTitulo.Name = "txt_AulaTitulo";
            this.txt_AulaTitulo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txt_AulaTitulo.Size = new System.Drawing.Size(600, 35);
            this.txt_AulaTitulo.TabIndex = 32;
            this.txt_AulaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(64, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Matéria";
            // 
            // txt_AulaMateria
            // 
            this.txt_AulaMateria.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_AulaMateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AulaMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AulaMateria.ForeColor = System.Drawing.Color.Aqua;
            this.txt_AulaMateria.Location = new System.Drawing.Point(59, 181);
            this.txt_AulaMateria.Name = "txt_AulaMateria";
            this.txt_AulaMateria.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txt_AulaMateria.Size = new System.Drawing.Size(600, 35);
            this.txt_AulaMateria.TabIndex = 30;
            this.txt_AulaMateria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(64, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Módulo";
            // 
            // txt_AulaModulo
            // 
            this.txt_AulaModulo.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_AulaModulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AulaModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AulaModulo.ForeColor = System.Drawing.Color.Aqua;
            this.txt_AulaModulo.Location = new System.Drawing.Point(59, 129);
            this.txt_AulaModulo.Name = "txt_AulaModulo";
            this.txt_AulaModulo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txt_AulaModulo.Size = new System.Drawing.Size(600, 35);
            this.txt_AulaModulo.TabIndex = 28;
            this.txt_AulaModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(64, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nível";
            // 
            // txt_Nivel
            // 
            this.txt_Nivel.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_Nivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nivel.ForeColor = System.Drawing.Color.Aqua;
            this.txt_Nivel.Location = new System.Drawing.Point(59, 77);
            this.txt_Nivel.Name = "txt_Nivel";
            this.txt_Nivel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txt_Nivel.Size = new System.Drawing.Size(600, 35);
            this.txt_Nivel.TabIndex = 26;
            this.txt_Nivel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(64, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Curso";
            // 
            // txt_Curso
            // 
            this.txt_Curso.BackColor = System.Drawing.SystemColors.Desktop;
            this.txt_Curso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Curso.ForeColor = System.Drawing.Color.Aqua;
            this.txt_Curso.Location = new System.Drawing.Point(59, 25);
            this.txt_Curso.Name = "txt_Curso";
            this.txt_Curso.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txt_Curso.Size = new System.Drawing.Size(600, 35);
            this.txt_Curso.TabIndex = 20;
            this.txt_Curso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridViewAulas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(729, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 668);
            this.panel1.TabIndex = 1;
            // 
            // dataGridViewAulas
            // 
            this.dataGridViewAulas.AllowUserToAddRows = false;
            this.dataGridViewAulas.AllowUserToDeleteRows = false;
            this.dataGridViewAulas.AllowUserToResizeColumns = false;
            this.dataGridViewAulas.AllowUserToResizeRows = false;
            this.dataGridViewAulas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.dataGridViewAulas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAulas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAulas.ColumnHeadersHeight = 50;
            this.dataGridViewAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAulas.ColumnHeadersVisible = false;
            this.dataGridViewAulas.Location = new System.Drawing.Point(4, 47);
            this.dataGridViewAulas.MultiSelect = false;
            this.dataGridViewAulas.Name = "dataGridViewAulas";
            this.dataGridViewAulas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAulas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAulas.RowHeadersVisible = false;
            this.dataGridViewAulas.RowHeadersWidth = 80;
            this.dataGridViewAulas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAulas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAulas.RowTemplate.Height = 50;
            this.dataGridViewAulas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAulas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAulas.Size = new System.Drawing.Size(503, 616);
            this.dataGridViewAulas.TabIndex = 1;
            this.dataGridViewAulas.SelectionChanged += new System.EventHandler(this.DataGridViewAulas_SelectionChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aulas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label_Retorno);
            this.panel2.Controls.Add(this.btn_IrParaProximaAula);
            this.panel2.Controls.Add(this.btn_Voltar);
            this.panel2.Location = new System.Drawing.Point(3, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 257);
            this.panel2.TabIndex = 2;
            // 
            // btn_IrParaProximaAula
            // 
            this.btn_IrParaProximaAula.BackColor = System.Drawing.Color.Transparent;
            this.btn_IrParaProximaAula.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_IrParaProximaAula.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_IrParaProximaAula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_IrParaProximaAula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_IrParaProximaAula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_IrParaProximaAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IrParaProximaAula.ForeColor = System.Drawing.Color.Lime;
            this.btn_IrParaProximaAula.Location = new System.Drawing.Point(415, 142);
            this.btn_IrParaProximaAula.Name = "btn_IrParaProximaAula";
            this.btn_IrParaProximaAula.Size = new System.Drawing.Size(300, 110);
            this.btn_IrParaProximaAula.TabIndex = 3;
            this.btn_IrParaProximaAula.Text = "Ir Para Próxima Aula";
            this.btn_IrParaProximaAula.UseVisualStyleBackColor = false;
            this.btn_IrParaProximaAula.Click += new System.EventHandler(this.Btn_IrParaProximaAula_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Voltar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_Voltar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar.ForeColor = System.Drawing.Color.Lime;
            this.btn_Voltar.Location = new System.Drawing.Point(3, 142);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(300, 110);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = false;
            this.btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // panelContent
            // 
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Controls.Add(this.panel_Video);
            this.panelContent.Controls.Add(this.panel2);
            this.panelContent.Controls.Add(this.panel1);
            this.panelContent.Location = new System.Drawing.Point(12, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1246, 676);
            this.panelContent.TabIndex = 1;
            // 
            // label_Retorno
            // 
            this.label_Retorno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.label_Retorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Retorno.ForeColor = System.Drawing.Color.Red;
            this.label_Retorno.Location = new System.Drawing.Point(59, 12);
            this.label_Retorno.Name = "label_Retorno";
            this.label_Retorno.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_Retorno.Size = new System.Drawing.Size(600, 115);
            this.label_Retorno.TabIndex = 33;
            this.label_Retorno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCursoDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(1270, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCursoDetalhes";
            this.Text = "Curso Detalhes";
            this.Load += new System.EventHandler(this.FormCursoDetalhes_Load);
            this.Resize += new System.EventHandler(this.FormCursoDetalhes_Resize);
            this.panel_Video.ResumeLayout(false);
            this.panel_Video.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAulas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Video;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.DataGridView dataGridViewAulas;
        private System.Windows.Forms.Button btn_AssistirAula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_Curso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_Nivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txt_AulaTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_AulaMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_AulaModulo;
        private System.Windows.Forms.Button btn_IrParaProximaAula;
        private System.Windows.Forms.Label label_Retorno;
    }
}