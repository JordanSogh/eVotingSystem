using System.Data.SQLite;

namespace eVotingSystem
{
    internal class DatabaseHelper
    {
        private string ConnectionString = @"Data source = C:\Users\Jordan Soghomonian\source\repos\eVotingSystem\VotingDB.db; Version = 3; New = true; Compress = True;";

        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqliteConn = new SQLiteConnection(ConnectionString);
            
                try
                {
                    sqliteConn.Open();
                }
                catch
                {

                }
                return sqliteConn;
        }

        public string ValidateLogin(string usernameC, string passwordC)
        {
            string userRole = null;
            SQLiteConnection connection = CreateConnection();
            
            SQLiteCommand sqliteCommand;
            
            using ( sqliteCommand = new SQLiteCommand("SELECT role FROM User WHERE userName = @username AND password =@password", connection))
            {
                sqliteCommand.Parameters.AddWithValue("@username", usernameC);
                sqliteCommand.Parameters.AddWithValue("@password", passwordC);
                var returnValue = sqliteCommand.ExecuteScalar();
                if (returnValue != null)
                {
                    userRole = returnValue.ToString();
                }
            }

            connection.Close();

            return userRole;
        }
    }
}