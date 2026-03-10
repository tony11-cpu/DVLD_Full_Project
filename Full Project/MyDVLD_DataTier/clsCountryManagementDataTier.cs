using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDVLD_DataTier
{
    public class clsCountryManagementDataTier
    {
        public static int GetCountryIdByNameFromDB(string CountryName)
        {
            int CountryId = -1;
            SqlConnection Connection = new SqlConnection(clsDB_Util.ConnectionString);

            string Query = @"SELECT CountryID FROM Countries WHERE CountryName = @CountryName;";

            SqlCommand cmd = new SqlCommand(Query, Connection);
            cmd.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Connection.Open();
                object CountryIdObj = cmd.ExecuteScalar();

                if (CountryIdObj != null)
                    CountryId = Convert.ToInt32(CountryIdObj);
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                Connection.Close();
            }

            return CountryId;
        }

        public static string GetCountryNameByIdFromDB(int CountryID)
        {
            string CountryName = string.Empty;
            string Query = @"SELECT CountryName FROM Countries WHERE CountryID = @CountryID;";

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    Connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, Connection))
                    {
                        cmd.Parameters.AddWithValue("@CountryID", CountryID);

                        object CountryNameObj = cmd.ExecuteScalar();

                        if (CountryNameObj != null)
                            CountryName = CountryNameObj.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return CountryName;
        }

        public static List<string> GetAllCountriesFromDB()
        {
            List<string> AllCountries = new List<string>();
            string Query = @"SELECT * FROM Countries;";

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    Connection.Open();

                    using(SqlCommand cmd = new SqlCommand(Query, Connection))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                AllCountries.Add(reader["CountryName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return AllCountries;
        }
    }
}
