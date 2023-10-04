using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAP_v0_3
{
    //      ***** User Management Selector User Control Class *****
    //
    //
    //      *** Class description ***
    //
    //
    // This class is a descendant of the "UserControl" class and it is for reviewing, selecting and modifying
    // registered users' data. Furthermore, it provides access to the registration window, where the
    // administrator can register a new user. The main elements of its graphical interface: the
    // "DataGridView" list for user selection, the "Create new user account" button, the "Modify user’s data"
    // button, and the "Delete user account" button.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // UserManagementSelectorUC_Load() event handler - When the User Management Selector User Control is
    // loaded, it calls the FillUserSelectorDGV() method.
    //
    //
    // FillUserSelectorDGV() – This method fills the "DataGridView"with data listing registered users. The
    // method uses some auxiliary variables during its runtime, and in addition to these, it also uses the
    // method named "ConvertTaughtSubjectsToString_Comma()".
    //
    //
    // ConvertTaughtSubjectsToString_Comma() – if the current user is an administrator or a teacher, her/his
    // taught subjects are displayed in the “Taught subjects” column of the "DataGridView", separated by
    // commas. This comma separation and concatenation into a text is done by this method.
    //
    //
    // CreateNewUserButton_Click() event handler – By clicking on the "Create new user account" button, it
    // creates a new instance of the "UserDataInputWindow" class and opens it in a new window in “new user
    // registration” mode.
    //
    //
    // UserDataModificationButton_Click() event handler - By clicking on the "Modify user’s data" button, it
    // creates a new instance of the "UserDataInputWindow" class and opens it in a new window in “data
    // modification” mode,  with text fields filled with the data of the user selected in the "DataGridView"
    // list.
    //
    //
    // DeleteUserButton_Click() event handler –  after an approval, it deletes the user selected in the
    // "DataGridView" list. The user will be deleted from the "Users" table and the individual test sheets
    // belonging to this user will be also deleted from the "IndividualTestSheets" table of the LEAP
    // database. At the end of the process, it calls the Program.ReadDataFromDatabase() method and the
    // FillUserSelectorDGV() method.


    public partial class UserManagementSelectorUC : UserControl
    {
        public UserManagementSelectorUC()
        {
            InitializeComponent();
        }
        private void UserManagementSelectorUC_Load(object sender, EventArgs e)
        {
            FillUserSelectorDGV();
        }
        private void FillUserSelectorDGV()
        {
            int userID_Auxiliary;
            string familyName_Auxiliary;
            string firstName_Auxiliary;
            string userIdentificationNumber_Auxiliary;
            string authorizationLevel_Auxiliary;
            List<string> subjectsTaughtList_Auxiliary;
            string subjectsTaughtString_Auxiliary;
            int grade_Auxiliary;
            string class_Auxiliary;
            DateTime registrationDate_Auxiliary;

            UserSelectorDGV.Rows.Clear();
            for (int i = 0; i < DB_Connection.AdministratorList.Count; i++)
            {
                Administrator CurrentUser = DB_Connection.AdministratorList[i];
                userID_Auxiliary = CurrentUser.SQL_ID;
                familyName_Auxiliary = CurrentUser.FamilyName;
                firstName_Auxiliary = CurrentUser.FirstName;
                userIdentificationNumber_Auxiliary = CurrentUser.UserIdentificationNumber;
                authorizationLevel_Auxiliary = "Administrator";
                subjectsTaughtList_Auxiliary = CurrentUser.SubjectsTaughtList;
                ConvertTaughtSubjectsToString_Comma(subjectsTaughtList_Auxiliary, out subjectsTaughtString_Auxiliary);
                registrationDate_Auxiliary = CurrentUser.RegistrationTime;
                UserSelectorDGV.Rows.Add(userID_Auxiliary, familyName_Auxiliary, firstName_Auxiliary, userIdentificationNumber_Auxiliary, authorizationLevel_Auxiliary, subjectsTaughtString_Auxiliary, null, null, registrationDate_Auxiliary);
            }
            for (int i = 0; i < DB_Connection.TeacherList.Count; i++)
            {
                Teacher CurrentUser = DB_Connection.TeacherList[i];
                userID_Auxiliary = CurrentUser.SQL_ID;
                familyName_Auxiliary = CurrentUser.FamilyName;
                firstName_Auxiliary = CurrentUser.FirstName;
                userIdentificationNumber_Auxiliary = CurrentUser.UserIdentificationNumber;
                authorizationLevel_Auxiliary = "Teacher";
                subjectsTaughtList_Auxiliary = CurrentUser.SubjectsTaughtList;
                ConvertTaughtSubjectsToString_Comma(subjectsTaughtList_Auxiliary, out subjectsTaughtString_Auxiliary);
                registrationDate_Auxiliary = CurrentUser.RegistrationTime;
                UserSelectorDGV.Rows.Add(userID_Auxiliary, familyName_Auxiliary, firstName_Auxiliary, userIdentificationNumber_Auxiliary, authorizationLevel_Auxiliary, subjectsTaughtString_Auxiliary, null, null, registrationDate_Auxiliary);
            }
            for (int i = 0; i < DB_Connection.StudentList.Count; i++)
            {
                Student CurrentUser = DB_Connection.StudentList[i];
                userID_Auxiliary = CurrentUser.SQL_ID;
                familyName_Auxiliary = CurrentUser.FamilyName;
                firstName_Auxiliary = CurrentUser.FirstName;
                userIdentificationNumber_Auxiliary = CurrentUser.UserIdentificationNumber;
                authorizationLevel_Auxiliary = "Student";
                grade_Auxiliary = CurrentUser.Grade;
                class_Auxiliary = CurrentUser.Class;
                registrationDate_Auxiliary = CurrentUser.RegistrationTime;
                UserSelectorDGV.Rows.Add(userID_Auxiliary, familyName_Auxiliary, firstName_Auxiliary, userIdentificationNumber_Auxiliary, authorizationLevel_Auxiliary, null, grade_Auxiliary, class_Auxiliary, registrationDate_Auxiliary);
            }
            UserSelectorDGV.Sort(UserSelectorDGV.Columns[1], ListSortDirection.Ascending);
        }
        private void ConvertTaughtSubjectsToString_Comma(List<string> __subjectsTaughtList, out string __subjectsTaughtString)
        {
            __subjectsTaughtString = "";
            for (int i = 0; i < __subjectsTaughtList.Count; i++)
            {
                __subjectsTaughtString += __subjectsTaughtList[i];
                if ((i + 1) != __subjectsTaughtList.Count)
                {
                    __subjectsTaughtString += ", ";
                }
            }
        }
        public void RefreshTableButton_Click(object sender, EventArgs e)
        {
            FillUserSelectorDGV();
        }
        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            UserDataInputWindow newUserRegistrationWindow1 = new UserDataInputWindow();
            newUserRegistrationWindow1.ShowDialog();
        }
        private void UserDataModificationButton_Click(object sender, EventArgs e)
        {
            if (UserSelectorDGV.Rows.Count!=0)
            {
                int selectedID = Convert.ToInt32(UserSelectorDGV.CurrentRow.Cells["UserID"].Value);
                string selectedFamilyName = Convert.ToString(UserSelectorDGV.CurrentRow.Cells["FamilyName"].Value);
                string selectedFirstName = Convert.ToString(UserSelectorDGV.CurrentRow.Cells["FirstName"].Value);
                string selectedAuthorizationLevel = Convert.ToString(UserSelectorDGV.CurrentRow.Cells["AuthorizationLevel"].Value);
                string selectedSubjectsTaught = Convert.ToString(UserSelectorDGV.CurrentRow.Cells["SubjectsTaught"].Value);
                int selectedGrade = Convert.ToInt32(UserSelectorDGV.CurrentRow.Cells["Grade"].Value);
                string selectedClass = Convert.ToString(UserSelectorDGV.CurrentRow.Cells["Class"].Value);
                UserDataInputWindow userDataModificationWindow1 = new UserDataInputWindow(selectedID, selectedFamilyName, selectedFirstName, selectedAuthorizationLevel, selectedSubjectsTaught, selectedGrade, selectedClass);
                userDataModificationWindow1.ShowDialog(); 
            }
        }
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (UserSelectorDGV.Rows.Count!=0)
            {
                int selectedUserID = Convert.ToInt32(UserSelectorDGV.CurrentRow.Cells["UserID"].Value);
                if (MessageBox.Show("Warning!\nDeleting a user causes deleting the \"individual test sheets\" belonging to the user!\nAre you sure to delete the selected user? ", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                        {
                            string DeleteUserFromLEAP_DB = "DELETE FROM Users WHERE Id=@idData";
                            string DeleteIndividualTestSheetFromLEAP_DB = "DELETE FROM IndividualTestSheets WHERE UserID=@idData";
                            using (SqlCommand commandToDeleteUserFromLEAP_DB = new SqlCommand(DeleteUserFromLEAP_DB, connectingToLEAP_DB))
                            {
                                commandToDeleteUserFromLEAP_DB.Parameters.AddWithValue("@idData", selectedUserID);
                                connectingToLEAP_DB.Open();
                                commandToDeleteUserFromLEAP_DB.ExecuteNonQuery();
                                connectingToLEAP_DB.Close();
                            }
                            using (SqlCommand commandToDeleteIndividualTestSheetFromLEAP_DB = new SqlCommand(DeleteIndividualTestSheetFromLEAP_DB, connectingToLEAP_DB))
                            {
                                commandToDeleteIndividualTestSheetFromLEAP_DB.Parameters.AddWithValue("@idData", selectedUserID);
                                connectingToLEAP_DB.Open();
                                commandToDeleteIndividualTestSheetFromLEAP_DB.ExecuteNonQuery();
                                MessageBox.Show("The user and \"individual test sheets\" belonging to the user have been successfully deleted!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Connection failed", "Error");
                    }
                    Program.ReadDataFromDatabase();
                    FillUserSelectorDGV();
                } 
            }
        }

        
    }
}
