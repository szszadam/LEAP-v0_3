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
    // DB_Connection class
    //
    // Class description:
    //
    // This class is responsible for communicating with Microsoft SQL Server
    // and reading the records stored there when starting the program
    // and updating its display tables.
    //
    // Fields:
    //
    // DB_Path: string – Stores the path to the database file.
    // DB_Info: string – It contains the data required to connect to the SQL database.
    // StudentList: List<Student> - A user with the "Student" authorization level read from the database appears as an object of type "Student" during runtime, and this list contains a collection of objects of this type.
    // TeacherList: List<Teacher> - A user with the "Teacher" authorization level read from the database appears as an object of type "Teacher" during runtime, and this list contains a collection of objects of this type.
    // AdministratorList: List<Administrator> - A user with the "Administrator" authorization level read from the database appears as an object of type "Administrator" during runtime, and this list contains a collection of objects of this type.
    // MultipleChoiceTaskList: List<MultipleChoiceTask> - The „multiple-choice tasks” read from the database appear as "Multiple-Choice Task" objects during runtime, and this list contains a collection of objects of this type.
    // EssayTaskList: List<EssayTask> - The „essay tasks” read from the database appear as "Essay Task" objects during runtime, and this list contains a collection of objects of this type.
    // EditedTestSheetList: List<EditedTestSheet> - The „edited test sheets” read from the database appear as "Edited Test Sheet" objects during runtime, and this list contains a collection of objects of this type.
    // IndividualTestSheetList: List<IndividualTestSheet> - The „individual test sheets” read from the database appear as "Individual Test Sheet" objects during runtime, and this list contains a collection of objects of this type.
    //
    // Methods:
    //
    // ReadUserDataFromDatabase() – Reading and classifying user data stored in the Users table of the database according to their authorization level.Then, with the help of this data, the objects of "Administrator", "Teacher" and "Student" are created and placed in the corresponding list (AdministratorList, TeacherList, StudentList).
    // ReadTaskDataFromDatabase() – Reading and classifying the data of the tasks stored in the Tasks table of the database according to their type. Then, with the help of this data, the objects of the "Multiple-choice Task" and "Essay Task" types are created and placed in the corresponding list (MultipleChoiceTaskList, EssayTaskList).
    // ReadEditedTestSheetDataFromDatabase() – Reading the data of test sheets stored in the Edited Tasks table of the database and placing them in a list called EditedTasksList as an object of type Edited Tasks.
    // ReadIndividualTestSheetDataFromDatabase() – Reading the data of the individual test sheets stored in the Individual Test Sheets table of the database and set them in a list called IndividualTestSheetList as objects of type Individual Test Sheet.


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
