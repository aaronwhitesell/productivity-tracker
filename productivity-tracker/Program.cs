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
            return timespan.Hour.ToString("00") + ":" + timespan.Minute.ToString("00");
        }
    }
}
