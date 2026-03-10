using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_BusinessTier
{
    public class clsDetainedLicensesManagement
    {
        public enum enMode { Addnew = 1 , Update = 2 }
        private enMode _Mode = enMode.Addnew;

        public int? DetainedLicenseID { get; private set; } = null;
        public int LicenseToDetaineID { get; set; }
        public DateTime DetainDate { get; private set; } = DateTime.Now;
        public float FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; private set; } = false;
        public DateTime ReleaseDate { get; private set; }
        public int ReleasedByUserID { get; set; }
        public int ReleasedApplicationID { get; set; }


        private clsDetainedLicensesManagement()
        {
            _Mode = enMode.Addnew;

            DetainedLicenseID = null;
            DetainDate = DateTime.Now;
            LicenseToDetaineID = -1;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = DateTime.Now; 
            ReleasedByUserID = -1;
            ReleasedApplicationID = -1;
        }

        private clsDetainedLicensesManagement(int detainedLicenseID, int licenseToDetaineID, DateTime detainDate, 
                                              float fineFees, int createdByUserID, bool isReleased, 
                                              DateTime releaseDate, int releasedByUserID, int releasedApplicationID)
        { 
            _Mode = enMode.Update;

            DetainedLicenseID = detainedLicenseID;
            LicenseToDetaineID = licenseToDetaineID;
            DetainDate = detainDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleasedApplicationID = releasedApplicationID;
        }

        public static bool IsLicenseDetained(int licenseID) => clsDetainedLicensesDataTier.IsLicenseDetainedWithID(licenseID);

        public clsDetainedLicensesManagement ReleaseDetainedLicense()
        {
            clsApplicationsManagement ReleaseApp = clsApplicationsManagement.Find(-1);
            clsApplicationTypeManagement AppType = 
                clsApplicationTypeManagement.Find((short)clsApplicationTypeManagement.enApplicationService.ReleaseDetainedDrivingLicsense);

            ReleaseApp.PaidFees = AppType.ApplicationFees + FineFees;
            ReleaseApp.ApplicationType = AppType;
            ReleaseApp.CreatedByUser = clsUtil.SignedInUser;
            ReleaseApp.ApplicationDate = DateTime.Now;
            ReleaseApp.ApplicantPerson = clsLicenseManagement.Find(LicenseToDetaineID).Driver.Person;
            ReleaseApp.ApplicationStatus = clsApplicationsManagement.enApplicationStatus.Completed;

            if(!ReleaseApp.Save())
                return null;

            this.IsReleased = true;
            this.ReleaseDate = DateTime.Now;
            this.ReleasedByUserID = clsUtil.SignedInUser.UserID;
            this.ReleasedApplicationID = ReleaseApp.ApplicationID;

            if (this.Save())
                return this;
            else
                return null;
        }
       
        private bool _AddNewDetaeinLicense()
        {
            DetainedLicenseID = clsDetainedLicensesDataTier.AddNewDeatinedLicenseToDB(LicenseToDetaineID, DetainDate, FineFees,
                CreatedByUserID, false);

            return (DetainedLicenseID != null);
        }

        private bool _UpdateDetainedLicense() => clsDetainedLicensesDataTier.UpdateDetainedLicense(DetainedLicenseID ?? -1, DetainDate, FineFees, 
                                                                                                   CreatedByUserID, IsReleased, ReleaseDate,
                                                                                                   ReleasedByUserID, ReleasedApplicationID);

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Addnew:
                    if(_AddNewDetaeinLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                   return _UpdateDetainedLicense();
            }

            return false;
        }

        public static clsDetainedLicensesManagement Find(int DetainedLicenseID)
        {
            int LicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicensesDataTier.GetDetainedLicenseInfo(DetainedLicenseID, ref LicenseID, ref DetainDate, ref FineFees,
                                                                   ref CreatedByUserID, ref IsReleased, ref ReleaseDate, 
                                                                   ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainedLicensesManagement(DetainedLicenseID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
                                                         ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return new clsDetainedLicensesManagement();
        }

        public static clsDetainedLicensesManagement FindByLicenseID(int LicenseID)
        {
            int DetainedLicenseID = -1;
            DateTime DetainDate = DateTime.Now;
            float FineFees = 0;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.Now;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            if (clsDetainedLicensesDataTier.GetDetainedLicenseInfoByLicenseID(LicenseID, ref DetainedLicenseID, ref DetainDate, ref FineFees,
                                                                   ref CreatedByUserID, ref IsReleased, ref ReleaseDate,
                                                                   ref ReleasedByUserID, ref ReleaseApplicationID))
                return new clsDetainedLicensesManagement(DetainedLicenseID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased,
                                                         ReleaseDate, ReleasedByUserID, ReleaseApplicationID);
            else
                return new clsDetainedLicensesManagement();
        }

        public static DataTable GetAllDetainedLicenses() => clsDetainedLicensesDataTier.GetAllDetainedLicenses();
    }
}
