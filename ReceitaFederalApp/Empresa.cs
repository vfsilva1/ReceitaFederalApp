using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaFederalApp
{
    class Empresa
    {
        public int EmpresaID { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }

        static string myConnString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Select (READ)
        public DataTable Select()
        {
            //conexao com o banco
            SqlConnection conn = new SqlConnection(myConnString);
            DataTable dt = new DataTable();
            try
            {
                //escrevendo Query SQL
                string sql = "SELECT * FROM tbl_empresa";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //Insert (CREATE)
        public bool Insert (Empresa empresa)
        {
            bool isSuccess = false;

            //conexao
            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                //query SQL
                string sql = "INSERT INTO tbl_empresa (nome, fantasia, municipio, uf, logradouro, numero, bairro, telefone) VALUES (@nome, @fantasia, @municipio, @uf, @logradouro, @numero, @bairro, @telefone)";
                //comando SQL
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", empresa.Nome);
                cmd.Parameters.AddWithValue("@fantasia", empresa.Fantasia);
                cmd.Parameters.AddWithValue("@municipio", empresa.Municipio);
                cmd.Parameters.AddWithValue("@uf", empresa.UF);
                cmd.Parameters.AddWithValue("@logradouro", empresa.Logradouro);
                cmd.Parameters.AddWithValue("@numero", empresa.Numero);
                cmd.Parameters.AddWithValue("@bairro", empresa.Bairro);
                cmd.Parameters.AddWithValue("@telefone", empresa.Telefone);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //se a query der certo o valor de rows sera maior que zero, senao seu valor sera zero
                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //DELETE
        public bool Delete (Empresa e)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myConnString);
            try
            {
                //query
                string sql = "DELETE FROM tbl_empresa WHERE empresaID=@empresaID";
                //comando SQL
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@empresaID", e.EmpresaID);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    isSucces = true;
                else
                    isSucces = false;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSucces;
        }
    }
}
