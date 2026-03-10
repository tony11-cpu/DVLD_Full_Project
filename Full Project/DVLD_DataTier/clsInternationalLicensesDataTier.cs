using MyDVLD_DataTier;
using System;
using System.Data;
using System.Data.SqlClient;

namespace MyDVLD_DataAccess
{
    public class clsInternationalLicensesData
    {
        public static bool GetInternationalLicenseByID(int InternationalLicenseID,ref int ApplicationID,ref int DriverID,
                                                       ref int IssuedUsingLocalLicenseID,ref DateTime IssueDate
                                                      ,ref DateTime ExpirationDate,ref bool IsActive,ref int CreatedByUserID)
        {
            bool isFound = false;
            string query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ApplicationID = (int)reader["ApplicationID"];
                                DriverID = (int)reader["DriverID"];
                                IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                                IssueDate = (DateTime)reader["IssueDate"];
                                ExpirationDate = (DateTime)reader["ExpirationDate"];
                                IsActive = (bool)reader["IsActive"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return isFound;
        }

        public static bool GetInternationalLicensesByDriverID(int DriverID ,ref int InternationalLicenseID, ref int ApplicationID, ref int IssuedUsingLocalLicenseID,
            ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string query = @"SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    InternationalLicenseID = (int)reader["InternationalLicenseID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    IssuedUsingLocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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



        public static int? AddNewInternationalLicense(int ApplicationID,int DriverID,int IssuedUsingLocalLicenseID,
                                                      bool IsActive,int CreatedByUserID)
        {
            int? NewID = null;
            string query = @"UPDATE InternationalLicenses 
                             SET IsActive = 0 
                             WHERE DriverID = @DriverID;
                             
                             INSERT INTO InternationalLicenses
                             (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                             VALUES
                             (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                             
                             SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand command = new SqlCommand(query, connection, transaction))
                            {
                                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;
                                command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;
                                command.Parameters.Add("@IssuedUsingLocalLicenseID", SqlDbType.Int).Value = IssuedUsingLocalLicenseID;
                                command.Parameters.Add("@IssueDate", SqlDbType.Date).Value = DateTime.Now.Date;
                                command.Parameters.Add("@ExpirationDate", SqlDbType.Date).Value = DateTime.Now.AddYears(1).Date;
                                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive;
                                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = CreatedByUserID;

                                object result = command.ExecuteScalar();
                                if (result != null && int.TryParse(result.ToString(), out int newid))
                                    NewID = newid;
                                else
                                {
                                    transaction.Rollback();
                                    return null;
                                }
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            if (transaction != null)
                                transaction.Rollback();

                            clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    clsDB_Util.clsEventLog.LogEvent($"Connection error: {ex.Message}", System.Diagnostics.EventLogEntryType.Error);
                    return null;
                }
            }

            return NewID;
        }

        public static bool UpdateInternationalLicense(int InternationalLicenseID,int ApplicationID,int DriverID,int IssuedUsingLocalLicenseID,
            DateTime IssueDate,DateTime ExpirationDate,bool IsActive,int CreatedByUserID)
        {
            bool isUpdated = false;

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string query = @"UPDATE InternationalLicenses SET
                ApplicationID = @ApplicationID,
                DriverID = @DriverID,
                IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                IssueDate = @IssueDate,
                ExpirationDate = @ExpirationDate,
                IsActive = @IsActive,
                CreatedByUserID = @CreatedByUserID
                WHERE InternationalLicenseID = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                int rows = command.ExecuteNonQuery();
                isUpdated = (rows > 0);
            }
            catch (Exception ex)
            {
                isUpdated = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return isUpdated;
        }

        public static bool DeleteInternationalLicense(int InternationalLicenseID)
        {
            bool isDeleted = false;

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string query = @"DELETE FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

            try
            {
                connection.Open();
                int rows = command.ExecuteNonQuery();

                isDeleted = (rows > 0);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return isDeleted;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string query = @"SELECT * FROM InternationalLicenses 
                             order by IsActive desc, ExpirationDate desc";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    dt.Load(reader);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool IsDriverHasActiveInternationalLicense(int DriverID)
        {
            bool result = false;

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string query = @"SELECT TOP 1 InternationalLicenses.IsActive 
                             FROM InternationalLicenses Join Licenses
                             On InternationalLicenses.IssuedUsingLocalLicenseID = Licenses.LicenseID
                             WHERE InternationalLicenses.DriverID = @DriverID 
                             and Licenses.LicenseClass = 3 
                             and (GetDate() between InternationalLicenses.IssueDate and InternationalLicenses.ExpirationDate)
                             and InternationalLicenses.IsActive = 1
                             ORDER BY InternationalLicenseID DESC;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                object value = command.ExecuteScalar();

                if (value != null)
                    result = (bool)value;
            }
            catch (Exception ex)
            {
                result = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return result;
        }
    }
}
