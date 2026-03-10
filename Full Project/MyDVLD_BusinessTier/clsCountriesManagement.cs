using MyDVLD_DataTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_BusinessTier
{
    public class clsCountriesManagement
    {
        public static int GetCountryIDByName(string CountryName) => clsCountryManagementDataTier.GetCountryIdByNameFromDB(CountryName);
        public static string GetCountryNameByID(int CountryID) => clsCountryManagementDataTier.GetCountryNameByIdFromDB(CountryID);

        public static List<string> GetAllCountries() => clsCountryManagementDataTier.GetAllCountriesFromDB();
    }
}
