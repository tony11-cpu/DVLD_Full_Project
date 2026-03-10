using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DataTier
{
    public class clsTestTypesDataTier
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable tb = new DataTable();
            string Query = "Select * From TestTypes Order By TestTypeFees Desc;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(Query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                        tb.Load(reader);
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return tb;
        }

        public static bool UpdateTestTypes(int TestTypeID, string TestTypeTitle, string TestTypeDescription , float TestTypeFees)
        {
            bool IsAppUpdated = false;
            string Query = @"Update TestTypes
                             Set TestTypeTitle = @Title,
                                 TestTypeDescription = @Description,
                                 TestTypeFees = @Fees
                                 Where TestTypeID = @TestID;";

            try
            {
                using(SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using(SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TestID", TestTypeID);
                        cmd.Parameters.AddWithValue("@Title", TestTypeTitle);
                        cmd.Parameters.AddWithValue("@Description", TestTypeDescription);
                        cmd.Parameters.AddWithValue("@Fees", TestTypeFees);

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

        public static bool GetTestTypeByID(int TestID, ref string TestTitle, ref string TestDescription ,ref float Fees)
        {
            bool TestGot = false;
            string Query = "Select * From TestTypes Where TestTypeID = @TestID";

            SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString);

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TestGot = true;

                    TestTitle = reader["TestTypeTitle"].ToString();
                    TestDescription = reader["TestTypeDescription"].ToString();
                    Fees = Convert.ToSingle(reader["TestTypeFees"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                TestGot = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return TestGot;
        }
    }
}
