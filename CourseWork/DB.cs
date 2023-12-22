// remove unused usings
using System.Data.SqlClient;

namespace CourseWork
{
    internal static class DB
    {
        // connection string should live in config files or in environment variables
        private const string ConnnectionString = @"Data Source=DESKTOP-G32MNSN\MYMSSQLSERVER;Initial Catalog=CourseWorkDB;Integrated Security=True";
        
        public static SqlConnection GetOpenedConnection()
        {
            var connection = new SqlConnection(ConnnectionString);
            connection.Open();
            return connection;
        }
    }
}