using System.Configuration;
using System.Collections.Specialized;
using Microsoft.Data.Sqlite;

namespace CodingTracker.ItsSt0rm
{
    internal class Program
    {
        static string connectionString = ConfigurationManager.AppSettings.Get("connectionString");

        static void Main(string[] args)
        {
            DatabaseManager dbManager = new DatabaseManager(connectionString);
            dbManager.InitializeDatabase();
        }
    }
}