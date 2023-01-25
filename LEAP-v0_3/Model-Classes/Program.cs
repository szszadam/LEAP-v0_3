using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAP_v0_3
{
    //      *****Program class*****
    //
    //      ***Methods***
    //
    // Main() – The program's entry point. Make settings for the further running of the program
    // and for the graphical display. It calls the ReadDataFromDatabase() method found inside
    // the class, and opens an instance of "SignInWindow" where the user’s interactions will begin.
    //
    // ReadDataFromDatabase() – Calling the methods found in the "DB_Connection" class for
    // reading data from the SQL database.

    static class Program
    {
        public static void ReadDataFromDatabase()
        {
            DB_Connection.ReadUserDataFromDatabase();
            DB_Connection.ReadTaskDataFromDatabase();
            DB_Connection.ReadEditedTestSheetDataFromDatabase();
            DB_Connection.ReadIndividualTestSheetDataFromDatabase();
        }
        [STAThread]
        static void Main()
        {
            /*First comment section*/
            
            ReadDataFromDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SingInWindow());
            /*Second comment section*/
        }
    }
}
