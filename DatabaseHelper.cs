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

        // Transcation scope

        public string ValidateLogin(string usernameC, string passwordC)
        {
            string userRole = null;
            SQLiteConnection connection = CreateConnection();
            
            SQLiteCommand sqliteCommand;
            
            using ( sqliteCommand = new SQLiteCommand("SELECT role FROM User WHERE userName = @username AND password =@password", connection))
            {
                //FIX so it just sees if there is a record and not get role
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
        
        public void CreateCampaign(string nameC, int lengthC, bool isCurrentC)
        {


            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand;

            using (sqliteCommand = connection.CreateCommand())
            {
                string createString = "UPDATE Campaign SET IsCurrent = 0 WHERE IsCurrent = 1; INSERT INTO Campaign ( CampaignName, CampaignLength, IsCurrent ) VALUES ( @Name, @Length, @iSCurrent );";

                sqliteCommand.Parameters.AddWithValue("@false", 0);
                sqliteCommand.Parameters.AddWithValue("@true", 1);

                sqliteCommand.Parameters.AddWithValue("@Name", nameC);
                sqliteCommand.Parameters.AddWithValue("@Length", lengthC);
                sqliteCommand.Parameters.AddWithValue("@isCurrent", isCurrentC);
                sqliteCommand.CommandText = createString;
                sqliteCommand.ExecuteNonQuery();

            }

            connection.Close();

        }

      
    }


}