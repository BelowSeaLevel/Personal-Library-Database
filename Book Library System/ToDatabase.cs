using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library_System
{
    class ToDatabase
    {
        // Connection strings for the correct connections.
        // Connection paths can be found in the "App.config" file.
        readonly string connectionLibrary = ConfigurationManager.ConnectionStrings["Connection_Library_Database"].ConnectionString;
        readonly string connectionWhishList = ConfigurationManager.ConnectionStrings["Connection_WhishList_Database"].ConnectionString;

        // Fields to hold the value's that go into that database.
        private string title;
        private string author;
        private string isbn;
        private string genre;
        private string langauge;
        private string date;
        private byte[] image;

        /// <summary>
        /// Recieves the needed information for the database
        /// </summary>
        internal void RecieveDatabaseInformation(string title, string author, string isbn, string genre, string langauge, string date, byte[] image, string tableName, string whichConnectionString)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.genre = genre;
            this.langauge = langauge;
            this.date = date;
            this.image = image;

            SendToDatabase(tableName, whichConnectionString);
        }


        /// <summary>
        /// Takes all needed information and sends it to the database.
        /// </summary>
        private void SendToDatabase(string databaseTableName, string connectionString)
        {
            string query = $"INSERT INTO {databaseTableName} VALUES(@Title, @Author, @ISBN, @Genre, @Langauge, @Date, @Image)";


            // Checks the string, and decides wich ConnectionString should be used.
            if(connectionString == "connectionLibrary")
            {
                connectionString = connectionLibrary;
            }
            else
            {
                connectionString = connectionWhishList;
            }


            // Adds everything to the database.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@Author", author);
                command.Parameters.AddWithValue("@ISBN", isbn);
                command.Parameters.AddWithValue("@Genre", genre);
                command.Parameters.AddWithValue("@Langauge", langauge);
                command.Parameters.AddWithValue("@Date", date);
                
                if(image != null)
                {
                    command.Parameters.AddWithValue("@Image", image);
                }
                else
                {
                    command.Parameters.AddWithValue("@Image", new byte[0]);
                }

                connection.Open();

                command.ExecuteNonQuery();

                command.Dispose();

            }
        }
    }
}
