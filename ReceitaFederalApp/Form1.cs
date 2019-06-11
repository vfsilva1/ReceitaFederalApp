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
            
            var webClient = new WebClient();
            string result = webClient.DownloadString(urlBase + cnpj);
            resultadoConsulta.Text = result;

            if (result == null)
                MessageBox.Show("Web Service da Receita Federal não está disponivel.", "Indisponivel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ConsultaCNPJ_Load(object sender, EventArgs e)
        {
            //DialogResult resultCNPJ = MessageBox.Show("ALO", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textCNPJ.Text = "Digite aqui o CNPJ";
        }

        private void createDataBase(object sender, EventArgs e)
        {
            String str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");

            str = "CREATE DATABASE MyDatabase ON PRIMARY " +
                "(NAME = MyDatabase_Data, " +
                "FILENAME = 'C:\\MyDatabaseData.mdf', " +
                "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = MyDatabase_Log, " +
                "FILENAME = 'C:\\MyDatabaseLog.ldf', " +
                "SIZE = 1MB, " +
                "MAXSIZE = 5MB, " +
                "FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}
