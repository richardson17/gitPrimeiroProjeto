using System;

namespace projeto
{
    partial class CadastroPessoa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.Label();
            this.txtProfissão = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdicionarPessoa = new System.Windows.Forms.Button();
            this.lstPessoas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Location = new System.Drawing.Point(10, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(39, 13);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "NOME";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(366, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 3;
            // 
            // txtIdade
            // 
            this.txtIdade.AutoSize = true;
            this.txtIdade.Location = new System.Drawing.Point(363, 5);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(40, 13);
            this.txtIdade.TabIndex = 2;
            this.txtIdade.Text = "IDADE";
            // 
            // txtProfissão
            // 
            this.txtProfissão.AutoSize = true;
            this.txtProfissão.Location = new System.Drawing.Point(10, 44);
            this.txtProfissão.Name = "txtProfissão";
            this.txtProfissão.Size = new System.Drawing.Size(68, 13);
            this.txtProfissão.TabIndex = 4;
            this.txtProfissão.Text = "PROFISSÃO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bruno Faz Programa",
            "Richard Lindo",
            "Erick Gay"});
            this.comboBox1.Location = new System.Drawing.Point(12, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnAdicionarPessoa
            // 
            this.btnAdicionarPessoa.Location = new System.Drawing.Point(366, 60);
            this.btnAdicionarPessoa.Name = "btnAdicionarPessoa";
            this.btnAdicionarPessoa.Size = new System.Drawing.Size(86, 23);
            this.btnAdicionarPessoa.TabIndex = 6;
            this.btnAdicionarPessoa.Text = "Adicionar";
            this.btnAdicionarPessoa.UseVisualStyleBackColor = true;
            this.btnAdicionarPessoa.Click += new System.EventHandler(this.btnAdicionarPessoa_Click);
            // 
            // lstPessoas
            // 
            this.lstPessoas.FormattingEnabled = true;
            this.lstPessoas.Location = new System.Drawing.Point(12, 88);
            this.lstPessoas.Name = "lstPessoas";
            this.lstPessoas.Size = new System.Drawing.Size(440, 225);
            this.lstPessoas.TabIndex = 7;
            // 
            // CadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 339);
            this.Controls.Add(this.lstPessoas);
            this.Controls.Add(this.btnAdicionarPessoa);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtProfissão);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNome);
            this.Name = "CadastroPessoa";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtIdade;
        private System.Windows.Forms.Label txtProfissão;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdicionarPessoa;
        private System.Windows.Forms.ListBox lstPessoas;
        private EventHandler label1_Click;
    }
}

