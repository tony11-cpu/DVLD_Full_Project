using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Schema;

namespace MyDVLD_DataTier
{
    public class clsDriversDataTier
    {
        public static int? AddDriverToDatabase(int PersonID , int CreatedByUserID)
        {
            int? DriverID = null;
            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                             VALUES (@PersonID, @CreatedByUserID, @CreatedDate);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);

            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString() , out int NotNullQ))
                    DriverID = NotNullQ;
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                DriverID = null;
            }
            finally
            {
                connection.Close();
            }

            return DriverID;
        }

        public static bool IsDriverExistByPersonID(int PersonID)
        {
            bool exists = false;
            string query = @"SELECT 1 FROM Drivers WHERE PersonID = @PersonID;";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                exists = (Convert.ToInt32(cmd.ExecuteScalar()) > 0);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return exists;
        }

        public static bool GetDriverInfoByDriverD(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool found = false;
            string query = @"SELECT PersonID, CreatedByUserID, CreatedDate
                             FROM Drivers
                             WHERE DriverID = @DriverID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    { 
                        cmd.Parameters.AddWithValue("@DriverID", DriverID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                found = true;

                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                found = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return found;
        }

        public static bool GetDriverInfoByPersonID(int PersonID, ref int DriverID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string query = @"SELECT DriverID, CreatedByUserID, CreatedDate
                             FROM Drivers
                             WHERE PersonID = @PersonID;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    found = true;

                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                found = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return found;
        }

        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_GetAllDrivers", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return dt;
        }

        public static DataTable GetAllLocalLicensesInfoByDriverID(int DriverID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetLocalLicensesByDriverID(@DriverID)", connection))
                    {
                        cmd.Parameters.AddWithValue("@DriverID", DriverID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return dt;
        }

        public static DataTable GetAllInternationalLicensesInfoByDriverID(int DriverID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetInternationalLicensesByDriverID(@DriverID) ORDER BY InternationalLicenseID DESC", connection))
                    {
                        cmd.Parameters.AddWithValue("@DriverID", DriverID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return dt;
        }
    }
}

