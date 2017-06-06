using System;

namespace dbconnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DbConnection");

            //connect to sql server
            var sqlConnection = new SqlConnection("sqlconnectionstring");            
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            //connect to oracle server
            var oracleConnection = new OracleConnection("oracleconnectionstring");
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();
        }
    }
}
