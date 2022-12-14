namespace aula14Dezembro
{
    partial class Form1
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
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.inputSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.BackColor = System.Drawing.Color.Black;
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botaoLimpar.Location = new System.Drawing.Point(484, 139);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(167, 40);
            this.botaoLimpar.TabIndex = 0;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = false;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Location = new System.Drawing.Point(69, 192);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(35, 13);
            this.labelMensagem.TabIndex = 1;
            this.labelMensagem.Text = "label1";
            this.labelMensagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputSenha
            // 
            this.inputSenha.Location = new System.Drawing.Point(72, 150);
            this.inputSenha.Name = "inputSenha";
            this.inputSenha.Size = new System.Drawing.Size(391, 20);
            this.inputSenha.TabIndex = 2;
            this.inputSenha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.inputSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.verificarCaracter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 392);
            this.Controls.Add(this.inputSenha);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.botaoLimpar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.TextBox inputSenha;
    }
}

