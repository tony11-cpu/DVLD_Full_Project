using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_BusinessTier
{
    public partial class clsUtil 
    {
        public static clsUsersManagement SignedInUser = clsUsersManagement.Find(-1);
    }
}
