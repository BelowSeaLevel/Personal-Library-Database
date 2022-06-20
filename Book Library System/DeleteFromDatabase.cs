using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Book_Library_System
{
    class DeleteFromDatabase
    {
        // Connection strings for the correct connections.
        // Connection paths can be found in the "App.config" file.
        readonly string connectionLibrary = ConfigurationManager.ConnectionStrings["Connection_Library_Database"].ConnectionString;
        readonly string connectionWhishList = ConfigurationManager.ConnectionStrings["Connection_WhishList_Database"].ConnectionString;

        // Field to hold the title so we can delete the right book.
        private string title;

        /// <summary>
        /// Recieves the needed information for the database
        /// </summary>
        internal void RecieveDatabaseInformation(string title, string tableName, string whichConnectionString)
        {
            this.title = title;

            SendToDatabase(tableName, whichConnectionString);
        }


        /// <summary>
        /// Takes all needed information so we can delete the records from the database.
        /// </summary>
        private void SendToDatabase(string databaseTableName, string connectionString)
        {
            // Puts ' on the string to make it a string literal
            title = "'" + title + "'";
            string query = $"DELETE FROM {databaseTableName} WHERE Title = {title}";


            // Checks the string, and decides wich ConnectionString should be used.
            if (connectionString == "connectionLibrary")
            {
                connectionString = connectionLibrary;
            }
            else
            {
                connectionString = connectionWhishList;
            }


            // Delete's the book from the database.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                command.ExecuteNonQuery();

                command.Dispose();

            }
        }
    }
}
