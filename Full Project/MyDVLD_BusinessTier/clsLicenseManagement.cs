using MyDVLD_DataTier;
using System;
using System.ComponentModel;
using System.Data;
using static MyDVLD_BusinessTier.clsApplicationTypeManagement;

namespace MyDVLD_BusinessTier
{
    public class clsLicenseManagement
    {
        public enum enIssueReason { FirstTime = 1, Renew = 2, ReplacementForLost = 3, ReplacementForDamaged = 4 }

        public enum enLicenseMode { AddNew, Update }
        private enLicenseMode _Mode = enLicenseMode.AddNew;

        public int? LicenseID { get; private set; } = null;
        public int ApplicationID { get; set; }
        public clsDriversManagement Driver { get; set; } = clsDriversManagement.Find(-1);
        public clsLicensesClassesManagement LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; } = null;
        public float? PaidFees { get; set; } = null;
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsActive { get; set; }
        public string LicenseIssueReasonText
        {
            get
            {
                switch ((enIssueReason)IssueReason)
                {
                    case enIssueReason.FirstTime:
                        return "First Time";
                    case enIssueReason.ReplacementForDamaged:
                        return "Replacement For Damaged";
                    case enIssueReason.ReplacementForLost:
                        return "Replacement For Lost";
                    case enIssueReason.Renew:
                        return "Renew";
                }

                return string.Empty;
            }
        }
        public bool IsLicenseDetained => clsDetainedLicensesManagement.IsLicenseDetained(LicenseID ?? -1);
        public bool IsLicenseExpired => DateTime.Now > ExpirationDate;

        private clsLicenseManagement()
        {
            _Mode = enLicenseMode.AddNew;

            LicenseID = null;
            ApplicationID = -1;
            Driver = clsDriversManagement.Find(-1);
            LicenseClass = clsLicensesClassesManagement.Find(-1);
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = null;
            PaidFees = -1;
            IsActive = false;
            IssueReason = -1;
            CreatedByUserID = -1;
        }

        private clsLicenseManagement(int LicenseID, int ApplicationID, int DriverID, int LicenseClass,
                                     DateTime IssueDate, DateTime ExpirationDate, string Notes, float PaidFees,
                                     bool IsActive, int IssueReason, int CreatedByUserID)
        {
            _Mode = enLicenseMode.Update;

            this.LicenseID = LicenseID;
            this.ApplicationID = ApplicationID;
            this.Driver = clsDriversManagement.Find(DriverID);
            this.LicenseClass = clsLicensesClassesManagement.Find(LicenseClass);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.CreatedByUserID = CreatedByUserID;
        }

        public static clsLicenseManagement Find(int LicenseID)
        {
            int ApplicationID = -1;
            int DriverID = -1;
            int LicenseClass = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = null;
            float PaidFees = 0f;
            bool IsActive = false;
            int IssueReason = -1;
            int CreatedByUserID = -1;

            if (clsLicenseDataTier.GetLicenseInfoByLicenseID(LicenseID, ref ApplicationID, ref DriverID, ref LicenseClass,
                                                         ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees,
                                                         ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenseManagement(LicenseID, ApplicationID, DriverID, LicenseClass,
                                                IssueDate, ExpirationDate, Notes, PaidFees,
                                                IsActive, IssueReason, CreatedByUserID);
            }
            else
                return new clsLicenseManagement();
        }

        public static clsLicenseManagement Find(int DriverID , int LicenseClassID)
        {
            int ApplicationID = -1;
            int LicenseID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = string.Empty;
            float PaidFees = 0;
            bool IsActive = false;
            int IssueReason = -1;
            int CreatedByUserID = -1;

            if (clsLicenseDataTier.GetLicenseInfoByDriverIDAndLicenseClassID(DriverID, LicenseClassID,ref LicenseID, ref ApplicationID,
                                                      ref IssueDate, ref ExpirationDate, ref Notes, ref PaidFees,
                                                      ref IsActive, ref IssueReason, ref CreatedByUserID))
            {
                return new clsLicenseManagement(LicenseID, ApplicationID, DriverID, LicenseClassID,
                                                IssueDate, ExpirationDate, Notes, PaidFees,
                                                IsActive, IssueReason, CreatedByUserID);
            }
            else
            {
                return new clsLicenseManagement();
            }
        }

        public static bool IsLicenseExists(int LicenseID) => clsLicenseDataTier.IsLicenseExists(LicenseID);

        private bool _AddNewLicense()
        {
            LicenseID = clsLicenseDataTier.AddNewLicense(ApplicationID, Driver.DriverID, LicenseClass.ClassID,
                                                          ExpirationDate, Notes, PaidFees.HasValue ? PaidFees.Value : -1,
                                                          IsActive, IssueReason, CreatedByUserID);
            return LicenseID != null;
        }

        private bool _UpdateLicense() => clsLicenseDataTier.UpdateLicense(LicenseID, ApplicationID, Driver.DriverID, LicenseClass.ClassID,
                                                    IssueDate, ExpirationDate, Notes, PaidFees.HasValue? PaidFees.Value : -1,
                                                    IsActive, IssueReason, CreatedByUserID);

        public bool Save()
        {
            switch (_Mode)
            {
                case enLicenseMode.AddNew:
                    if (_AddNewLicense())
                    {
                        _Mode = enLicenseMode.Update;
                        return true;
                    }
                    return false;
                case enLicenseMode.Update:
                    return _UpdateLicense();
            }

            return false;
        }

        private bool _DeactivateLicense()
        {
            this.IsActive = false;
            return this.Save();
        }

        public clsLicenseManagement RenewLicense(string Notes , int UserInSysID)
        {
            clsApplicationsManagement NewApplication = clsApplicationsManagement.Find(-1);
            clsApplicationTypeManagement AppType = clsApplicationTypeManagement.Find((int)enApplicationService.RenewDrivingLicense);

            NewApplication.ApplicationType = AppType;
            NewApplication.ApplicationStatus = clsApplicationsManagement.enApplicationStatus.Completed;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.CreatedByUser = clsUsersManagement.Find(UserInSysID);
            NewApplication.ApplicantPerson = Driver.Person;
            NewApplication.PaidFees = AppType.ApplicationFees;

            if(!NewApplication.Save())
                return null;

            clsLicenseManagement RenewedLicense = Find(-1);

            RenewedLicense.Notes = (string.IsNullOrEmpty(Notes) || Notes == "No Notes")? string.Empty : Notes;
            RenewedLicense.Driver = Driver;
            RenewedLicense.CreatedByUserID = UserInSysID;
            RenewedLicense.IssueDate = DateTime.Now;
            RenewedLicense.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
            RenewedLicense.ApplicationID = NewApplication.ApplicationID;
            RenewedLicense.IsActive = true;
            RenewedLicense.IssueReason = (int)enIssueReason.Renew;
            RenewedLicense.LicenseClass = LicenseClass;
            RenewedLicense.PaidFees = LicenseClass.ClassFees;

            if (!RenewedLicense.Save() || !_DeactivateLicense())
                return null;
            else
                return RenewedLicense;
        }

        public clsLicenseManagement ReplaceLicense(enApplicationService ReplaceReason, int UserInSysID)
        {
            clsApplicationsManagement NewApplication = clsApplicationsManagement.Find(-1);
            clsApplicationTypeManagement AppType = clsApplicationTypeManagement.Find((int)ReplaceReason);

            NewApplication.ApplicationType = AppType;
            NewApplication.ApplicationStatus = clsApplicationsManagement.enApplicationStatus.Completed;
            NewApplication.ApplicationDate = DateTime.Now;
            NewApplication.CreatedByUser = clsUsersManagement.Find(UserInSysID);
            NewApplication.ApplicantPerson = Driver.Person;
            NewApplication.PaidFees = AppType.ApplicationFees;

            if (!NewApplication.Save())
                return null;

            clsLicenseManagement ReplacedLicense = Find(-1);

            ReplacedLicense.Notes = (string.IsNullOrEmpty(Notes) || Notes == "No Notes") ? string.Empty : Notes;
            ReplacedLicense.Driver = Driver;
            ReplacedLicense.CreatedByUserID = UserInSysID;
            ReplacedLicense.IssueDate = DateTime.Now;
            ReplacedLicense.ExpirationDate = DateTime.Now.AddYears(LicenseClass.DefaultValidityLength);
            ReplacedLicense.ApplicationID = NewApplication.ApplicationID;
            ReplacedLicense.IsActive = true;
            ReplacedLicense.IssueReason = (int)ReplaceReason;
            ReplacedLicense.LicenseClass = LicenseClass;
            ReplacedLicense.PaidFees = LicenseClass.ClassFees;

            if (!ReplacedLicense.Save() || !_DeactivateLicense())
                return null;
            else
                return ReplacedLicense;
        }

        public clsDetainedLicensesManagement DetainLicense(float FineFees , int UserInSysID)
        {
            clsDetainedLicensesManagement NewDetainedLicense = clsDetainedLicensesManagement.Find(-1);

            NewDetainedLicense.FineFees = FineFees;
            NewDetainedLicense.LicenseToDetaineID = LicenseID ?? -1;
            NewDetainedLicense.CreatedByUserID = UserInSysID;

            if (NewDetainedLicense.Save())
               return NewDetainedLicense;
            else
               return null;
        }
    }
}
