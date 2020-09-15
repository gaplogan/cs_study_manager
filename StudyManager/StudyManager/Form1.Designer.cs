namespace StudyManager
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_ListarArquivos = new System.Windows.Forms.Button();
            this.btn_CorrigeNomes = new System.Windows.Forms.Button();
            this.btn_NomesFalhados = new System.Windows.Forms.Button();
            this.btn_Bimestres = new System.Windows.Forms.Button();
            this.btn_Aulas = new System.Windows.Forms.Button();
            this.btn_Cronograma = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_MontaCronograma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(918, 548);
            this.listBox1.TabIndex = 2;
            this.listBox1.DoubleClick += new System.EventHandler(this.ListBox1_DoubleClick);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(12, 566);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_Inserir.TabIndex = 3;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.Btn_Inserir_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.Location = new System.Drawing.Point(93, 566);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(75, 23);
            this.btn_Listar.TabIndex = 4;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = true;
            this.btn_Listar.Click += new System.EventHandler(this.Btn_Listar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(255, 566);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 6;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.Btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(174, 566);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // btn_ListarArquivos
            // 
            this.btn_ListarArquivos.Location = new System.Drawing.Point(336, 566);
            this.btn_ListarArquivos.Name = "btn_ListarArquivos";
            this.btn_ListarArquivos.Size = new System.Drawing.Size(100, 23);
            this.btn_ListarArquivos.TabIndex = 7;
            this.btn_ListarArquivos.Text = "Listar Arquivos";
            this.btn_ListarArquivos.UseVisualStyleBackColor = true;
            this.btn_ListarArquivos.Click += new System.EventHandler(this.Btn_ListarArquivos_Click);
            // 
            // btn_CorrigeNomes
            // 
            this.btn_CorrigeNomes.Location = new System.Drawing.Point(442, 566);
            this.btn_CorrigeNomes.Name = "btn_CorrigeNomes";
            this.btn_CorrigeNomes.Size = new System.Drawing.Size(92, 23);
            this.btn_CorrigeNomes.TabIndex = 8;
            this.btn_CorrigeNomes.Text = "Corrige Nomes";
            this.btn_CorrigeNomes.UseVisualStyleBackColor = true;
            this.btn_CorrigeNomes.Click += new System.EventHandler(this.Btn_CorrigeNomes_Click);
            // 
            // btn_NomesFalhados
            // 
            this.btn_NomesFalhados.Location = new System.Drawing.Point(540, 566);
            this.btn_NomesFalhados.Name = "btn_NomesFalhados";
            this.btn_NomesFalhados.Size = new System.Drawing.Size(126, 23);
            this.btn_NomesFalhados.TabIndex = 9;
            this.btn_NomesFalhados.Text = "Nomes Falhados";
            this.btn_NomesFalhados.UseVisualStyleBackColor = true;
            this.btn_NomesFalhados.Click += new System.EventHandler(this.Btn_NomesFalhados_Click);
            // 
            // btn_Bimestres
            // 
            this.btn_Bimestres.Location = new System.Drawing.Point(672, 566);
            this.btn_Bimestres.Name = "btn_Bimestres";
            this.btn_Bimestres.Size = new System.Drawing.Size(126, 23);
            this.btn_Bimestres.TabIndex = 10;
            this.btn_Bimestres.Text = "Bimestres";
            this.btn_Bimestres.UseVisualStyleBackColor = true;
            this.btn_Bimestres.Click += new System.EventHandler(this.Btn_Bimestres_Click);
            // 
            // btn_Aulas
            // 
            this.btn_Aulas.Location = new System.Drawing.Point(804, 566);
            this.btn_Aulas.Name = "btn_Aulas";
            this.btn_Aulas.Size = new System.Drawing.Size(126, 23);
            this.btn_Aulas.TabIndex = 11;
            this.btn_Aulas.Text = "Aulas";
            this.btn_Aulas.UseVisualStyleBackColor = true;
            this.btn_Aulas.Click += new System.EventHandler(this.Btn_Aulas_Click);
            // 
            // btn_Cronograma
            // 
            this.btn_Cronograma.Location = new System.Drawing.Point(936, 566);
            this.btn_Cronograma.Name = "btn_Cronograma";
            this.btn_Cronograma.Size = new System.Drawing.Size(126, 23);
            this.btn_Cronograma.TabIndex = 12;
            this.btn_Cronograma.Text = "Cronograma";
            this.btn_Cronograma.UseVisualStyleBackColor = true;
            this.btn_Cronograma.Click += new System.EventHandler(this.Btn_Cronograma_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(936, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(395, 548);
            this.listBox2.TabIndex = 13;
            // 
            // btn_MontaCronograma
            // 
            this.btn_MontaCronograma.Location = new System.Drawing.Point(1068, 566);
            this.btn_MontaCronograma.Name = "btn_MontaCronograma";
            this.btn_MontaCronograma.Size = new System.Drawing.Size(126, 23);
            this.btn_MontaCronograma.TabIndex = 14;
            this.btn_MontaCronograma.Text = "Monta Cronograma";
            this.btn_MontaCronograma.UseVisualStyleBackColor = true;
            this.btn_MontaCronograma.Click += new System.EventHandler(this.Btn_MontaCronograma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 607);
            this.Controls.Add(this.btn_MontaCronograma);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btn_Cronograma);
            this.Controls.Add(this.btn_Aulas);
            this.Controls.Add(this.btn_Bimestres);
            this.Controls.Add(this.btn_NomesFalhados);
            this.Controls.Add(this.btn_CorrigeNomes);
            this.Controls.Add(this.btn_ListarArquivos);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_ListarArquivos;
        private System.Windows.Forms.Button btn_CorrigeNomes;
        private System.Windows.Forms.Button btn_NomesFalhados;
        private System.Windows.Forms.Button btn_Bimestres;
        private System.Windows.Forms.Button btn_Aulas;
        private System.Windows.Forms.Button btn_Cronograma;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_MontaCronograma;
    }
}

