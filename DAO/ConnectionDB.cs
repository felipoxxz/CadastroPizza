using System.Data.SqlClient;

namespace CadastroPizza.DAO
{
    public class ConnectionDB
    {
        public static SqlConnection GetConnection()
        {
            //string strCon = "Data Source=LOCALHOST; Database=Cadastro; user id=sa; password=123456";
            string strCon = "Data Source=DESKTOP-FTRI8H1\\MSSQLSERVER02; Database=Cadastro; user id=sa; password=123456";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }

    }
}
