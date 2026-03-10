using MyDVLD_DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_BusinessTier
{
    public class clsTestTypesManagement
    {
        public enum enTestTypeMode : byte { AddNewType , UpdateType }
        private enTestTypeMode _Mode = enTestTypeMode.AddNewType;

        public enum enTestMode : Byte { VisionTest = 1 , WrittenTest = 2 , PracticalTest = 3 }
        public enTestMode TestType { get; set; } = enTestMode.VisionTest;
        public string TestTitle { get; set; }
        public string TestDescription { get; set; }
        public float TestTypeFees { get; set; }

        protected clsTestTypesManagement()
        {
            _Mode = enTestTypeMode.AddNewType;

            TestType = enTestMode.VisionTest;
            TestTitle = null;
            TestDescription = null;
            TestTypeFees = default;
        }

        public clsTestTypesManagement(enTestMode testID , string Testtittle , string Testdescription , float TestTypeFees)
        {
            _Mode = enTestTypeMode.UpdateType;

            this.TestType = testID;
            this.TestTitle = Testtittle;
            this.TestDescription = Testdescription;
            this.TestTypeFees = TestTypeFees;
        }

        public static DataTable GetAllTestTypes() => clsTestTypesDataTier.GetAllTestTypes();

        private bool _UpdateTestType() => clsTestTypesDataTier.UpdateTestTypes(Convert.ToInt32(TestType), TestTitle, TestDescription, TestTypeFees);

        public static clsTestTypesManagement Find(int TypeID)
        {
            string Title = null;
            string Description = null;
            float Fees = default(float);

            if (clsTestTypesDataTier.GetTestTypeByID(TypeID, ref Title, ref Description, ref Fees))
                return new clsTestTypesManagement((enTestMode)TypeID, Title, Description, Fees);
            else
                return new clsTestTypesManagement();
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enTestTypeMode.UpdateType:
                   return _UpdateTestType();
                case enTestTypeMode.AddNewType:
                    // Under Dev..
                    _Mode = enTestTypeMode.UpdateType;
                    return false;
            }

            return false;
        }
    }
}
