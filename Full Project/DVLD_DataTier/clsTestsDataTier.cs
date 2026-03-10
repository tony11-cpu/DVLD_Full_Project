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
            string Query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                                            VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                                            
                                            UPDATE TestAppointments 
                                            SET IsLocked = 1 
                                            WHERE TestAppointmentID = @TestAppointmentID;
                                            
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
                            using (SqlCommand cmd = new SqlCommand(Query, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                                cmd.Parameters.AddWithValue("@TestResult", TestResult);
                                cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
                                cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                                object obj = cmd.ExecuteScalar();

                                if (obj != null && int.TryParse(obj.ToString(), out int NewTest))
                                    NewTestID = NewTest;
                                else
                                {
                                    transaction.Rollback();
                                    return null;
                                }

                                transaction.Commit();
                            }
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
                    clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    return null;
                }
            }

            return NewTestID;
        }
        public static bool UpdateTestInDB(int? TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            if (TestID == null || TestID == -1)
                return false;

            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            string Query = @"UPDATE Tests
                             SET TestAppointmentID = @TestAppointmentID,
                                 TestResult = @TestResult,
                                 Notes = @Notes,
                                 CreatedByUserID = @CreatedByUserID
                             WHERE TestID = @TestID;";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestID", TestID);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes) ? (object)DBNull.Value : Notes);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                IsUpdated = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsUpdated;
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

        public static int NumberOfTestPassesWithAppID(int LocalApplicationID)
        {
            int NumberOfTestPasses = -1;
            string Query = $@"SELECT COUNT(dbo.TestAppointments.TestTypeID)
                              FROM dbo.Tests INNER JOIN
                              dbo.TestAppointments ON dbo.Tests.TestAppointmentID = dbo.TestAppointments.TestAppointmentID
							  Join LocalDrivingLicenseApplications On dbo.TestAppointments.LocalDrivingLicenseApplicationID = dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                              WHERE (dbo.TestAppointments.LocalDrivingLicenseApplicationID = dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID) 
                              AND (dbo.Tests.TestResult = 1) 
                              AND (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDLID);";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@LocalDLID", LocalApplicationID);

            try
            {
                connection.Open();

                if (int.TryParse(cmd.ExecuteScalar().ToString(), out int NoOfTests) && (cmd.ExecuteScalar() != null || cmd.ExecuteScalar() != DBNull.Value))
                    NumberOfTestPasses = NoOfTests;
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return NumberOfTestPasses;
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
