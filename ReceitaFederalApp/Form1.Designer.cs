namespace ReceitaFederalApp
{
    partial class ConsultaCNPJ
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
            this.nomeEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeFantasia = new System.Windows.Forms.TextBox();
            this.Municipio = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.UF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // nomeEmpresa
            // 
            this.nomeEmpresa.Location = new System.Drawing.Point(13, 71);
            this.nomeEmpresa.Name = "nomeEmpresa";
            this.nomeEmpresa.ReadOnly = true;
            this.nomeEmpresa.Size = new System.Drawing.Size(248, 20);
            this.nomeEmpresa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome da Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome da Fantasia";
            // 
            // nomeFantasia
            // 
            this.nomeFantasia.Location = new System.Drawing.Point(280, 71);
            this.nomeFantasia.Name = "nomeFantasia";
            this.nomeFantasia.ReadOnly = true;
            this.nomeFantasia.Size = new System.Drawing.Size(248, 20);
            this.nomeFantasia.TabIndex = 6;
            // 
            // Municipio
            // 
            this.Municipio.Location = new System.Drawing.Point(13, 121);
            this.Municipio.Name = "Municipio";
            this.Municipio.ReadOnly = true;
            this.Municipio.Size = new System.Drawing.Size(248, 20);
            this.Municipio.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(10, 105);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Municipio";
            // 
            // UF
            // 
            this.UF.Location = new System.Drawing.Point(280, 121);
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            this.UF.Size = new System.Drawing.Size(248, 20);
            this.UF.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "UF";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(15, 170);
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Size = new System.Drawing.Size(248, 20);
            this.Telefone.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "SALVAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConsultaCNPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Municipio);
            this.Controls.Add(this.label);
            this.Controls.Add(this.nomeFantasia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeEmpresa);
            this.Controls.Add(this.consultarCNPJ);
            this.Controls.Add(this.textCNPJ);
            this.Name = "ConsultaCNPJ";
            this.Text = "Consulta Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCNPJ;
        private System.Windows.Forms.Button consultarCNPJ;
        private System.Windows.Forms.TextBox nomeEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeFantasia;
        private System.Windows.Forms.TextBox Municipio;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox UF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

