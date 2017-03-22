using System;
using System.Data;
using System.Data.SqlClient;

namespace BlueJackCake.Helpers
{
    public class DatabaseHelper
    {
        SqlConnection DbConnection;
        String ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UserDatabase.mdf;Integrated Security = True";

        public DatabaseHelper()
        {
            DbConnection = new SqlConnection(ConnectionString);
        }

        public DataTable ExecuteQuery(String Query)
        {
            if(DbConnection.State == ConnectionState.Open)
            {
                DbConnection.Close();
            }
            DbConnection.Open();
            SqlCommand command = new SqlCommand(Query, DbConnection);
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            DbConnection.Close();

            return dt;
        }

        public int ExecuteUpdate(String Query)
        {
            if(DbConnection.State == ConnectionState.Open)
            {
                DbConnection.Close();
            }
            DbConnection.Open();
            SqlCommand Command = new SqlCommand(Query, DbConnection);
            int Count = Command.ExecuteNonQuery();
            DbConnection.Close();
            return Count;
        }

    }

}