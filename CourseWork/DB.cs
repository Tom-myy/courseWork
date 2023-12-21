using System.Data.SqlClient;

namespace CourseWork
{
    internal static class DB
    {
        private const string ConnnectionString = @"Data Source=DESKTOP-G32MNSN\MYMSSQLSERVER;Initial Catalog=CourseWorkDB;Integrated Security=True";
        
        public static SqlConnection GetOpenedConnection()
        {
            var connection = new SqlConnection(ConnnectionString);
            connection.Open();
            return connection;
        }
    }
}