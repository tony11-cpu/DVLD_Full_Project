using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDVLD_DataTier
{
    public partial class clsDB_Util
    {
        public static class clsEventLog
        {
            private static readonly string _EventLogName = "Application";
            private static readonly string _Source = "DVLD_PROJECT";

            /// <summary>
            /// Log Event To Windows Event Viewer
            /// </summary>
            /// <param name="Message">Message You Want To Log</param>
            /// <param name="Type">Type Of Event (Error , Warning , Info)</param>
            public static void LogEvent(string Message, EventLogEntryType Type)
            {
                if (!EventLog.SourceExists(_Source))
                    EventLog.CreateEventSource(_Source, _EventLogName);

                EventLog.WriteEntry(_Source, Message, Type);
            }
        }
    }
}
