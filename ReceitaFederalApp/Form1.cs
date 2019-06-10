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

namespace ReceitaFederalApp
{
    public partial class Form1 : Form
    {
        private string urlBase = "https://www.receitaws.com.br/v1/cnpj/";
        private string cnpj;

        public Form1()
        {
            InitializeComponent();
        }

        private void consultar(object sender, EventArgs e)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlBase + cnpj);
                request.Method = "GET";
                WebResponse response = request.GetResponse();

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string result = reader.ReadToEnd();
                    resultadoConsulta.Text = result;
                }
            }
            catch
            {
                Console.WriteLine("ERRO");
            }
        }

        private void getCNPJ(object sender, EventArgs e)
        {
            cnpj = textCNPJ.Text;
        }
    }
}
