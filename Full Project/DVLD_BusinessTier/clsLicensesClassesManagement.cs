using MyDVLD_DataTier;
using System.Collections.Generic;

namespace MyDVLD_BusinessTier
{
    public class clsLicensesClassesManagement
    {
        public int ClassID { get; }
        public string ClassName { get; }
        public string ClassDescription { get; }
        public short MinimumAllowedAge { get; }
        public short DefaultValidityLength { get; }
        public int ClassFees { get; }

        private clsLicensesClassesManagement(int LicencesClasseID,string ClassName,string ClassDescription
                                            ,short MinimumAllowedAge,short DefaultValidityLength
                                            ,int ClassFees)
        {
            this.ClassID = LicencesClasseID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
            this.MinimumAllowedAge = MinimumAllowedAge;
        }

        private clsLicensesClassesManagement()
        {
            this.ClassID = -1;
            this.ClassName = string.Empty;
            this.ClassDescription = string.Empty;
            this.DefaultValidityLength = -1;
            this.ClassFees = -1;
            this.MinimumAllowedAge = -1;
        }

        public static List<string> AllALicencesClasses() => clsLicensesClassesDataTier.GetAllLicencesClasseNames();

        public static clsLicensesClassesManagement Find(int LicencesClasseID)
        {
            string ClassName = string.Empty;
            string ClassDescription = string.Empty;
            short MinimumAllowedAge = 18;
            short DefaultValidityLength = 10;
            int ClassFees = -1;

            if (clsLicensesClassesDataTier.GetLicenseInfoByID(LicencesClasseID, ref ClassName, ref ClassDescription
                                                            , ref MinimumAllowedAge, ref DefaultValidityLength
                                                            , ref ClassFees))
            {
                return new clsLicensesClassesManagement(LicencesClasseID , ClassName , ClassDescription , 
                                                        MinimumAllowedAge , DefaultValidityLength , ClassFees);
            }
            else
                return new clsLicensesClassesManagement();
        }
    }
}
