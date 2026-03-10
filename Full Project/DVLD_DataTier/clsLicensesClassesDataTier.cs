using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DataTier
{
    public class clsLicensesClassesDataTier
    {
        public static List<string> GetAllLicencesClasseNames()
        {
            List<string> AllClasses = new List<string>();
            string Query = "Select ClassName From LicenseClasses;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                AllClasses.Add(reader["ClassName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return AllClasses;
        }

        public static bool GetLicenseInfoByID(int LicenseID, ref string ClassName, ref string ClassDescription,
                                              ref short MinimumAllowedAge, ref short DefaultValidityLength
                                             ,ref int ClassFees)
        {
            bool IsLicenseFound = false;
            string Query = "Select * From LicenseClasses Where LicenseClassID = @LID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDB_Util.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@LID", LicenseID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsLicenseFound = true;

                                ClassName = reader["ClassName"].ToString();
                                ClassDescription = reader["ClassDescription"].ToString();
                                MinimumAllowedAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
                                DefaultValidityLength = Convert.ToInt16(reader["DefaultValidityLength"]);
                                ClassFees = Convert.ToInt32(reader["ClassFees"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsLicenseFound = false;
                clsDB_Util.clsEventLog.LogEvent(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            return IsLicenseFound;
        }
    }
}
