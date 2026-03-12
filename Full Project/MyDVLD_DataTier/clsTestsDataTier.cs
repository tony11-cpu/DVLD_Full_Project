using System;
using System.Data;
using System.Data.SqlClient;

namespace MyDVLD_DataTier
{
    public class clsTestsDataTier
    {
        public static int? AddNewTestToDB(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int? NewTestID = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_AddNewTest", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        cmd.Parameters.AddWithValue("@TestResult", TestResult);
                        cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
                        cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        SqlParameter outParam = new SqlParameter("@NewTestID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outParam);

                        cmd.ExecuteNonQuery();

                        if (outParam.Value != DBNull.Value && (int)outParam.Value > 0)
                            NewTestID = (int)outParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return NewTestID;
        }

        public static bool UpdateTestInDB(int? TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            if (TestID == null || TestID == -1)
                return false;

            bool IsUpdated = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_UpdateTest", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TestID", TestID.Value);
                        cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        cmd.Parameters.AddWithValue("@TestResult", TestResult);
                        cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
                        cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

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

        public static int NumberOfTestPassesWithAppID(int LocalApplicationID)
        {
            int NumberOfPasses = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT NumberOfPasses FROM dbo.GetNumberOfTestPassesByLocalAppID(@LocalDLID)", connection))
                    {
                        cmd.Parameters.AddWithValue("@LocalDLID", LocalApplicationID);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            NumberOfPasses = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return NumberOfPasses;
        }

        public static int NumberOfTrialsForTestWithAppID(int AppID, int TestMode)
        {
            int NumberOfTrials = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT NumberOfTrials FROM dbo.GetNumberOfTrialsForTestByAppID(@AppID, @TestMode)", connection))
                    {
                        cmd.Parameters.AddWithValue("@AppID", AppID);
                        cmd.Parameters.AddWithValue("@TestMode", TestMode);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            NumberOfTrials = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return NumberOfTrials;
        }

        public static bool FindTestInDB(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string Query = "SELECT * FROM Tests WHERE TestID = @TestID";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]);
                    TestResult = Convert.ToBoolean(reader["TestResult"]);
                    Notes = reader["Notes"] == DBNull.Value ? "" : reader["Notes"].ToString();
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            { 
                IsFound = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool GetLastTestResultWithLocalDrivingLicneseIdFromDB(int LocalDrivingLicnenseID , short TestMode)
        {
            bool IsPassed = false;
            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string Query = @"Select Tests.TestResult From Tests
                             Join TestAppointments On Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             Where TestAppointments.LocalDrivingLicenseApplicationID = @LocalDrivingLicnenseID and TestAppointments.TestTypeID = @TestMode
                             Order By Tests.TestResult desc;";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicnenseID", LocalDrivingLicnenseID);
            cmd.Parameters.AddWithValue("@TestMode", TestMode);

            try
            {
                connection.Open();
                bool.TryParse(cmd.ExecuteScalar().ToString() , out IsPassed);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsPassed;
        }

        public static int NumberOfTrailsForTestWithAppID(int AppID , int TestMode)
        {
            int NumberOfTrailsForTest = 0;
            string Query = @"Select Count(Tests.TestID) As NumberOfTrails
                             From Tests Join TestAppointments On Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             Where TestAppointments.LocalDrivingLicenseApplicationID = @AppID and TestAppointments.TestTypeID = @TestMode and Tests.TestResult = 0;";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(Query , connection);
            cmd.Parameters.AddWithValue("@AppID", AppID);
            cmd.Parameters.AddWithValue("@TestMode", TestMode);

            try
            {
                connection.Open();

                if (int.TryParse(cmd.ExecuteScalar().ToString(), out int NumberOfTrials))
                    NumberOfTrailsForTest = NumberOfTrials;

            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return NumberOfTrailsForTest;
        }
    }
}
