using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace SistemaVendas.Uteis
{
    //Data Access Layer
    public class DAL
    {
        private static string connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Sistema_venda;Data Source=DESKTOP-GG273I3";

        private static SqlConnection Connection;

        public DAL()
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        //Espera um parâmetro do tipo string 
        //contendo um comando SQL do tipo SELECT
        public DataTable RetDataTable(string sql)
        {
            DataTable data = new DataTable();
            SqlCommand Command = new SqlCommand(sql, Connection);
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(data);
            return data;
        }

        public DataTable RetDataTable(SqlCommand Command)
        {
            DataTable data = new DataTable();
            Command.Connection = Connection;
            SqlDataAdapter da = new SqlDataAdapter(Command);
            da.Fill(data);
            return data;
        }

        //Espera um parâmetro do tipo string 
        //contendo um comando SQL do tipo INSERT, UPDATE, DELETE
        public void ExecutarComandoSQL(string sql)
        {
           SqlCommand Command = new SqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }
    }
}
