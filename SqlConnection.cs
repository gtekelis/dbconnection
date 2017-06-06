using System;

namespace dbconnection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            System.Console.WriteLine("Sql connection created");            
        }

        public override void OpenConnection()
        {
            try
            {
                System.Console.WriteLine("Sql connection opened");
            }
            catch (System.Exception ex)
            {
                
                System.Console.WriteLine(ex.ToString());
            }            
        }

        public override void CloseConnection()
        {
            try
            {
                System.Console.WriteLine("Sql connection closed");
            }
            catch (System.Exception ex)
            {
                
                System.Console.WriteLine(ex.ToString());
            }            
        }
    }
}