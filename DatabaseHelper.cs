using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace eVotingSystem
{
    public class DatabaseHelper
    {
        // Gets the Connection String from the relative directory by using GetCurrentDirectory. Database must always been where the exe. is
        private string ConnectionString = @"Data source = " + Directory.GetCurrentDirectory().ToString() + "\\VotingDB.db;" + " version = 3; New = true; Compress = True;";
        private SQLiteConnection CreateConnection()
        {
            //Creates Connection to Sqlite Databas. Returns Connection
            SQLiteConnection sqliteConn = new SQLiteConnection(ConnectionString);
            try
            {
                sqliteConn.Open();
            }
            catch(SQLiteException ex)
            {
                throw ex;
            }
            return sqliteConn;
        }

        private DataTable ExecuteRead(string query)
        {
            //Used internally in Database Class for retreiving datatables.
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
        public string ValidateLogin(string username, string password)
        {
            //Validates user details and return the UserRole if found.
            string userRole = null;
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand;

            using (sqliteCommand = new SQLiteCommand("SELECT role FROM User WHERE userName = @username AND password =@password", connection))
            {
                //FIX so it just sees if there is a record and not get role
                sqliteCommand.Parameters.AddWithValue("@username", username);
                sqliteCommand.Parameters.AddWithValue("@password", password);
                var returnValue = sqliteCommand.ExecuteScalar();
                if (returnValue != null)
                {
                    userRole = returnValue.ToString();
                }
            }

            connection.Close();

            return userRole;
        }

        public bool CreateCampaign(string name, int length)
        {
            //Creates Campaign with inputted details
            bool success = false;
            SQLiteConnection connection = CreateConnection();
            using (SQLiteCommand sqliteCommand = connection.CreateCommand())
            {
                string createString = "UPDATE Campaign SET IsCurrent = 0 WHERE IsCurrent = 1 AND CampaignName != @Name; INSERT INTO Campaign ( CampaignName, CampaignLength, IsCurrent ) VALUES ( @Name, @Length, @iSCurrent );";

                sqliteCommand.Parameters.AddWithValue("@Name", name);
                sqliteCommand.Parameters.AddWithValue("@Length", length);
                sqliteCommand.Parameters.AddWithValue("@isCurrent", 1);
                sqliteCommand.CommandText = createString;
                try
                {
                    if (sqliteCommand.ExecuteNonQuery() > 0)
                    {
                        success = true;
                    }
                }
                catch (SQLiteException)
                {

                }
            }
            connection.Close();
            return success;
        }
        public bool CreateCampaignOptions(List<string> optionsList, string campaign)
        {
            //Creates Campaign Options with inputted details
            bool success = false;
            string insertString = "INSERT INTO CampaignVotes(Campaign,VoteDescription,VoteNumber) VALUES(@Campaign,@VoteDescription,@VoteNumber);";

            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand = new SQLiteCommand(insertString, connection);

            string optionsDesc;
            string campaignSelected;

            for (int i = 0; i < optionsList.Count; i++)
            {
                optionsDesc = optionsList[i];
                campaignSelected = campaign;


                sqliteCommand.Parameters.AddWithValue("@Campaign", campaign);
                sqliteCommand.Parameters.AddWithValue("@VoteDescription", optionsDesc);
                sqliteCommand.Parameters.AddWithValue("@VoteNumber", i);

                try
                {
                    if (sqliteCommand.ExecuteNonQuery() > 0)
                    {
                        success = true;
                    }
                }
                catch (SQLiteException)
                {

                }

            }

            connection.Close();
            return success;
        }
        public Campaign GetCurrentCampaign()
        {
            //Gets Current Campaign and returns Campaign Object
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT CampaignName,CampaignLength,IsCurrent FROM Campaign WHERE isCurrent = 1 ", connection);

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
        public List<string> GetCurrentCampaignVoteOptions(string campaignName)
        {
            //Retrieves Current Campaign Options and Returns them as a List
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT VoteDescription FROM CampaignVotes WHERE Campaign = @Campaign", connection);
            sqliteCommand.Parameters.AddWithValue("@Campaign", campaignName);

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
        public bool CreateVote(int voteID, string CurrentCampaign, string username, string password, string ballotDesc)
        {
            //Creates Vote with inputted Details. returns True if successful
            bool voteSuccess = false;
            SQLiteConnection connection = CreateConnection();


            SQLiteCommand sqliteCommand;

            using (sqliteCommand = new SQLiteCommand("SELECT Voted FROM User WHERE userName = @username AND password =@password", connection))
            {

                sqliteCommand.Parameters.AddWithValue("@username", username);
                sqliteCommand.Parameters.AddWithValue("@password", password);

                var returnValue = (bool)sqliteCommand.ExecuteScalar();

                if (returnValue != true)
                {

                    using (SQLiteCommand sqliteCommand2 = connection.CreateCommand())
                    {
                        string createString = "INSERT INTO Vote(Campaign, Ballot, BallotDescription) VALUES(@Campaign,@Ballot,@BallotDescription); UPDATE User SET Voted = 1 WHERE userName = @username AND password =@password;";

                        sqliteCommand2.Parameters.AddWithValue("@Campaign", CurrentCampaign);
                        sqliteCommand2.Parameters.AddWithValue("@Ballot", voteID);
                        sqliteCommand2.Parameters.AddWithValue("@username", username);
                        sqliteCommand2.Parameters.AddWithValue("@password", password);
                        sqliteCommand2.Parameters.AddWithValue("@BallotDescription", ballotDesc);
                        sqliteCommand2.CommandText = createString;
                        int success = sqliteCommand2.ExecuteNonQuery();
                        voteSuccess = true;
                    }

                    connection.Close();

                }
            }
            return voteSuccess;
        }
        public bool DeleteUser(string userName)
        {
            //Deletes User with inputted values. Return True if user deleted.
            bool success = false;
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand;

            using (sqliteCommand = connection.CreateCommand())
            {
                string deleteString = "DELETE FROM User WHERE userName = @userName;";

                sqliteCommand.Parameters.AddWithValue("@userName", userName);
                sqliteCommand.CommandText = deleteString;
                
                if (sqliteCommand.ExecuteNonQuery() > 0)
                {
                    success = true;
                }
            }
            connection.Close();
            return success;
        }
        public bool AddUser(string username, string password, string role)
        {
            //Adds User with inputted values. Return True if user deleted.
            bool success = false;
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand;

            using (sqliteCommand = connection.CreateCommand())
            {
                string insertString = "INSERT INTO User ( userName, password, role, voted ) VALUES ( @userName, @password, @role, @Voted );";

                sqliteCommand.Parameters.AddWithValue("@userName", username);
                sqliteCommand.Parameters.AddWithValue("@password", password);
                sqliteCommand.Parameters.AddWithValue("@role", role);
                sqliteCommand.Parameters.AddWithValue("@Voted", 0);
                sqliteCommand.CommandText = insertString;
                try
                {
                    if (sqliteCommand.ExecuteNonQuery() > 0)
                    {
                        success = true;
                    }
                }
                catch (SQLiteException)
                {

                }
            }

            connection.Close();
            return success;
        }
        public bool HasAlreadyVoted(string username)
        {
            //Check to see if the Voter has already Voted. Returns True/false.
            bool returnValue = true;

            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand;

            using (sqliteCommand = new SQLiteCommand("SELECT voted FROM User WHERE userName = @username", connection))
            {
                //FIX so it just sees if there is a record and not get role
                sqliteCommand.Parameters.AddWithValue("@username", username);
                returnValue = (bool)sqliteCommand.ExecuteScalar();

            }

            connection.Close();

            return returnValue;
        }
        public List<string> GetCompletedCampaignVotes(string campaignName)
        {
            // Get a List of all the Campaign Votes of a selected campaign
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT Campaign, Ballot FROM Vote WHERE Campaign = @Campaign;", connection);
            sqliteCommand.Parameters.AddWithValue("@Campaign", campaignName);

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
        public List<string> GetAllCampaigns()
        {
            // Get a List of all the Campaigns
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT CampaignName, CampaignLength, IsCurrent FROM Campaign;", connection);

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
        public List<Vote> GetAllVotes(string campaignName)
        {
            // Get a List of all the Votes of a specific Campaign
            SQLiteConnection connection = CreateConnection();

            SQLiteCommand sqliteCommand = new SQLiteCommand("SELECT Ballot, BallotDescription FROM Vote WHERE Campaign = @Campaign;", connection);
            sqliteCommand.Parameters.AddWithValue("@Campaign", campaignName);

            List<Vote> listReturned = new List<Vote>();

            using (var reader = sqliteCommand.ExecuteReader())
            {

                while (reader.Read())
                {

                    Vote vote = new Vote();
                    vote.Ballot = Convert.ToInt32(reader["Ballot"]);
                    vote.BallotDescription = reader["BallotDescription"].ToString();
                    listReturned.Add(vote);
                    }
                
            }

            connection.Close();

            return listReturned;
        }
    }
}