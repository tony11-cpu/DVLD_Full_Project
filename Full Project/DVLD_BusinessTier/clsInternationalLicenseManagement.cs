using MyDVLD_DataAccess;
using MyDVLD_DataTier;
using System;
using System.ComponentModel;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace MyDVLD_BusinessTier
{
    public class clsInternationalLicenseManagement
    {
        public enum enMode { AddNew, Update }
        private enMode _Mode { get; set; } = enMode.AddNew;
        public int? InternationalLicenseID { get; private set; } = null;
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; } = DateTime.Now;
        public DateTime ExpirationDate { get; private set; }
        public bool IsActive { get; set; }
        public clsApplicationsManagement InternationalApplication { get; set; } = clsApplicationsManagement.Find(-1);

        private clsInternationalLicenseManagement()
        {
            _Mode = enMode.AddNew;

            InternationalLicenseID = null;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now; ;
            IsActive = false;
        }

        private clsInternationalLicenseManagement(int internationalLicenseID, int applicationID,
            int driverID, int issuedUsingLocalLicenseID, DateTime issueDate,
            DateTime expirationDate, bool isActive, int createdByUserID) 
        {
            _Mode = enMode.Update;

            InternationalLicenseID = internationalLicenseID;
            ExpirationDate = expirationDate;
            InternationalApplication = clsApplicationsManagement.Find(applicationID);
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            IsActive = isActive;
        }

        public static DataTable GetAllInternationalLicenses() => clsInternationalLicensesData.GetAllInternationalLicenses();

        public static bool IsInternationalLicenseExistsByDriverID(int DriverID) =>clsInternationalLicensesData.IsDriverHasActiveInternationalLicense(DriverID);

        public static clsInternationalLicenseManagement Find(int InternationalLicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now.AddYears(1);
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clsInternationalLicensesData.GetInternationalLicenseByID(InternationalLicenseID, ref ApplicationID, ref DriverID,
                                                                     ref IssuedUsingLocalLicenseID, ref IssueDate,
                                                                     ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicenseManagement(InternationalLicenseID, ApplicationID, DriverID,
                                                             IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,
                                                             IsActive, CreatedByUserID);
            }
            else
                return new clsInternationalLicenseManagement();
        }

        public static clsInternationalLicenseManagement FindByDriver(int DriverID)
        {
            int ApplicationID = -1;
            int InternationalLicenseID = -1;
            int IssuedUsingLocalLicenseID = -1;
            DateTime IssueDate = DateTime.Now;
            DateTime ExpirationDate = DateTime.Now.AddYears(1);
            bool IsActive = false;
            int CreatedByUserID = -1;

            if (clsInternationalLicensesData.GetInternationalLicensesByDriverID(DriverID ,ref InternationalLicenseID, ref ApplicationID,
                                                                     ref IssuedUsingLocalLicenseID, ref IssueDate,
                                                                     ref ExpirationDate, ref IsActive, ref CreatedByUserID))
            {
                return new clsInternationalLicenseManagement(InternationalLicenseID, ApplicationID, DriverID,
                                                             IssuedUsingLocalLicenseID, IssueDate, ExpirationDate,
                                                             IsActive, CreatedByUserID);
            }
            else
                return new clsInternationalLicenseManagement();
        }

        private bool _AddNewInternationalLicense()
        {
            InternationalLicenseID = clsInternationalLicensesData.AddNewInternationalLicense(InternationalApplication.ApplicationID, DriverID, 
                IssuedUsingLocalLicenseID,IsActive, InternationalApplication.CreatedByUser.UserID);

            return (InternationalLicenseID != null);
        }

        public bool Save()
        {
            if (!InternationalApplication.Save())
                return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewInternationalLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return false;
            }

            return false;
        }
    }
}
