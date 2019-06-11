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
            this.Logradouro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.nomeFantasia.Size = new System.Drawing.Size(248, 20);
            this.nomeFantasia.TabIndex = 6;
            // 
            // Municipio
            // 
            this.Municipio.Location = new System.Drawing.Point(13, 121);
            this.Municipio.Name = "Municipio";
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
            this.Telefone.Location = new System.Drawing.Point(15, 218);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(248, 20);
            this.Telefone.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
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
            this.button1.Click += new System.EventHandler(this.salvarDados);
            // 
            // Logradouro
            // 
            this.Logradouro.Location = new System.Drawing.Point(15, 168);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(248, 20);
            this.Logradouro.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Logradouro";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(280, 168);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(248, 20);
            this.Numero.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Numero";
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(540, 168);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(248, 20);
            this.Bairro.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Bairro";
            // 
            // ConsultaCNPJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Logradouro);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.TextBox Logradouro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.Label label7;
    }
}

