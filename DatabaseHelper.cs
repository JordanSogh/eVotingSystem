using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        private DataTable ExecuteRead(string query)
        {

            using (var conn = CreateConnection())
            {
                using (var command = new SQLiteCommand(query, conn))
                {

                    var dataAdapter = new SQLiteDataAdapter(command);

                    var datatable = new DataTable();
                    dataAdapter.Fill(datatable);

                    dataAdapter.Dispose();
                    return datatable;
                }
            }
        }
        public string ValidateLogin(string usernameC, string passwordC)
        {
            string userRole = null;
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand;

            using (sqliteCommand = new SQLiteCommand("SELECT role FROM User WHERE userName = @username AND password =@password", connection))
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

        public void CreateCampaign(string nameC, int lengthC)
        {


            SQLiteConnection connection = CreateConnection();



            using (SQLiteCommand sqliteCommand = connection.CreateCommand())
            {
                string createString = "UPDATE Campaign SET IsCurrent = 0 WHERE IsCurrent = 1; INSERT INTO Campaign ( CampaignName, CampaignLength, IsCurrent ) VALUES ( @Name, @Length, @iSCurrent );";

                sqliteCommand.Parameters.AddWithValue("@Name", nameC);
                sqliteCommand.Parameters.AddWithValue("@Length", lengthC);
                sqliteCommand.Parameters.AddWithValue("@isCurrent", 1);
                sqliteCommand.CommandText = createString;
                sqliteCommand.ExecuteNonQuery();

            }

            connection.Close();

        }

        public void DeleteCampaign(string nameC)
        {

            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand;

            using (sqliteCommand = connection.CreateCommand())
            {
                string deleteString = "DELETE FROM Campaign WHERE CampaignName = @Name;";

                sqliteCommand.Parameters.AddWithValue("@Name", nameC);
                sqliteCommand.CommandText = deleteString;
                sqliteCommand.ExecuteNonQuery();

            }

            connection.Close();

        }


        public Campaign GetCurrentCampaign()
        {
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT CampaignName,CampaignLength,IsCurrent,CampaignType FROM Campaign WHERE isCurrent = 1 ", connection);

            DataTable dt = ExecuteRead(sqliteCommand.CommandText);

            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }

            string name = Convert.ToString(dt.Rows[0]["CampaignName"]);
            int length = Convert.ToInt32(dt.Rows[0]["CampaignLength"]);
            bool isCurrent = Convert.ToBoolean(dt.Rows[0]["IsCurrent"]);
            Campaign returnCampaign = new Campaign(name, length, isCurrent);


            connection.Close();

            return returnCampaign;
        }
        public List<string> GetCurrentCampaignVoteOptions(string campaignNameC)
        {
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT VoteDescription FROM CampaignVotes WHERE Campaign = @Campaign", connection);
            sqliteCommand.Parameters.AddWithValue("@Campaign", campaignNameC);

            List<string> listReturned = new List<string>();

            using (var reader = sqliteCommand.ExecuteReader())
            {

                while (reader.Read())
                {
                    listReturned.Add(reader.GetString(0));
                }
            }

            connection.Close();

            return listReturned;
        }

        public bool CreateVote(int voteIDC, string CurrentCampaignC, string usernameC, string passwordC)
        {
            bool voteSuccess = false;
            SQLiteConnection connection = CreateConnection();


            SQLiteCommand sqliteCommand;

            using (sqliteCommand = new SQLiteCommand("SELECT Voted FROM User WHERE userName = @username AND password =@password", connection))
            {
               
                sqliteCommand.Parameters.AddWithValue("@username", usernameC);
                sqliteCommand.Parameters.AddWithValue("@password", passwordC);
                var returnValue = (bool)sqliteCommand.ExecuteScalar();
                if (returnValue != true)
                {

                    using (SQLiteCommand sqliteCommand2 = connection.CreateCommand())
                    {
                        string createString = "INSERT INTO Vote(Campaign, Ballot) VALUES(@Campaign,@Ballot); UPDATE User SET Voted = 1 WHERE userName = @username AND password =@password;";
                        
                        sqliteCommand2.Parameters.AddWithValue("@Campaign", CurrentCampaignC);
                        sqliteCommand2.Parameters.AddWithValue("@Ballot", voteIDC);
                        sqliteCommand2.Parameters.AddWithValue("@username", usernameC);
                        sqliteCommand2.Parameters.AddWithValue("@password", passwordC);
                        sqliteCommand2.CommandText = createString;
                        int success = sqliteCommand2.ExecuteNonQuery();
                        voteSuccess = true;
                    }

                    connection.Close();
                    
                }
            }
            return voteSuccess;
        }
        public void DeleteUser(string userNameC)
        {

            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand;

            using (sqliteCommand = connection.CreateCommand())
            {
                string deleteString = "DELETE FROM User WHERE userName = @userName;";

                sqliteCommand.Parameters.AddWithValue("@userName", userNameC);
                sqliteCommand.CommandText = deleteString;
                sqliteCommand.ExecuteNonQuery();

            }

            connection.Close();

        }
        public void AddUser(string userNameC)
        {

            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand;

            using (sqliteCommand = connection.CreateCommand())
            {
                string deleteString = "DELETE FROM User WHERE userName = @userName;";

                sqliteCommand.Parameters.AddWithValue("@userName", userNameC);
                sqliteCommand.CommandText = deleteString;
                sqliteCommand.ExecuteNonQuery();

            }

            connection.Close();

        }
    }
}