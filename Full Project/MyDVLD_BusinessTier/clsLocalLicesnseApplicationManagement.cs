using MyDVLD_DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyDVLD_BusinessTier
{
    public class clsLocalLicesnseApplicationManagement : clsApplicationsManagement
    {
        public new enum enMode { AddNew, Update }

        private enMode _Mode = enMode.AddNew;
        public clsLicensesClassesManagement LicenseClass { get; set; }
        public int LocalApplicationID { get; set; }

        public clsLocalLicesnseApplicationManagement() : base()
        {
            _Mode = enMode.AddNew;

            LocalApplicationID = -1;
            LicenseClass = clsLicensesClassesManagement.Find(-1);
        }

        private clsLocalLicesnseApplicationManagement(int localLicesnseApplicationID, int licenseClassID, int applicationID,int applicantPersonID, DateTime applicationDate,
                                                      int ApplicationTypeID, int applicationStatus, DateTime LastStatusDate,
                                                      float paidFees, int createdByUserID) 
                                                     :base(applicationID,applicantPersonID,applicationDate,ApplicationTypeID,applicationStatus,
                                                      LastStatusDate,paidFees,createdByUserID)
        {
            _Mode = enMode.Update;

            LocalApplicationID = localLicesnseApplicationID;
            LicenseClass = clsLicensesClassesManagement.Find(licenseClassID);
        }

        private bool _AddNew()
        {
            LocalApplicationID = clsLocalLicesnseApplicationDataTier.AddNewLocalDrivingLicenseApplication(ApplicationID , LicenseClass.ClassID);

            return (LocalApplicationID != -1);
        }

        private bool _UpdateLocalLicenseApp() => clsLocalLicesnseApplicationDataTier.UpdateLocalLicneseApplication(LocalApplicationID, LicenseClass.ClassID);

        public static bool IsPersonAppliedForLicenseClass(int PersonID, int LicenseClassID) => clsLocalLicesnseApplicationDataTier.IsPersonAppointmentExistsInDB(PersonID, LicenseClassID);

        public override bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (base.Save())
                    {
                        if (_AddNew())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                case enMode.Update:
                    if (base.Save())
                        return _UpdateLocalLicenseApp();
                    else
                        return false;
            }

            return false;
        }

        public static new clsLocalLicesnseApplicationManagement Find(int LocalApplicationID)
        {
            int AppID = -1;
            int LicenseClassID = -1;

            if (clsLocalLicesnseApplicationDataTier.GetLocalLicenseApplication(LocalApplicationID, ref AppID, ref LicenseClassID))
            {
                clsApplicationsManagement FindApp = clsApplicationsManagement.Find(AppID);

                return new clsLocalLicesnseApplicationManagement(LocalApplicationID, LicenseClassID, AppID ,
                    FindApp.ApplicantPerson.PersonID , FindApp.ApplicationDate , 
                    (short)FindApp.ApplicationType.ApplicationService , (int)FindApp.ApplicationStatus ,
                    FindApp.LastStatusDate , FindApp.PaidFees.HasValue ? FindApp.PaidFees.Value : -1 , FindApp.CreatedByUser.UserID);
            }
            else
                return new clsLocalLicesnseApplicationManagement();
        }
        
        public static clsLocalLicesnseApplicationManagement FindByApplicationID(int ApplicationID)
        {
            int LocalAppID = -1;
            int LicenseClassID = -1;

            if(clsLocalLicesnseApplicationDataTier.GetLocalLicenseApplicationByApplicationID(ApplicationID, ref LocalAppID, ref LicenseClassID))
            {
                clsApplicationsManagement FindApp = clsApplicationsManagement.Find(ApplicationID);

                return new clsLocalLicesnseApplicationManagement(LocalAppID, LicenseClassID, ApplicationID,
                    FindApp.ApplicantPerson.PersonID, FindApp.ApplicationDate,
                    (short)FindApp.ApplicationType.ApplicationService, (int)FindApp.ApplicationStatus,
                    FindApp.LastStatusDate, FindApp.PaidFees.HasValue ? FindApp.PaidFees.Value : -1, FindApp.CreatedByUser.UserID);
            }
            else
                return null;
        }

        /// <summary>
        /// Make Application States Completed...
        /// </summary>
        public bool CompleteApplication()
        {
            this.ApplicationStatus = enApplicationStatus.Completed;
            return this.Save();
        }

        //public static bool operator == (clsLocalLicesnseApplicationManagement LDLA_1, clsLocalLicesnseApplicationManagement LDLA_2)
        //{
        //    if (ReferenceEquals(LDLA_1, LDLA_2))
        //        return true;

        //    if (ReferenceEquals(LDLA_1, null) || ReferenceEquals(LDLA_2, null))
        //        return false;

        //    return (LDLA_1._Mode == LDLA_2._Mode)
        //        && (LDLA_1.ApplicantPerson.PersonID == LDLA_2.ApplicantPerson.PersonID)
        //        && (LDLA_1.LicenseClass.ClassID == LDLA_2.LicenseClass.ClassID)
        //        && (LDLA_1.ApplicationID == LDLA_2.ApplicationID)
        //        && (LDLA_1.LocalApplicationID == LDLA_2.LocalApplicationID);
        //}

        //public static bool operator != (clsLocalLicesnseApplicationManagement LDLA_1, clsLocalLicesnseApplicationManagement LDLA_2)
        //{
        //    return !(LDLA_1 == LDLA_2);
        //}

        public static bool CancelApplicationsStates(int LocalAppID)
        {
            clsLocalLicesnseApplicationManagement CancelLocalApp = Find(LocalAppID);

            CancelLocalApp.ApplicationStatus = enApplicationStatus.Canceled;

            if (CancelLocalApp.Save())
                return true;
            else
                return false;
        }

        public static DataTable LocalApplications() => clsLocalLicesnseApplicationDataTier.GetAllLocalApps();

        [Obsolete("Old Method It Will Be Direct Form The DGV")]
        public static DataTable LocalApplicationsFillter(string FillterCloumn , string FillterValue) => clsLocalLicesnseApplicationDataTier.GetAllLocalAppsFilltered(FillterCloumn, FillterValue);

        public static bool DeleteLocalApplication(int LocalAppID)
        {
            clsLocalLicesnseApplicationManagement LocalAppToDelete = Find(LocalAppID);

            if(clsLocalLicesnseApplicationDataTier.DeleteLocalApplicationFormDB(LocalAppToDelete.LocalApplicationID))
                return DeleteApplicationWithID(LocalAppToDelete.ApplicationID);
            else
                return false;
        }

        public static bool IsLocalApplicationExists(int LocalAppID) => clsLocalLicesnseApplicationDataTier.IsLocalApplicationExists(LocalAppID);
    }
}
