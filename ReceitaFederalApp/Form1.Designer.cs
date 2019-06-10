namespace ReceitaFederalApp
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
            this.textCNPJ = new System.Windows.Forms.TextBox();
            this.consultarCNPJ = new System.Windows.Forms.Button();
            this.resultadoConsulta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textCNPJ
            // 
            this.textCNPJ.Location = new System.Drawing.Point(13, 13);
            this.textCNPJ.Name = "textCNPJ";
            this.textCNPJ.Size = new System.Drawing.Size(151, 20);
            this.textCNPJ.TabIndex = 0;
            this.textCNPJ.Text = "Digite aqui o CNPJ";
            this.textCNPJ.TextChanged += new System.EventHandler(this.getCNPJ);
            // 
            // consultarCNPJ
            // 
            this.consultarCNPJ.Location = new System.Drawing.Point(171, 9);
            this.consultarCNPJ.Name = "consultarCNPJ";
            this.consultarCNPJ.Size = new System.Drawing.Size(90, 23);
            this.consultarCNPJ.TabIndex = 1;
            this.consultarCNPJ.Text = "CONSULTAR";
            this.consultarCNPJ.UseVisualStyleBackColor = true;
            this.consultarCNPJ.Click += new System.EventHandler(this.consultar);
            // 
            // resultadoConsulta
            // 
            this.resultadoConsulta.Location = new System.Drawing.Point(13, 49);
            this.resultadoConsulta.Multiline = true;
            this.resultadoConsulta.Name = "resultadoConsulta";
            this.resultadoConsulta.Size = new System.Drawing.Size(775, 389);
            this.resultadoConsulta.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultadoConsulta);
            this.Controls.Add(this.consultarCNPJ);
            this.Controls.Add(this.textCNPJ);
            this.Name = "Form1";
            this.Text = "Consulta Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCNPJ;
        private System.Windows.Forms.Button consultarCNPJ;
        private System.Windows.Forms.TextBox resultadoConsulta;
    }
}

