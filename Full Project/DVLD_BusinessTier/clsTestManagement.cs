using System;
using System.Data;
using MyDVLD_DataTier;

namespace MyDVLD_BusinessTier
{
    public class clsTestManagement
    {
        public enum enMode { AddNew, Update }
        private enMode _Mode = enMode.AddNew;

        public int? TestID { get; private set; } = null;
        public int TestAppointmentID { get; set; } = -1;
        public bool TestResult { get; set; } = false;
        public string Notes { get; set; } = null;
        public int CreatedByUserID { get; set; }

        private clsTestManagement()
        {
            _Mode = enMode.AddNew;

            TestID = null;
            TestAppointmentID = -1;
            TestResult = false;
            Notes = null;
            CreatedByUserID = -1;
        }

        private clsTestManagement(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            _Mode = enMode.Update;

            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.TestResult = TestResult;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
        }

        public static clsTestManagement Find(int TestID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = string.Empty;
            int CreatedByUserID = -1;

            if (clsTestsDataTier.FindTestInDB(TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTestManagement(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
                return new clsTestManagement();
        }

        public static bool IsTestPassed(int LocalDrivingLicenseID, clsTestTypesManagement.enTestMode TestMode) 
                         => clsTestsDataTier.GetLastTestResultWithLocalDrivingLicneseIdFromDB(LocalDrivingLicenseID, (short)TestMode);

        public static int NumberOfTestsTaken(int LocalAppID) => clsTestsDataTier.NumberOfTestPassesWithAppID(LocalAppID);

        public static int NumberOfTrailsForApplication(int AppID , clsTestTypesManagement.enTestMode TestMode) => clsTestsDataTier.NumberOfTrailsForTestWithAppID(AppID, (short)TestMode);

        private bool _AddNewTest()
        {
            TestID = clsTestsDataTier.AddNewTestToDB(TestAppointmentID, TestResult, Notes, CreatedByUserID);

            return (TestID != null);
        }

        private bool _UpdateTest() => clsTestsDataTier.UpdateTestInDB(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return _UpdateTest();
            }

            return false;
        }
    }
}
