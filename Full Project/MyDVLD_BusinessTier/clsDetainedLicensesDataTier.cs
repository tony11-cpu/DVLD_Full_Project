using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_BusinessTier
{
    public class clsDetainedLicensesDataTier
    {

        public static bool IsLicenseDetainedInDBByID(int License)
        {
            bool isDetained = false;
            string query = @"Select IsDetained = 1 From DetainedLicenses Where DetainedLicenses.LicenseID = @LicenseID";

            SqlConnection connection = new SqlConnection(clsShairedDataBaseProperties.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", License);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    isDetained = (bool)reader["IsDetained"];

                reader.Close();
            }
            catch
            {
            }
            finally
            {
                connection.Close();
            }

            return isDetained;
        }

    }
}
