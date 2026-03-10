using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDVLD_DataTier;

namespace MyDVLD_BusinessTier
{
    public class clsUsersManagement
    {
        public enum UserMode { AddNew , Update }
        public UserMode Mode { get; private set; } = UserMode.AddNew;


        public clsPeopleManagement PerosnInfo { get; set; } = clsPeopleManagement.Find(-1);
        public int UserID { get; private set; } = -1;
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        private clsUsersManagement()
        {
            Mode = UserMode.AddNew;

            PerosnInfo = clsPeopleManagement.Find(-1);
            UserID = -1;
            Username = string.Empty;
            Password = string.Empty;
            IsActive = false;
        }

        private clsUsersManagement(int UserID , int PersonID, string Username ,string Password , bool IsUserActive)
        {
            Mode = UserMode.Update;

            this.PerosnInfo = clsPeopleManagement.Find(PersonID);
            this.UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsUserActive;
        }

        public static DataTable GetSystemUsers() => clsUsersManagmentDataTier.GetAllUsersFromDB();

        [Obsolete("It Will Be Automatic Soon , From The DataGrid Veiw!!")]
        public static DataTable GetSystemUsersFilltered(string FillterColumn , string FillterValue) => clsUsersManagmentDataTier.GetFillteredUsersFromDB(FillterColumn, FillterValue);

        public static clsUsersManagement Find(int UserId)
        {
            int PersonID = -1;
            string Username = string.Empty;
            string Password = string.Empty;
            bool IsUserActive = false;

            if (clsUsersManagmentDataTier.GetUserInfoFromDB(UserId, ref PersonID, ref Username, ref Password, ref IsUserActive))
            {
                return new clsUsersManagement(UserId, PersonID, Username, Password, IsUserActive);
            }
            else
                return new clsUsersManagement();
        }

        public static clsUsersManagement Find(string Username , string Password)
        {
            int PersonID = -1;
            int UserID = -1;
            string DefineUsername = string.Empty;
            string DefinePassword = string.Empty;
            bool IsUserActive = false;

            if (clsUsersManagmentDataTier.GetUserInfoFromDB(Username, clsUtil.clsSecurity.HashPassword(Password), ref PersonID, ref UserID, ref IsUserActive))
            {
                return new clsUsersManagement(UserID, PersonID, Username, Password, IsUserActive);
            }
            else
                return new clsUsersManagement();
        }

        public static bool IsUserExists(int PersonId) => clsUsersManagmentDataTier.IsUserExistsInDB(PersonId);

        public static bool IsUserExists(string Username)=> clsUsersManagmentDataTier.IsUserExistsInDB(Username);

        public static bool DeleteUser(int UserID) => clsUsersManagmentDataTier.DeleteUserFromDB(UserID);

        private bool _AddNewUser()
        {
            UserID = clsUsersManagmentDataTier.AddNewUserToDB(PerosnInfo.PersonID , Username , clsUtil.clsSecurity.HashPassword(Password), IsActive);
            
            return UserID != -1;
        }

        private bool _UpdateUser() => clsUsersManagmentDataTier.UpdateUserInDB(UserID, Username, clsUtil.clsSecurity.HashPassword(Password), IsActive);

        public bool Save()
        {
            switch (Mode)
            {
                case UserMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = UserMode.Update;
                        return true;
                    }
                    else
                        return false;
                case UserMode.Update:
                    return _UpdateUser();
            }

            return false;
        }
    }
}
