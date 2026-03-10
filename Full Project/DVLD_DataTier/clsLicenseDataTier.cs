using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace MyDVLD_DataTier
{
        public class clsLicenseDataTier
        {
             public static bool GetLicenseInfoByLicenseID(int LicenseID, ref int ApplicationID, ref int DriverID,
                                                   ref int LicenseClass, ref DateTime IssueDate, ref DateTime ExpirationDate,
                                                   ref string Notes, ref float PaidFees, ref bool IsActive,
                                                   ref int IssueReason, ref int CreatedByUserID)
            {
                bool isFound = false;

                SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

                string query = @"SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LicenseID", LicenseID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        ApplicationID = (int)reader["ApplicationID"];
                        DriverID = (int)reader["DriverID"];
                        LicenseClass = (int)reader["LicenseClass"];
                        IssueDate = (DateTime)reader["IssueDate"];
                        ExpirationDate = (DateTime)reader["ExpirationDate"];
                        Notes = reader["Notes"] == DBNull.Value ? "No Notes" : (string)reader["Notes"];
                        PaidFees = Convert.ToSingle(reader["PaidFees"]);
                        IsActive = (bool)reader["IsActive"];
                        IssueReason = Convert.ToInt32(reader["IssueReason"]);
                        CreatedByUserID = (int)reader["CreatedByUserID"];
                    }

                    reader.Close();
                }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
                {
                    connection.Close();
                }

                return isFound;
            }
             
             public static bool GetLicenseInfoByDriverIDAndLicenseClassID(int DriverID, int LicenseClassID , ref int LicenseID, ref int ApplicationID,
                                                       ref DateTime IssueDate, ref DateTime ExpirationDate,
                                                       ref string Notes, ref float PaidFees, ref bool IsActive,
                                                       ref int IssueReason, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string query = @"SELECT * FROM Licenses
                             WHERE Licenses.DriverID = @DriverID and Licenses.LicenseClass = @LicenseClassID
                             Order By IsActive DESC;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LicenseID = (int)reader["LicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = reader["Notes"] == DBNull.Value ? "No Notes" : (string)reader["Notes"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = Convert.ToInt32(reader["IssueReason"]);
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
             
             public static int? AddNewLicense(int ApplicationID, int? DriverID, int LicenseClass,
                                             DateTime ExpirationDate, string Notes, float PaidFees,
                                             bool IsActive, int IssueReason, int CreatedByUserID)
            {
            if (DriverID == null || DriverID == -1)
                return null;

                int? LicenseID = null;

                SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

                string query = @"INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes,PaidFees, IsActive, IssueReason, CreatedByUserID)
                                VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                                SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@DriverID", DriverID);
                command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                command.Parameters.AddWithValue("@IssueDate", DateTime.Now);
                command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) || Notes == "No Notes" ? (object)DBNull.Value : Notes);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@IssueReason", IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString() , out int R))
                        LicenseID = R;
                }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
                {
                    connection.Close();
                }

                return LicenseID;
            }
             
             public static bool UpdateLicense(int? LicenseID, int ApplicationID, int? DriverID,
                                              int LicenseClass, DateTime IssueDate, DateTime ExpirationDate,
                                              string Notes, float PaidFees, bool IsActive,
                                              int IssueReason, int CreatedByUserID)
            {

            if (LicenseID == null || LicenseID == -1 || DriverID == null || DriverID == -1)
                return false;

                bool isUpdated = false;

                SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);
                string query = @"UPDATE Licenses 
                                SET ApplicationID = @ApplicationID,
                                    DriverID = @DriverID,
                                    LicenseClass = @LicenseClass,
                                    IssueDate = @IssueDate,
                                    ExpirationDate = @ExpirationDate,
                                    Notes = @Notes,
                                    PaidFees = @PaidFees,
                                    IsActive = @IsActive,
                                    IssueReason = @IssueReason,
                                    CreatedByUserID = @CreatedByUserID
                                WHERE LicenseID = @LicenseID";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@LicenseID", LicenseID);
                command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                command.Parameters.AddWithValue("@DriverID", DriverID);
                command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                command.Parameters.AddWithValue("@IssueDate", IssueDate);
                command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
                command.Parameters.AddWithValue("@PaidFees", PaidFees);
                command.Parameters.AddWithValue("@IsActive", IsActive);
                command.Parameters.AddWithValue("@IssueReason", IssueReason);
                command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                try
                {
                    connection.Open();

                    isUpdated = (command.ExecuteNonQuery() > 0);
                }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
                {
                    connection.Close();
                }

                return isUpdated;
            }            
                          
             public static bool IsLicenseExists(int LicenseID)
           {
               int count = default;
               SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);
               
               string query = @"SELECT COUNT(1) FROM Licenses WHERE LicenseID = @LicenseID";
               SqlCommand command = new SqlCommand(query, connection);
               command.Parameters.AddWithValue("@LicenseID", LicenseID);
               try
               {
                   connection.Open();
                   count = Convert.ToInt32(command.ExecuteScalar());
               }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
               {
                   connection.Close();
               }
               return count > 0;
           }
        }
}
