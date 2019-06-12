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
        private Empresa empresa = new Empresa();

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

            if (empresa.Select(empresa) == null)
                MessageBox.Show("Empresa ainda não cadastrada!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Empresa já cadastrada no Banco de Dados.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                using (var webClient = new WebClient())
                {
                    //get json string
                    string rawJson = webClient.DownloadString(urlBase + cnpj);
                    if (rawJson == null)
                        MessageBox.Show("Web Service da Receita Federal não está disponivel.", "Indisponivel", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //converter string JSON para objeto
                    empresa = JsonConvert.DeserializeObject<Empresa>(rawJson);

                    showInfo(rawJson, empresa);
                }
            }
            catch (WebException exception)
            {
                string responseText;
                var responseStream = exception.Response.GetResponseStream();

                if (responseStream != null)
                {
                    using (var reader = new StreamReader(responseStream))
                    {
                        responseText = reader.ReadToEnd();
                    }
                }
            }
        }

        private void showInfo(string rawJson, Empresa e)
        {
            nomeEmpresa.Text = e.Nome;
            nomeFantasia.Text = e.Fantasia;
            Municipio.Text = e.Municipio;
            UF.Text = e.UF;
            Telefone.Text = e.Telefone;
            Logradouro.Text = e.Logradouro;
            Numero.Text = e.Numero;
            Bairro.Text = e.Bairro;
        }

        private void ConsultaCNPJ_Load(object sender, EventArgs e)
        {
            textCNPJ.Text = "Digite aqui o CNPJ";
        }

        //salvar no banco de dados
        private void salvarDados(object sender, EventArgs e)
        {
            empresa.Nome = nomeEmpresa.Text;
            empresa.Fantasia = nomeFantasia.Text;
            empresa.Municipio = Municipio.Text;
            empresa.UF = UF.Text;
            empresa.Telefone = Telefone.Text;
            empresa.Logradouro = Logradouro.Text;
            empresa.Numero = Numero.Text;
            empresa.Bairro = Bairro.Text;

            bool succes = empresa.Insert(empresa);
            if (succes == true) //inserido com sucesso
                MessageBox.Show("Empresa cadastrada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else //falha ao inserir
                MessageBox.Show("Falha ao cadastrar a Empresa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void deletarDados(object sender, EventArgs e)
        {
            empresa.Nome = nomeEmpresa.Text;
            empresa.Fantasia = nomeFantasia.Text;
            empresa.Municipio = Municipio.Text;
            empresa.UF = UF.Text;
            empresa.Telefone = Telefone.Text;
            empresa.Logradouro = Logradouro.Text;
            empresa.Numero = Numero.Text;
            empresa.Bairro = Bairro.Text;

            bool succes = empresa.Delete(empresa);
            if(succes == true)
                MessageBox.Show("Empresa deletada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else //falha ao inserir
                MessageBox.Show("Falha ao deletar a Empresa!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
