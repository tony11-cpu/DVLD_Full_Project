using System;
using System.Configuration;


namespace MyDVLD_DataTier
{
    public partial class clsDB_Util
    {
        /// <summary>
        /// Connection String Connects With DataBase...
        /// </summary>
        internal static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["SQLConnectionString"].ConnectionString ?? string.Empty;
    }
}
