using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clinic2018
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

            Application.Run(new clinic_pharmacist_service());
            //Application.Run(new clinc_nurse_service());
            //Application.Run(new clinic_search());
            //Application.Run(new clinic_calendar());
            //Application.Run(new clinic_test_1()); 
            //Application.Run(new clinic_login()); 

        }
    }
}
