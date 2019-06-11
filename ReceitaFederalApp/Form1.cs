using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace ReceitaFederalApp
{
    public partial class ConsultaCNPJ : Form
    {
        private string urlBase = "https://www.receitaws.com.br/v1/cnpj/";
        private string cnpj;

        public ConsultaCNPJ()
        {
            InitializeComponent();
        }

        private void getCNPJ(object sender, EventArgs e)
        {
            cnpj = textCNPJ.Text;
        }

        private void consultar(object sender, EventArgs e)
        {
            if (cnpj.Length != 14)
                MessageBox.Show("CNPJ Inválido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            using (var webClient = new WebClient())
            {
                //get json string
                string rawJson = webClient.DownloadString(urlBase + cnpj);
                if (rawJson == null)
                    MessageBox.Show("Web Service da Receita Federal não está disponivel.", "Indisponivel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showInfo(rawJson);
            }
        }

        private void showInfo(string rawJson)
        {
            //converter string JSON para objeto
            Empresa empresa = JsonConvert.DeserializeObject<Empresa>(rawJson);
            nomeEmpresa.Text = empresa.Nome;
            nomeFantasia.Text = empresa.Fantasia;
            Municipio.Text = empresa.Municipio;
            UF.Text = empresa.UF;
            Telefone.Text = empresa.Telefone;
        }

        private void ConsultaCNPJ_Load(object sender, EventArgs e)
        {
            textCNPJ.Text = "Digite aqui o CNPJ";
        }

    }
}
