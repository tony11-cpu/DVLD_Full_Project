using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyDVLD_DataTier
{
    public class clsTestAppointmentsDataTier
    {
        public static DataTable GetAllTestsAppointmentsWithLocalDrivingLicenseID(int LocalDrivingLicenseID , string TestMode)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string Query = @"select TestAppointments_View.TestAppointmentID , TestAppointments_View.AppointmentDate , TestAppointments_View.PaidFees , TestAppointments_View.IsLocked From TestAppointments_View   
                             Where TestAppointments_View.LocalDrivingLicenseApplicationID = @LDLAID
                             and TestAppointments_View.TestTypeTitle like @TestMode + '%';";

            using (SqlCommand cmd = new SqlCommand(Query, connection))
            {
                cmd.Parameters.AddWithValue("@LDLAID", LocalDrivingLicenseID);
                cmd.Parameters.AddWithValue("@TestMode", TestMode);

                try
                {
                    connection.Open();

                    using (SqlDataReader Reader = cmd.ExecuteReader())
                        dt.Load(Reader);
                }
                catch (Exception ex)
                {
                    clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                finally { connection.Close(); }
            }
            
            return dt;
        }


        public static bool GetTestAppointmentWithID(int? TestAppointmentID , ref int testTypeID, ref int localDrivingLicenseApplicationID,
                                                    ref DateTime appointmentDate, ref int paidFees, ref int createdByUserID,
                                                    ref bool isAppointmentLocked, ref int retakeTestApplicationID)
        {
            if (TestAppointmentID == null)
                return false;

            bool IsTestFound = false;

            string Query = "Select * From TestAppointments Where TestAppointmentID = @ID;";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(Query , connection);
            cmd.Parameters.AddWithValue("@ID" , TestAppointmentID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsTestFound = true;

                    testTypeID = Convert.ToInt32(reader["TestTypeID"]);
                    localDrivingLicenseApplicationID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    appointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    paidFees = Convert.ToInt32(reader["PaidFees"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    isAppointmentLocked = Convert.ToBoolean(reader["IsLocked"]);
                    retakeTestApplicationID = (reader["RetakeTestApplicationID"] == null || reader["RetakeTestApplicationID"] == DBNull.Value)? -1 : Convert.ToInt32(reader["RetakeTestApplicationID"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsTestFound = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsTestFound;
        }

        public static bool IsTestAppointemntExistsWithLocalDriningLicenseApplicationID(int LocalDriningLicenseApplication , int TestTypeID)
        {
            bool IsTestFound = false;
            string Query = @"Select Found = 1 From TestAppointments 
                             Where TestAppointments.LocalDrivingLicenseApplicationID = @LocalAppID 
                             and TestTypeID = @TestTypeID and TestAppointments.IsLocked = 0;";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LocalAppID" , LocalDriningLicenseApplication);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                using(SqlDataReader reader = cmd.ExecuteReader())
                    IsTestFound = (reader.HasRows);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsTestFound;
        }

        public static int? AddNewTestAppointmentToTheDataBase(int TestTypeID , int LocalDriningAppID , DateTime AppointmentDate, float PaidFees 
                                                           , int CreatedByUserID , bool IsLocked , int RetakeTestAppID)
        {
            int? IsNewTestAppointmentAdded = null;
            string Query = @"INSERT INTO [dbo].[TestAppointments]
                             ([TestTypeID],[LocalDrivingLicenseApplicationID],[AppointmentDate],[PaidFees]
                             ,[CreatedByUserID],[IsLocked],[RetakeTestApplicationID])
                              VALUES (@TestTypeID,@LocalDriningAppID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked,@RetakeTestAppID);
                              SELECT SCOPE_IDENTITY();";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDriningAppID", LocalDriningAppID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

            if (RetakeTestAppID == -1 || RetakeTestAppID == 0)
                cmd.Parameters.AddWithValue("@RetakeTestAppID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@RetakeTestAppID", RetakeTestAppID);

            try
            {
                connection.Open();

                object obj = cmd.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int NewTestAppointment))
                    IsNewTestAppointmentAdded = NewTestAppointment;
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsNewTestAppointmentAdded;
        }

        public static bool UpdateTestAppointmentInDB(int? TestAppointmentsID, int TestTypeID,int LocalDrivingAppID, DateTime AppointmentDate,
                                                     float PaidFees,int CreatedByUserID,bool IsLocked,int RetakeTestAppID)
        {
            if (TestAppointmentsID == null)
                return false;

            bool isTestAppointmentUpdated = false;

            string query = @"UPDATE [dbo].[TestAppointments]
                             SET [TestTypeID] = @TestTypeID,
                                 [LocalDrivingLicenseApplicationID] = @LocalDrivingAppID,
                                 [AppointmentDate] = @AppointmentDate,
                                 [PaidFees] = @PaidFees,
                                 [CreatedByUserID] = @CreatedByUserID,
                                 [IsLocked] = @IsLocked,
                                 [RetakeTestApplicationID] = @RetakeTestAppID
                             WHERE [TestAppointmentID] = @TestAppointmentsID;";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestAppointmentsID", TestAppointmentsID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingAppID", LocalDrivingAppID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);

           if (RetakeTestAppID <= 0)
                cmd.Parameters.AddWithValue("@RetakeTestAppID", DBNull.Value);
           else
                cmd.Parameters.AddWithValue("@RetakeTestAppID", RetakeTestAppID);

           try
           {
               connection.Open();
               isTestAppointmentUpdated = cmd.ExecuteNonQuery() > 0;
           }
           catch (Exception ex)
           {
               clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
           }
           finally { connection.Close(); }

           return isTestAppointmentUpdated;
        }
    }
}
