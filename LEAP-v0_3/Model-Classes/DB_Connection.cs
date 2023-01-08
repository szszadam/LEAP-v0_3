using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAP_v0_3
{
    /*seventh comment section*/
    static class DB_Connection
    {
        public static string DB_Path = Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName + "\\Database\\LEAP_DB.mdf";
        public static string DB_Info = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + DB_Path + ";Integrated Security=True;Connect Timeout=300;ConnectRetryCount=10;ConnectRetryInterval=5";

        public static List<Student> StudentList = new List<Student>();
        public static List<Teacher> TeacherList = new List<Teacher>();
        public static List<Administrator> AdministratorList = new List<Administrator>();
        public static List<MultipleChoiceTask> MultipleChoiceTaskList = new List<MultipleChoiceTask>();
        public static List<EssayTask> EssayTaskList = new List<EssayTask>();
        public static List<EditedTestSheet> EditedTestSheetList = new List<EditedTestSheet>();
        public static List<IndividualTestSheet> IndividualTestSheetList = new List<IndividualTestSheet>();

        public static void ReadUserDataFromDatabase()
        {
            StudentList.Clear();
            TeacherList.Clear();
            AdministratorList.Clear();
            try
            {
                using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Info))
                {
                    string queryingAdministrators = "SELECT * FROM Users WHERE AuthorizationLevel='A' OR AuthorizationLevel='a'";
                    string queryingTeachers = "SELECT * FROM Users WHERE AuthorizationLevel='T' OR AuthorizationLevel='t'";
                    string queryingStudents = "SELECT * FROM Users WHERE AuthorizationLevel='S' OR AuthorizationLevel='s'";
                    using (SqlCommand commandToLoadAdminData = new SqlCommand(queryingAdministrators, connectingToLEAP_DB))
                    {
                        connectingToLEAP_DB.Open();
                        SqlDataReader queryCommand = commandToLoadAdminData.ExecuteReader();
                        while (queryCommand.Read())
                        {
                            AdministratorList.Add(new Administrator(Convert.ToInt32(queryCommand["Id"]), Convert.ToString(queryCommand["FamilyName"]), Convert.ToString(queryCommand["FirstName"]), Convert.ToString(queryCommand["UserIdentificationNumber"]), Convert.ToString(queryCommand["PasswordHashCode"]), Convert.ToDateTime(queryCommand["RegistrationTime"]), Convert.ToString(queryCommand["AuthorizationLevel"]), Convert.ToString(queryCommand["SubjectsTaught"])));
                        }
                        connectingToLEAP_DB.Close();
                    }
                    using (SqlCommand commandToLoadTeacherData = new SqlCommand(queryingTeachers, connectingToLEAP_DB))
                    {
                        connectingToLEAP_DB.Open();
                        SqlDataReader queryCommand = commandToLoadTeacherData.ExecuteReader();
                        while (queryCommand.Read())
                        {
                            TeacherList.Add(new Teacher(Convert.ToInt32(queryCommand["Id"]), Convert.ToString(queryCommand["FamilyName"]), Convert.ToString(queryCommand["FirstName"]), Convert.ToString(queryCommand["UserIdentificationNumber"]), Convert.ToString(queryCommand["PasswordHashCode"]), Convert.ToDateTime(queryCommand["RegistrationTime"]), Convert.ToString(queryCommand["AuthorizationLevel"]), Convert.ToString(queryCommand["SubjectsTaught"])));
                        }
                        connectingToLEAP_DB.Close();
                    }
                    using (SqlCommand commandToLoadStudentData = new SqlCommand(queryingStudents, connectingToLEAP_DB))
                    {
                        connectingToLEAP_DB.Open();
                        SqlDataReader queryCommand = commandToLoadStudentData.ExecuteReader();
                        while (queryCommand.Read())
                        {
                            int __grade;
                            if (queryCommand["Grade"] is DBNull) __grade = 0;
                            else __grade = Convert.ToInt32(queryCommand["Grade"]);
                            StudentList.Add(new Student(Convert.ToInt32(queryCommand["Id"]), Convert.ToString(queryCommand["FamilyName"]), Convert.ToString(queryCommand["FirstName"]), Convert.ToString(queryCommand["UserIdentificationNumber"]), Convert.ToString(queryCommand["PasswordHashCode"]), Convert.ToDateTime(queryCommand["RegistrationTime"]), Convert.ToString(queryCommand["AuthorizationLevel"]), __grade, Convert.ToString(queryCommand["Class"])));
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while reading the \"users\" data!", "Error!", MessageBoxButtons.OK);
            }
        }
        public static void ReadTaskDataFromDatabase()
        {
            MultipleChoiceTaskList.Clear();
            EssayTaskList.Clear();
            try
            {
                using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Info))
                {
                    string queryingMultipleChoiceTaskData = "SELECT * FROM Tasks WHERE TaskType='MultipleChoice' OR TaskType='multiplechoice'";
                    string queryingEssayTaskData = "SELECT * FROM Tasks WHERE TaskType='Essay' OR TaskType='essay'";
                    using (SqlCommand commandToLoadMultipleChoiceTasks = new SqlCommand(queryingMultipleChoiceTaskData, connectingToLEAP_DB))
                    {
                        connectingToLEAP_DB.Open();
                        SqlDataReader queryCommand = commandToLoadMultipleChoiceTasks.ExecuteReader();
                        while (queryCommand.Read())
                        {
                            MultipleChoiceTaskList.Add(new MultipleChoiceTask(Convert.ToInt32(queryCommand["Id"]), Convert.ToString(queryCommand["Subject"]), Convert.ToString(queryCommand["TaskFormulation"]), Convert.ToString(queryCommand["TaskType"]), Convert.ToInt32(queryCommand["PointValue"]), Convert.ToBoolean(queryCommand["LockedTask"]), Convert.ToString(queryCommand["Attributes"])));
                        }
                        connectingToLEAP_DB.Close();
                    }
                    using (SqlCommand commandToLoadEssayTasks = new SqlCommand(queryingEssayTaskData, connectingToLEAP_DB))
                    {
                        connectingToLEAP_DB.Open();
                        SqlDataReader queryCommand = commandToLoadEssayTasks.ExecuteReader();
                        while (queryCommand.Read())
                        {
                            EssayTaskList.Add(new EssayTask(Convert.ToInt32(queryCommand["Id"]), Convert.ToString(queryCommand["Subject"]), Convert.ToString(queryCommand["TaskFormulation"]), Convert.ToString(queryCommand["TaskType"]), Convert.ToInt32(queryCommand["PointValue"]), Convert.ToBoolean(queryCommand["LockedTask"]), Convert.ToString(queryCommand["Attributes"])));
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while reading the \"tasks\" data!", "Error!", MessageBoxButtons.OK);
            }
        }
        public static void ReadEditedTestSheetDataFromDatabase()
        {
            EditedTestSheetList.Clear();
            try
            {
                using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Info))
                {
                    string queryingEditedTestSheetData = "SELECT * FROM EditedTestSheets";
                    using (SqlCommand commandToLoadEditedTestSheets = new SqlCommand(queryingEditedTestSheetData, connectingToLEAP_DB))
                    {
                        connectingToLEAP_DB.Open();
                        SqlDataReader queryCommand = commandToLoadEditedTestSheets.ExecuteReader();
                        while (queryCommand.Read())
                        {
                            EditedTestSheetList.Add(new EditedTestSheet(Convert.ToInt32(queryCommand["Id"]), Convert.ToString(queryCommand["Subject"]), Convert.ToString(queryCommand["Topic"]), Convert.ToInt32(queryCommand["AvailableTime"]), Convert.ToInt32(queryCommand["Grade"]), Convert.ToInt32(queryCommand["TotalPointsAvailable"]), Convert.ToBoolean(queryCommand["LockedTestSheet"]), Convert.ToDateTime(queryCommand["CreationDate"]), Convert.ToString(queryCommand["Tasks"])));
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while reading the \"edited test sheets\" data!", "Error!", MessageBoxButtons.OK);
            }
        }
        public static void ReadIndividualTestSheetDataFromDatabase()
        {
            IndividualTestSheetList.Clear();
            try
            {
                using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Info))
                {
                    string queryingIndividualTestSheetData = "SELECT * FROM IndividualTestSheets";
                    using (SqlCommand commandToLoadIndividualTestSheets = new SqlCommand(queryingIndividualTestSheetData, connectingToLEAP_DB))
                    {
                        connectingToLEAP_DB.Open();
                        SqlDataReader queryCommand = commandToLoadIndividualTestSheets.ExecuteReader();
                        while (queryCommand.Read())
                        {
                            string __EssayTaskAnswers;
                            if (queryCommand["EssayTaskAnswers"] is DBNull) __EssayTaskAnswers = "";
                            else __EssayTaskAnswers = Convert.ToString(queryCommand["EssayTaskAnswers"]);

                            DateTime __testSheetStartTime;
                            if (DateTime.TryParse(Convert.ToString(queryCommand["TestSheetStartTime"]), out __testSheetStartTime)) ;
                            else __testSheetStartTime = new DateTime(2022, 01, 01, 0, 00, 00);

                            DateTime __testSheetSubmitTime;
                            if (DateTime.TryParse(Convert.ToString(queryCommand["TestSheetSubmitTime"]), out __testSheetSubmitTime)) ;
                            else __testSheetSubmitTime = new DateTime(2022, 01, 01, 0, 00, 00);

                            IndividualTestSheetList.Add(new IndividualTestSheet(Convert.ToInt32(queryCommand["Id"]), Convert.ToInt32(queryCommand["EditedTestSheetID"]), Convert.ToInt32(queryCommand["UserID"]), Convert.ToString(queryCommand["PointsEarned"]), __testSheetStartTime, __testSheetSubmitTime, Convert.ToBoolean(queryCommand["SentOutTestSheet"]), Convert.ToBoolean(queryCommand["SubmittedTestSheet"]), Convert.ToBoolean(queryCommand["CheckedTestSheet"]), Convert.ToString(queryCommand["AnswerMarkingsTable"]), __EssayTaskAnswers, Convert.ToString(queryCommand["KeywordFulfillmentTable"])));
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while reading the \"individual test sheets\" data!", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
