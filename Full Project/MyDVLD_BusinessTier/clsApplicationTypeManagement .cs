
using MyDVLD_DataTier;
using System;
using System.Data;
using System.Threading.Tasks;

namespace MyDVLD_BusinessTier
{
    public class clsApplicationTypeManagement
    {
        public enum enApplicationService
        {
            NewLocalDrivingLicense = 1, RenewDrivingLicense = 2,
            ReplacementForLostDrivingLicense = 3,ReplacementForDamagedDrivingLicense  = 4,
            ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7,
        }
        public enApplicationService ApplicationService { get; set; } = enApplicationService.NewLocalDrivingLicense;

        public enum enAppTypeMode { AddNew = 1, Update = 2 }
        public enAppTypeMode Mode { get; private set; } = enAppTypeMode.AddNew;

        public string ApplicationTitle { get; set; } = null;
        public float? ApplicationFees { get; set; } = null;

        private clsApplicationTypeManagement(int applicationID, string applicationTitle, float applicationFees)
        {
            Mode = enAppTypeMode.Update;

            ApplicationService = (enApplicationService)applicationID;
            this.ApplicationTitle = applicationTitle;
            this.ApplicationFees = applicationFees;
        }

        private clsApplicationTypeManagement()
        {
            Mode = enAppTypeMode.AddNew;

            ApplicationService = enApplicationService.NewLocalDrivingLicense;
            this.ApplicationTitle = null;
            this.ApplicationFees = 0;
        }

        public static DataTable GetAllAppTypesData() => clsApplicationTypesDataTier.GetAllAppTypes();

        public static string ApplicationFeesString(enApplicationService AppType) => Find((short)AppType).ApplicationFees?.ToString();

        private bool _UpdateAppData() => 
            clsApplicationTypesDataTier.UpdateApplicationType((int)ApplicationService, ApplicationTitle, ApplicationFees.HasValue ? ApplicationFees.Value : 0);

        public static clsApplicationTypeManagement Find(int AppID)
        {
            string AppTitle = string.Empty;
            float AppFees = 0;

            if (clsApplicationTypesDataTier.GetApplicationByID(AppID, ref AppTitle, ref AppFees))
                return new clsApplicationTypeManagement(AppID, AppTitle, AppFees);
            else
                return null;
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enAppTypeMode.AddNew:
                    // No Add New Functionallity...
                    Mode = enAppTypeMode.Update;
                    return false;
                case enAppTypeMode.Update:
                    return _UpdateAppData();
            }

            return false;
        }
    }
}
