using System;

namespace dbconnection
{
    public abstract class DbConnection
    {
        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new InvalidCastException();
            }
            else
            {
                this.ConnectionString = connectionString;
            }
        }

        private string ConnectionString { get; set; }
        protected TimeSpan Timeout { get; set; }

        public abstract void OpenConnection();
        public abstract void CloseConnection();        
    }
}
