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
        public void initDatabase()
        {
            Database.execute("CREATE TABLE users (name VARCHAR(255), email VARCHAR(255), password VARCHAR(255))");
            Database.execute("INSERT INTO users VALUES ('moh', 'moh@gmail.com', '123')");

            Database.execute("CREATE TABLE majors (id INTEGER PRIMARY KEY, name VARCHAR(255))");
            Database.execute("INSERT INTO majors VALUES (1, 'SE')");
            Database.execute("INSERT INTO majors VALUES (2, 'IT')");
            Database.execute("INSERT INTO majors VALUES (3, 'CND')");

            Database.execute("CREATE TABLE students(id integer primary key, name varchar(255), major varchar(255), level integer, phone varchar(255), status varchar(50) );");
            Database.execute("INSERT INTO students values (1, 'Asem', 'SE', 3, '1234', 'Active')");
            Database.execute("INSERT INTO students values (2, 'Ali', 'SE', 3, '5433', 'Active')");
            Database.execute("INSERT INTO students values (3, 'Khalid', 'IT', 4, '574839', 'InActive')");
            Database.execute("INSERT INTO students values (4, 'Said', 'SE', 3, '8393', 'Active')");

            Database.execute("CREATE TABLE teachers (id INTEGER PRIMARY KEY, name VARCHAR(255), phone VARCHAR(255), subject VARCHAR(255), degree VARCHAR(255), salary VARCHAR(255));");
            Database.execute("INSERT INTO teachers VALUES (1, 'Ali Qaid', '123498765', 'Quran', 'Master', '$12000')");
            Database.execute("INSERT INTO teachers VALUES (2, 'Khalid Najee', '717777878', 'Math', 'Teacher', '$90000')");
            Database.execute("INSERT INTO teachers VALUES (3, 'Abdulsalam', '777878165', 'Windows Forms', 'Prof', '$1000000009')");
            Database.execute("INSERT INTO teachers VALUES (4, 'Said Muhammed', '778887787', 'Web Applicatinos', 'Teacher', '$12000')");

            Database.execute("CREATE TABLE cources (name VARCHAR(255), department VARCHAR(255), level VARCHAR(2), teacher VARCHAR(255), hour VARCHAR(255));");
            Database.execute("INSERT INTO cources VALUES ('Java', 'SE', '3', 'Faozi', '2')");
            Database.execute("INSERT INTO cources VALUES ('Math', 'SE', '3', 'Derhem', '2')");
            Database.execute("INSERT INTO cources VALUES ('PHP', 'SE', '3', 'Hasan', '2')");
        }

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
