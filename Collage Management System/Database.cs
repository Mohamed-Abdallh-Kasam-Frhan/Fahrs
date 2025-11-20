using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace Collage_Management_System
{
    internal class Database
    {
        private static string connectionString = "Data Source=mydb.sqlite";
        private static SQLiteConnection connection;

        public static SQLiteConnection getConnection()
        {
            if (connection == null)
            {
                connection = new SQLiteConnection(connectionString);
                connection.Open();
            }
            return connection;
        }

        public static DataTable query(string query)
        {
            var adapter = new SQLiteDataAdapter(query, getConnection());
            var dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static void execute(string query)
        {
            var cmd = new SQLiteCommand(query, getConnection());
            cmd.ExecuteNonQuery();
        }
    }
}
