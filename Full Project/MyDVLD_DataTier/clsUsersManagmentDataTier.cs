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

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_GetAllUsers", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

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

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_DeleteUser", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", UserID);

                        SqlParameter outParam = new SqlParameter("@IsDeleted", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outParam);

                        cmd.ExecuteNonQuery();

                        IsDeleted = outParam.Value != DBNull.Value && Convert.ToBoolean(outParam.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return IsDeleted;
        }

        public static int AddNewUserToDB(int PersonID, string Username, string Password, bool IsUserActive)
        {
            int NewUserID = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_AddNewUser", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@IsActive", IsUserActive);

                        SqlParameter outParam = new SqlParameter("@NewUserID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outParam);

                        cmd.ExecuteNonQuery();

                        if (outParam.Value != DBNull.Value && (int)outParam.Value > 0)
                            NewUserID = (int)outParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return NewUserID;
        }

        public static bool GetUserInfoFromDB(int UserId, ref int PersonId, ref string Username, ref string Password, ref bool IsActive)
        {
            bool UserDataFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("Select * From dbo.GetUserInfoByID(@UserID)", connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonId = Convert.ToInt32(reader["PersonID"]);
                                Username = reader["UserName"].ToString();
                                Password = reader["Password"].ToString();
                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                                UserDataFound = true;
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

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("Select * From dbo.GetUserInfoByUsernameAndPassword(@Username, @Password)", connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonId = Convert.ToInt32(reader["PersonID"]);
                                UserId = Convert.ToInt32(reader["UserID"]);
                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                                UserDataFound = true;
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

        public static bool IsUserExistsInDB(int PersonID)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_IsUserExistsByPersonID", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);

                        SqlParameter outParam = new SqlParameter("@IsExists", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outParam);

                        cmd.ExecuteNonQuery();

                        IsExists = outParam.Value != DBNull.Value && Convert.ToBoolean(outParam.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return IsExists;
        }

        public static bool IsUserExistsInDB(string Username)
        {
            bool IsExists = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_IsUserExistsByUsername", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Username", Username);

                        SqlParameter outParam = new SqlParameter("@IsExists", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outParam);

                        cmd.ExecuteNonQuery();

                        IsExists = outParam.Value != DBNull.Value && Convert.ToBoolean(outParam.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return IsExists;
        }

        public static bool UpdateUserInDB(int UserID, string Username, string Password, bool IsActive)
        {
            bool IsUpdated = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_UpdateUser", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@IsActive", IsActive);

                        SqlParameter outParam = new SqlParameter("@IsUpdated", SqlDbType.Bit)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outParam);

                        cmd.ExecuteNonQuery();

                        IsUpdated = outParam.Value != DBNull.Value && Convert.ToBoolean(outParam.Value);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return IsUpdated;
        }
    }
}
