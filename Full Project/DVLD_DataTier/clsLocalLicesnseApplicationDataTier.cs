using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DataTier
{
    public class clsLocalLicesnseApplicationDataTier
    {
        public static bool IsPersonAppointmentExistsInDB(int PersonID, int LicensesClassID)
        {
            bool IsLocalDrivingLicenseAppExists = false;
            string Query = @"Select * From IsPersonAppointmentExists(@PersonID , @LicensesClassID)";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@LicensesClassID", LicensesClassID);

                        object Reuslt = cmd.ExecuteScalar();

                        IsLocalDrivingLicenseAppExists = (Reuslt == null || Reuslt == DBNull.Value) ? false : Convert.ToBoolean(Reuslt);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return IsLocalDrivingLicenseAppExists;
        }

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID ,int LicenseClassID)
        {
            int NewAppID = -1;
            string Query = @"Insert Into LocalDrivingLicenseApplications(ApplicationID , LicenseClassID)
                             values (@ApplicationID , @LicenseClassID);
                             Select SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                NewAppID = (int.TryParse(cmd.ExecuteScalar().ToString(), out int NewID) ? NewID : -1);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return NewAppID;
        }

        public static bool GetLocalLicenseApplication(int LocalLicenseApplicationID , ref int ApplicationID , ref int LicenseClassID)
        {
            bool IsAppFound = false;
            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string Query = @"Select * From LocalDrivingLicenseApplications
                             Where LocalDrivingLicenseApplicationID = @LocalAppID;";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LocalAppID", LocalLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsAppFound = true;

                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            { 
                IsAppFound = false; 
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsAppFound;
        }

        public static bool GetLocalLicenseApplicationByApplicationID(int ApplicationID, ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
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

        public static bool UpdateLocalLicneseApplication(int LocalAppID , int LicenseClassID)
        {
            bool IsAppUpdated = false;
            string Query = @"Update LocalDrivingLicenseApplications 
                             Set LicenseClassID = @NewLicenseClassID
                             Where LocalDrivingLicenseApplicationID = @LocalAppID";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@LocalAppID", LocalAppID);
                        cmd.Parameters.AddWithValue("@NewLicenseClassID", LicenseClassID);
                
                        IsAppUpdated = (cmd.ExecuteNonQuery() > 0);
                    }
                }
                
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            

            return IsAppUpdated;
        }

        public static DataTable GetAllLocalApps()
        {
            DataTable dt = new DataTable();
            string Query = @"Select * From LocalDrivingLicenseApplications_View        
                             Order By ApplicationDate Desc;";


            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return dt;
        }

        [Obsolete("This Will Be Automatic Soon!")]
        public static DataTable GetAllLocalAppsFilltered(string FillterColumn , string FillterValue)
        {
            DataTable dt = new DataTable();

            string Query = $@"SELECT * FROM LocalDrivingLicenseApplications_View
                               WHERE {FillterColumn} LIKE @FillterValue + '%'
                               Order By ApplicationDate Desc;";

            string[] allowedColumns = { "LocalDrivingLicenseApplicationID", "NationalNo", "FullName", "Status" };

            if (!allowedColumns.Contains(FillterColumn))
                return dt;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FillterValue", FillterValue);

                        using(SqlDataReader reader = cmd.ExecuteReader())
                            dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return dt;
        }

        public static bool DeleteLocalApplicationFormDB(int LocalApplicationID)
        {
            bool IsAppDeleted = false;
            string Query = @"DELETE FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @AppID";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@AppID", LocalApplicationID);

            try
            {
                connection.Open();
                IsAppDeleted = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsAppDeleted;
        }

        public static bool IsLocalApplicationExists(int LocalAppID)
        {
            bool IsAppExist = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    Connection.Open();

                    string Query = @"SELECT Found = 1 FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalAppID;";

                    using (SqlCommand cmd = new SqlCommand(Query, Connection))
                    {
                        cmd.Parameters.AddWithValue("@LocalAppID", LocalAppID);

                        IsAppExist = (Convert.ToInt32(cmd.ExecuteScalar()) > 0);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                IsAppExist = false;
            }

            return IsAppExist;
        }
    }
}
