using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.SymbolStore;

namespace MyDVLD_DataTier
{
    public class clsUsersManagmentDataTier
    {
        public static DataTable GetAllUsersFromDB()
        {
            DataTable data = new DataTable();

            string Query = @"SELECT Users.UserID, Users.PersonID, 
                             (People.FirstName + ' ' + People.SecondName + ' ' + People.LastName) as FullName,
                             Users.UserName, Users.IsActive 
                             FROM Users INNER JOIN People
                             ON Users.PersonID = People.PersonID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                data.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return data;
        }

        public static DataTable GetFillteredUsersFromDB(string FilterColumn, string FillterValue)
        {
            DataTable data = new DataTable();
            string Query = string.Empty;

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            if (FillterValue == "active" || FillterValue == "not active")
                Query = $@"SELECT Users.UserID, Users.PersonID, 
                             (People.FirstName + ' ' + People.SecondName + ' ' + People.LastName) as FullName ,
                             Users.UserName, Users.IsActive 
                             FROM Users INNER JOIN People
                             ON Users.PersonID = People.PersonID
                             Where Users.{FilterColumn} Like @FillterValue;";
            else
                Query = $@"WITH UsersFilterTable 
                           AS (SELECT 
                               Users.UserID,
                               Users.PersonID,
                               (People.FirstName + ' ' + People.SecondName + ' ' + People.LastName) AS FullName,
                               Users.UserName,
                               Users.IsActive
                           FROM Users 
                           INNER JOIN People ON Users.PersonID = People.PersonID)
                           SELECT * 
                           FROM UsersFilterTable
                           WHERE UsersFilterTable.{FilterColumn} LIKE @FillterValue + '%';";

            SqlCommand cmd = new SqlCommand(Query, connection);

            if (FillterValue == "active")
                cmd.Parameters.AddWithValue("@FillterValue", 1);
            else if (FillterValue == "not active")
                cmd.Parameters.AddWithValue("@FillterValue", 0);
            else
                cmd.Parameters.AddWithValue("@FillterValue", FillterValue);

            try
            {
                connection.Open();
                data.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return data;
        }

        public static bool DeleteUserFromDB(int UserID)
        {
            bool IsDeleted = false;

            string Request = "Delete From Users Where UserID = @UserID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Request, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserID);

                        IsDeleted = (cmd.ExecuteNonQuery() > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            return IsDeleted;
        }

        public static int AddNewUserToDB(int PersonID , string Username , string Password , bool IsUserActive)
        {
            int UserAddedId = -1;

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            // Adding UserPassword Encrepted..
            string Query = @"Insert Into Users(PersonID , UserName , Password , IsActive)
                              Values(@PersonId , @Username , @Password , @IsActive);
                              Select SCOPE_IDENTITY();";  

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@PersonId" , PersonID);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsUserActive);


            try
            {
                connection.Open();
                int.TryParse(cmd.ExecuteScalar().ToString(), out UserAddedId);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return UserAddedId;
        }

        public static bool GetUserInfoFromDB(int UserId, ref int PersonId, ref string Username, ref string Password, ref bool IsActive)
        {
            bool UserDataFound = false;

            string Query = @"Select Users.PersonID, Users.Password ,Users.UserName, Users.IsActive From Users
                             Where UserID = @UserId";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(@Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", UserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserDataFound = true;

                                PersonId = Convert.ToInt32(reader["PersonID"]);
                                Username = reader["UserName"].ToString();
                                Password = reader["Password"].ToString();
                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UserDataFound = false; 
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return UserDataFound;
        }

        public static bool GetUserInfoFromDB(string Username, string Password, ref int PersonId,
                                            ref int UserId, ref bool IsActive)
        {
            bool UserDataFound = false;

            string Query = @"Select Users.PersonID, Users.UserID, Users.IsActive From Users
                             Where UserName = @Username and Password = @Password;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(@Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserDataFound = true;

                                PersonId = Convert.ToInt32(reader["PersonID"]);
                                UserId = Convert.ToInt32(reader["UserID"]);
                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                            }
                        }
                    }
                }
            }
            catch 
            { 
                UserDataFound = false; 
            }

            return UserDataFound;
        }

        public static bool IsUserExistsInDB(int PersonID)
        {
            bool UserDataFound = false;
            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string Query = "Select Found=1 From Users Where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand (Query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                UserDataFound = (cmd.ExecuteReader().HasRows);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return UserDataFound;
        }

        public static bool IsUserExistsInDB(string Username)
        {
            bool UserDataFound = false;
            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string Query = "Select Found=1 From Users Where UserName = @Username";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    UserDataFound = Convert.ToBoolean(result);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return UserDataFound;
        }

        public static bool UpdateUserInDB(int UserID , string Username , string Password , bool IsActive)
        {
            bool IsUserUpdated = false;
            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string Query = @"Update Users
                             Set Username = @Username,
                                 Password = @Password,
                                 IsActive = @IsActive
                                 Where UserID = @UserID;";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);


            try
            {
                connection.Open();
                IsUserUpdated = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsUserUpdated;
        }
    }
}
