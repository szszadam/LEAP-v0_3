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
    static class Program
    {

        /*first side dev comment section*/
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
            ReadDataFromDatabase();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SingInWindow());
        }
    }
}
