using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productivity_tracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormProductivityTracker());
        }

        static public string ToString(DateTime timespan)
        {
            // Argument is of type DateTime, because the DateTimePicker control was used to enter the duration. This
            // is a convenient way to enter a timespan in HH:MM format, but the max duration is 23:59.
            return timespan.Hour.ToString("00") + ":" + timespan.Minute.ToString("00");
        }

        static public string ToString(TimeSpan timespan)
        {
            // Argument is of type TimeSpan, because durations are timespans. The SQL queries will return the aggregate
            // of the durations which are regularly greater than 23:59.
            return timespan.Days.ToString("00") + ":" + timespan.Hours.ToString("00") + ":" + timespan.Minutes.ToString("00");
        }
    }
}
