using System;

namespace dbconnection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {            
            System.Console.WriteLine("Oracle connection created");
        }

        public override void OpenConnection()
        {
            try
            {                
                System.Console.WriteLine("Oracle connection opened");
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
                System.Console.WriteLine("Oracle connection closed");
            }
            catch (System.Exception ex)
            {                
                System.Console.WriteLine(ex.ToString());
            }            
        }
    }
}