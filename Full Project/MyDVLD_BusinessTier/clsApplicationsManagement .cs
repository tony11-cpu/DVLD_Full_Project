using MyDVLD_DataTier;
using System;

namespace MyDVLD_BusinessTier
{
    public class clsApplicationsManagement
    {
        public enum enApplicationStatus { New = 1, Canceled = 2, Completed = 3 }
        public enApplicationStatus ApplicationStatus { get; set; }

        public enum enMode { AddNew , Update }
        private enMode Mode { set; get; } = enMode.AddNew;

        public int ApplicationID { get; private set; } = -1;
        public clsPeopleManagement ApplicantPerson { get; set; } = clsPeopleManagement.Find(-1);
        public clsUsersManagement CreatedByUser { set; get; } = clsUsersManagement.Find(-1);
        public clsApplicationTypeManagement ApplicationType { get; set; } = clsApplicationTypeManagement.Find(-1);

        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public DateTime LastStatusDate { get; private set; } = DateTime.Now;
        public float? PaidFees { get; set; } = null;

        public clsApplicationsManagement()
        {
            Mode = enMode.AddNew;
            ApplicationStatus = enApplicationStatus.New;

            ApplicantPerson = clsPeopleManagement.Find(-1);
            ApplicationDate = DateTime.Now;
            ApplicationType = clsApplicationTypeManagement.Find(-1);
            LastStatusDate = DateTime.Now;
            PaidFees = null;
            CreatedByUser = clsUtil.SignedInUser;
        }

        public clsApplicationsManagement(int applicationID, int applicantPersonID, DateTime applicationDate,
                                         int applicationTypeID, int applicationStatus, DateTime LastStatusDate, 
                                         float paidFees, int createdByUserID)
        {
            Mode = enMode.Update;
            ApplicationStatus = (enApplicationStatus)applicationStatus;

            ApplicationID = applicationID;
            ApplicantPerson = clsPeopleManagement.Find(applicantPersonID);
            ApplicationDate = applicationDate;
            ApplicationType = clsApplicationTypeManagement.Find(applicationTypeID);
            this.LastStatusDate = LastStatusDate;
            PaidFees = paidFees;
            CreatedByUser = clsUsersManagement.Find(createdByUserID);   
         }

        /// <summary>
        /// Find App Info By Id
        /// </summary>
        /// <param name="AppID">App ID</param>
        /// <returns>Class Of Application Full With info</returns>
        public static clsApplicationsManagement Find(int AppID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicantTypeID = -1;
            short ApplicatioStatus = -1;
            DateTime AppLastStatusDate = DateTime.Now;
            float PaidFees = -1;
            int CreatedByUserID = -1;

            if(clsApplicationsDataTier.GetApplicationDataByAppID(AppID , ref ApplicantPersonID , ref ApplicationDate , 
                                                             ref ApplicantTypeID,ref ApplicatioStatus, ref AppLastStatusDate, 
                                                             ref PaidFees, ref CreatedByUserID))
                return new clsApplicationsManagement(AppID, ApplicantPersonID, ApplicationDate,
                                                    ApplicantTypeID, ApplicatioStatus, AppLastStatusDate,
                                                    PaidFees, CreatedByUserID);
            else
                return new clsApplicationsManagement();
        }

        private bool _AddNew()
        {
            ApplicationID = clsApplicationsDataTier.AddNewApplicationToDB(ApplicantPerson.PersonID, ApplicationDate,
                                                                         (short)ApplicationType.ApplicationService,
                                                                         (short)ApplicationStatus, DateTime.Now,
                                                                         PaidFees.HasValue? PaidFees.Value : -1,CreatedByUser.UserID);
            return (ApplicationID != -1);
        }

        private bool _UpdateApp() => clsApplicationsDataTier.UpdateApplicationInDB(ApplicationID, ApplicantPerson.PersonID, ApplicationDate,
                                                                (short)ApplicationType.ApplicationService,
                                                                (short)ApplicationStatus, DateTime.Now,
                                                                PaidFees.HasValue ? PaidFees.Value : -1, CreatedByUser.UserID);

        public virtual bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNew())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                   return _UpdateApp();
            }

            return false;
        }

        public static bool DeleteApplicationWithID(int AppId) => clsApplicationsDataTier.DeleteApplicationFormDB(AppId);

        public static bool IsApplicationExists(int AppId) => clsApplicationsDataTier.IsApplicationExists(AppId);
    }
}
