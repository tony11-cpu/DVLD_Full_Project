using System;
using System.Data;
using MyDVLD_DataTier;

namespace MyDVLD_BusinessTier
{
    public class clsDriversManagement
    {
        public enum enDriverMode { AddNew, Update }

        private enDriverMode _Mode = enDriverMode.AddNew;

        public int? DriverID { get; private set; } = null;
        public clsPeopleManagement Person { get; set; } = clsPeopleManagement.Find(-1);
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        private clsDriversManagement()
        {
            _Mode = enDriverMode.AddNew;

            DriverID = null;
            Person = clsPeopleManagement.Find(-1);
            CreatedByUserID = -1;
            CreatedDate = DateTime.Now;
        }

        private clsDriversManagement(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            _Mode = enDriverMode.Update;

            this.DriverID = driverID;
            this.Person = clsPeopleManagement.Find(personID);
            this.CreatedByUserID = createdByUserID;
            this.CreatedDate = createdDate;
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriversDataTier.GetAllDrivers();
        }

        public static bool IsDriverExists(int PersonID) => clsDriversDataTier.IsDriverExistByPersonID(PersonID);

        public static clsDriversManagement Find(int DriverID)
        {
            int PersonID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriversDataTier.GetDriverInfoByDriverD(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriversManagement(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return new clsDriversManagement();
        }

        public static clsDriversManagement FindByPersonID(int PersonID)
        {
            int DriverID = -1;
            int CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.Now;

            if (clsDriversDataTier.GetDriverInfoByPersonID(PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriversManagement(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return new clsDriversManagement();
        }

        private bool _AddNewDriver()
        {
            DriverID = clsDriversDataTier.AddDriverToDatabase(Person.PersonID, CreatedByUserID);

            return (DriverID != null);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enDriverMode.AddNew:
                    if (_AddNewDriver())
                        return true;
                    else
                        return false;

                    // No Update... (Maybe Added Soon?)
            }

            return false;
        }

        public static DataTable GetAllLocalLicensesInfoByDriverID(int DriverID) => clsDriversDataTier.GetAllLocalLicensesInfoByDriverID(DriverID); 

        public static DataTable GetAllInternationalLicensesInfoByDriverID(int DriverID) => clsDriversDataTier.GetAllInternationalLicensesInfoByDriverID(DriverID);
    }
}

