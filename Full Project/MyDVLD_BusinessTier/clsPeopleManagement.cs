using MyDVLD_DataTier;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyDVLD_BusinessTier
{
    public class clsPeopleManagement
    {
        private enum _enPersonMode { AddNewPerson = 1, EditPerson = 2}
        private _enPersonMode _PersonMode { get; set; } = _enPersonMode.AddNewPerson;
        public int PersonID { get; set; } = -1;
        public string NationalNo { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string ThirdName { get; set; } = null;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public string Gender { get; set; } = string.Empty; // 0 = Male, 1 = Female
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = null;
        public int NationalityCountryID { get; set; } = -1;
        public string ImagePath { get; set; } = null;
        public string FullName { get { return FirstName + " " + SecondName + " " + ((string.IsNullOrEmpty(ThirdName))? string.Empty : (ThirdName + " ")) + LastName; }}  


        //public static bool operator == (clsPeopleManagement Person1 , clsPeopleManagement Person2)
        //{
        //    if (ReferenceEquals(Person1, Person2))
        //        return true;

        //    if (Person1 is null || Person2 is null)
        //        return false;

        //    return Person1.Equals(Person2);
        //}

        //public static bool operator !=(clsPeopleManagement Person1, clsPeopleManagement Person2)
        //{
        //    return !(Person1 == Person2);
        //}


        private clsPeopleManagement()
        {
            // Add New Person Constructor
            this._PersonMode = _enPersonMode.AddNewPerson;

            this.PersonID = -1;
            this.NationalNo = string.Empty;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = null;
            this.LastName = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.Gender = "Male";
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = null;
            this.NationalityCountryID = -1;
            this.ImagePath = null;
        }

        private clsPeopleManagement(int PersonId  , string NationalNo , string FirstName,
                                    string SecondName , string ThirdName,
                                    string LastName , DateTime DateOfBirth , string Gender, 
                                    string Address , string Phone, string Email ,
                                    int NationalityCountryID, string ImagePath)
        {
            _PersonMode = _enPersonMode.EditPerson;
                                                  
            PersonID = PersonId;                         
            this.NationalNo = NationalNo;            
            this.FirstName = FirstName;            
            this.SecondName = SecondName;            
            this.ThirdName = ThirdName ?? string.Empty;            
            this.LastName = LastName;               
            this.DateOfBirth = DateOfBirth;            
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email ?? string.Empty;
            this.NationalityCountryID = NationalityCountryID;
            this.ImagePath = ImagePath ?? string.Empty;
        }

        public static DataTable GetAllPeople() => clsPeopleManagmentDataTier.GetPeopleFromDataBase();

        [Obsolete("It Will Be Automatice Soon , Its Vuntrable.")]
        public static DataTable GetPeopleFiltered(string FilterBy, string FilterValue) => clsPeopleManagmentDataTier.GetPeopleFilteredFromDB(FilterBy, FilterValue);

        public static bool DeletePersonByID(int PersonID) => clsPeopleManagmentDataTier.DeletePersonByIdFromDatabase(PersonID);

        public static bool IsPersonExsists(string NationalNo) => clsPeopleManagmentDataTier.IsPersonExistInDB_ByNationalNumber(NationalNo);

        public static bool IsPersonExsists(int personId) => clsPeopleManagmentDataTier.IsPersonExistInDB_ById(personId);

        public static clsPeopleManagement Find(int PersonID)
        {
            string NationalNo = string.Empty;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = null;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            string Gender = "Male";
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = null;
            int NationalityCountryID = -1;
            string ImagePath = null;

            if (clsPeopleManagmentDataTier.GetPersonInfoById(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                                                           ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email,
                                                           ref NationalityCountryID, ref ImagePath))
            {
                return new clsPeopleManagement(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender,
                    Address, Phone, Email, NationalityCountryID, ImagePath);
            }

            return new clsPeopleManagement();
        }

        public static clsPeopleManagement Find(string PersonNationalNo)
        {
            int PersonID = -1;
            string FirstName = string.Empty;
            string SecondName = string.Empty;
            string ThirdName = null;
            string LastName = string.Empty;
            DateTime DateOfBirth = DateTime.Now;
            string Gender = "Male";
            string Address = string.Empty;
            string Phone = string.Empty;
            string Email = null;
            int NationalityCountryID = -1;
            string ImagePath = null;

            if (clsPeopleManagmentDataTier.GetPersonInfoByNastionalNumber(PersonNationalNo, ref PersonID, ref FirstName, ref SecondName,
                                                           ref ThirdName, ref LastName,ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email,
                                                           ref NationalityCountryID, ref ImagePath))
            {
                return new clsPeopleManagement(PersonID, PersonNationalNo, FirstName, SecondName, 
                                               ThirdName, LastName, DateOfBirth, Gender,
                                               Address, Phone, Email, NationalityCountryID, ImagePath);
            }

            return new clsPeopleManagement();
        }

        private bool _AddNewPerson()
        {
            PersonID = clsPeopleManagmentDataTier.AddPersonToDataBase(NationalNo, FirstName, SecondName, ThirdName, LastName,
                                                                  DateOfBirth, Convert.ToByte((Gender.ToLower().Trim() == "male") ? 0 : 1),
                                                                  Address, Phone, Email,NationalityCountryID, ImagePath);

            return PersonID != -1;
        }

        private bool _EditPerson() => clsPeopleManagmentDataTier.UpdatePersonWithIdInDataBase(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                                                                           DateOfBirth, Convert.ToByte((Gender.ToLower().Trim() == "male") ? 0 : 1),
                                                                           Address, Phone, Email, NationalityCountryID, ImagePath);

        public bool Save()
        {
            switch (_PersonMode)
            {
                case _enPersonMode.AddNewPerson:
                    if(_AddNewPerson())
                    {
                        _PersonMode = _enPersonMode.EditPerson;
                        return true;
                    }
                    else
                        return false;
                case _enPersonMode.EditPerson:
                        return _EditPerson();
            }

            return false;
        }
    }
}
