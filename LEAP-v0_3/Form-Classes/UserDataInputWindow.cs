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
    //      ***** User Data Input Window Class *****
    //
    //
    //      *** Class description ***
    //
    //
    // This class is a descendant of the "Form" class, and it is used when registering a new user or changing
    // data of an existing user.The main elements of its graphic interface are the following: last name text
    // field, first name text field, authorization level drop-down list.Furthermore, there is a text field
    // for the taught subjects, a year drop-down list, a class drop-down list.These last three items become
    // available depending on the authorization level set by the administrator. There are two further buttons
    // on this graphic  interface. During registration of a new user, the "New user registration" button
    // appears.During changing data of an existing user, the "Change user data" button appears.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // Further_Initializations() – the method populates the dropdown lists with the appropriate values.
    //
    //
    // UserRegistrationButton_Click()–   when the "New user registration" button is clicked a new user is
    // created in the "Users" table of the LEAP database, based on the data entered in the various text
    // fields and the data selected from the drop-down lists.
    // By using the UserIdentification.UserIdentificationNumberGenerator() method, it will generate a “user
    // identification number” for the new user(and it will be also her/his first password). But the character
    // string of the “user identification number” also has to contain the database ID(see the
    // UserIdentificationNumberGenerator method of the UserIdentification class).  However,  because of the
    // fact that there is no database ID before the registration of the new user, the proper way to make the
    // new user searchable at first time in the database is giving her/him a temporary, unique “user
    // identification number”. This early “user identification number” will be a random generated number
    // temporarily.This termporary "user identification number" will be overwritten after first re-reading
    // the data from the database, when the new user will already have a database ID.So, by using this
    // database ID, the method can already generate the new “user identification number” and the new first
    // password in the LEAP application.
    //
    //
    // UserDataModificationButton_Click() event handler – by clicking on the "Modify user data" button, the
    // modified data from the text fields and drop-down lists will be uploaded to the proper row of the
    // "Users" table in the LEAP database. Basically these text fields are filled with the original data of
    // the selected user, but the administrator can modify them.
    //
    //
    // ConvertTaughtSubjectsToString_UnitSeparator() – for the time of uploading data to the LEAP database,
    // if the user whose data is registered or changed is a teacher or administrator, then this method
    // generates a one-line string text from the taught subjects entered in the taught subjects text field,
    // (separated by commas,). In the database the subjects will be separated from each other by the „unit
    // separator” character '▼'.
    //
    //
    // UppercaseInitial() – this method capitalize the initial letter of the taught subject’s names when
    // listing into the DataGridView.
    //
    //
    // AuthorizationLevelComboBox_SelectedIndexChanged()–   this method runs when the authorization level
    // dropdown list is selected. As a result,  on the graphic interface the taught subjects, the grade and
    // the class fields will appear or disappear.It depends on what is the selected authorization level
    // (administrator, teacher or student).


    public partial class UserDataInputWindow : Form
    {
        int UserID_Auxiliary;
        public UserDataInputWindow()
        {
            InitializeComponent();
            Further_Initializations();
            UserRegistrationButton.Enabled = true;
            UserRegistrationButton.Show();
            UserDataModificationButton.Enabled = false;
            UserDataModificationButton.Hide();
        }
        public UserDataInputWindow(int __id, string __familyName, string __firstName, string __authorizationLevel, string __subjectsTaught, int __grade, string __class)
        {
            InitializeComponent();
            Further_Initializations();
            UserRegistrationButton.Enabled = false;
            UserRegistrationButton.Hide();
            UserDataModificationButton.Enabled = true;
            UserDataModificationButton.Show();

            UserID_Auxiliary = __id;
            FamilyNameTextBox.Text = __familyName;
            FirstNameTextBox.Text = __firstName;
            AuthorizationLevelComboBox.Text = __authorizationLevel;
            SubjectsTaughtTextBox.Text = __subjectsTaught;
            GradeComboBox.Text = __grade.ToString();
            ClassComboBox.Text = __class;
            AuthorizationLevelComboBox_SelectedIndexChanged(this, EventArgs.Empty);
        }
        private void Further_Initializations()
        {
            UserDataModificationButton.Enabled = false;
            UserDataModificationButton.Hide();
            AuthorizationLevelComboBox.Items.Add("Administrator");
            AuthorizationLevelComboBox.Items.Add("Teacher");
            AuthorizationLevelComboBox.Items.Add("Student");
            for (int i = 9; i <= 14; i++)
            {
                GradeComboBox.Items.Add(i);
            }
            for (int i = 65; i <= 74; i++)
            {
                ClassComboBox.Items.Add((char)i);
            }
            SubjectsTaughtTextBox.Enabled = false;
            GradeComboBox.Enabled = false;
            ClassComboBox.Enabled = false;
        }
        private void UserRegistrationButton_Click(object sender, EventArgs e)
        {
            if ((FamilyNameTextBox.Text.Length > 0) && (FirstNameTextBox.Text.Length > 0) && ((AuthorizationLevelComboBox.SelectedItem != null) && ((SubjectsTaughtTextBox.Text.Length > 0) || ((GradeComboBox.SelectedItem != null) && (ClassComboBox.SelectedItem != null)))))
            {
                Random rnd = new Random();
                int initialUserIdentificationNumberInt_Auxiliary = rnd.Next(11111111, 99999999);

                string familyName_Auxiliary = FamilyNameTextBox.Text;
                string firstName_Auxiliary = FirstNameTextBox.Text;
                string initialUserIdentificationNumberString_Auxiliary = Convert.ToString(initialUserIdentificationNumberInt_Auxiliary);
                char authorizationLevel_Auxiliary;
                if (AuthorizationLevelComboBox.SelectedItem.ToString() == "Administrator")
                {
                    authorizationLevel_Auxiliary = 'A';
                }
                else if (AuthorizationLevelComboBox.SelectedItem.ToString() == "Teacher")
                {
                    authorizationLevel_Auxiliary = 'T';
                }
                else
                {
                    authorizationLevel_Auxiliary = 'S';
                }
                string initialPasswordHashCode_Auxiliary = "";
                string subjectsTaughtString_Auxiliary;
                ConvertTaughtSubjectsToString_UnitSeparator(SubjectsTaughtTextBox.Text, out subjectsTaughtString_Auxiliary);
                int grade_Auxiliary = Convert.ToInt32(GradeComboBox.SelectedItem);
                string Class_Auxiliary = ClassComboBox.Text;
                DateTime registrationDate_Auxiliary = System.DateTime.Now;
                try
                {
                    using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                    {
                        string UploadUserData = "INSERT INTO Users (FamilyName, FirstName, UserIdentificationNumber, AuthorizationLevel, PasswordHashCode, SubjectsTaught, Grade, Class, RegistrationTime) VALUES (@familyNameData, @firstNameData, @userIdentificationNumberData, @authorizationLevelData, @passwordHashCodeData, @subjectsTaughtData, @gradeData, @classData, @registrationDateData)";
                        using (SqlCommand commandToUploadUserData = new SqlCommand(UploadUserData, connectingToLEAP_DB))
                        {
                            commandToUploadUserData.Parameters.AddWithValue("@familyNameData", familyName_Auxiliary);
                            commandToUploadUserData.Parameters.AddWithValue("@firstNameData", firstName_Auxiliary);
                            commandToUploadUserData.Parameters.AddWithValue("@userIdentificationNumberData", initialUserIdentificationNumberString_Auxiliary);
                            commandToUploadUserData.Parameters.AddWithValue("@authorizationLevelData", authorizationLevel_Auxiliary);
                            commandToUploadUserData.Parameters.AddWithValue("@passwordHashCodeData", initialPasswordHashCode_Auxiliary);
                            commandToUploadUserData.Parameters.AddWithValue("@subjectsTaughtData", subjectsTaughtString_Auxiliary);
                            commandToUploadUserData.Parameters.AddWithValue("@gradeData", grade_Auxiliary);
                            commandToUploadUserData.Parameters.AddWithValue("@classData", Class_Auxiliary);
                            commandToUploadUserData.Parameters.AddWithValue("@registrationDateData", registrationDate_Auxiliary.ToString("yyyy/MM/dd HH:mm:ss"));
                            connectingToLEAP_DB.Open();
                            commandToUploadUserData.ExecuteNonQuery();
                        }
                    }
                    Program.ReadDataFromDatabase();
                    int SQL_ID_Auxiliary;
                    User CurrentUser_Auxiliary;
                    if (authorizationLevel_Auxiliary == 'A')
                    {
                        CurrentUser_Auxiliary = DB_Connection.AdministratorList.FirstOrDefault(x => x.UserIdentificationNumber == initialUserIdentificationNumberString_Auxiliary) as User;
                        SQL_ID_Auxiliary = CurrentUser_Auxiliary.SQL_ID;
                    }
                    else if (authorizationLevel_Auxiliary == 'T')
                    {
                        CurrentUser_Auxiliary = DB_Connection.TeacherList.FirstOrDefault(x => x.UserIdentificationNumber == initialUserIdentificationNumberString_Auxiliary) as User;
                        SQL_ID_Auxiliary = CurrentUser_Auxiliary.SQL_ID;
                    }
                    else
                    {
                        CurrentUser_Auxiliary = DB_Connection.StudentList.FirstOrDefault(x => x.UserIdentificationNumber == initialUserIdentificationNumberString_Auxiliary) as User;
                        SQL_ID_Auxiliary = CurrentUser_Auxiliary.SQL_ID;
                    }
                    string finalUserIdentificationNumber_Auxiliary = UserIdentification.UserIdentificationNumberGenerator(CurrentUser_Auxiliary);
                    string finalPasswordHashCode_Auxiliary = UserIdentification.hashPassword(finalUserIdentificationNumber_Auxiliary);
                    using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                    {
                        string UpdateUserIdentificationNumberAndPassword = "UPDATE Users SET UserIdentificationNumber=@userIdentificationNumberData, PasswordHashCode=@passwordHashCodeData WHERE Id=@IdData";
                        using (SqlCommand commandToUpdateUserData = new SqlCommand(UpdateUserIdentificationNumberAndPassword, connectingToLEAP_DB))
                        {
                            commandToUpdateUserData.Parameters.AddWithValue("@IdData", SQL_ID_Auxiliary);
                            commandToUpdateUserData.Parameters.AddWithValue("@userIdentificationNumberData", finalUserIdentificationNumber_Auxiliary);
                            commandToUpdateUserData.Parameters.AddWithValue("@passwordHashCodeData", finalPasswordHashCode_Auxiliary);
                            connectingToLEAP_DB.Open();
                            commandToUpdateUserData.ExecuteNonQuery();
                            MessageBox.Show("User successfully registered!");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection failed", "Error");
                }
                Program.ReadDataFromDatabase();
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled in!");
            }
        }
        private void UserDataModificationButton_Click(object sender, EventArgs e)
        {
            if ((FamilyNameTextBox.Text.Length > 0) && (FirstNameTextBox.Text.Length > 0) && ((AuthorizationLevelComboBox.SelectedItem != null) && ((SubjectsTaughtTextBox.Text.Length > 0) || ((GradeComboBox.SelectedItem != null) && (ClassComboBox.SelectedItem != null)))))
            {
                string familyName_Auxiliary = FamilyNameTextBox.Text;
                string firstName_Auxiliary = FirstNameTextBox.Text;
                char authorizationLevel_Auxiliary = Convert.ToChar(AuthorizationLevelComboBox.Text[0]);
                string subjectsTaught_Auxiliary = SubjectsTaughtTextBox.Text;
                ConvertTaughtSubjectsToString_UnitSeparator(SubjectsTaughtTextBox.Text, out subjectsTaught_Auxiliary);
                int grade_Auxiliary = Convert.ToInt32(GradeComboBox.SelectedItem);
                string class_Auxiliary = ClassComboBox.Text;
                try
                {
                    using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                    {
                        string UpdateUserData = "UPDATE Users SET FamilyName=@familyNameData, FirstName=@firstNameData, AuthorizationLevel=@authorizationLevelData, SubjectsTaught=@subjectsTaughtData, Grade=@gradeData, Class=@classData WHERE Id=@IdData";
                        using (SqlCommand commandToUpdateUserData = new SqlCommand(UpdateUserData, connectingToLEAP_DB))
                        {
                            commandToUpdateUserData.Parameters.AddWithValue("@IdData", UserID_Auxiliary);
                            commandToUpdateUserData.Parameters.AddWithValue("@familyNameData", familyName_Auxiliary);
                            commandToUpdateUserData.Parameters.AddWithValue("@firstNameData", firstName_Auxiliary);
                            commandToUpdateUserData.Parameters.AddWithValue("@authorizationLevelData", authorizationLevel_Auxiliary);
                            commandToUpdateUserData.Parameters.AddWithValue("@subjectsTaughtData", subjectsTaught_Auxiliary);
                            commandToUpdateUserData.Parameters.AddWithValue("@gradeData", grade_Auxiliary);
                            commandToUpdateUserData.Parameters.AddWithValue("@classData", class_Auxiliary);
                            connectingToLEAP_DB.Open();
                            commandToUpdateUserData.ExecuteNonQuery();
                            MessageBox.Show("The user's data has been successfully modified!");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection failed", "Error");
                }
                Program.ReadDataFromDatabase();
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled in!");
            }
        }
        private void ConvertTaughtSubjectsToString_UnitSeparator(string __subjectsTaughtStringRow_Comma, out string __subjectsTaughtStringRow_UnitSeparator)
        {
            __subjectsTaughtStringRow_UnitSeparator = "";
            string[] subjectsTaughtArray_Auxiliary = __subjectsTaughtStringRow_Comma.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < subjectsTaughtArray_Auxiliary.Length; i++)
            {
                __subjectsTaughtStringRow_UnitSeparator += UppercaseInitial(subjectsTaughtArray_Auxiliary[i].Trim());
                __subjectsTaughtStringRow_UnitSeparator += "▼";
            }
        }
        private static string UppercaseInitial(string __word)
        {

            if (__word.Length > 1)
            {
                return (__word[0].ToString().ToUpper() + (__word.Substring(1)));
            }
            else if (__word.Length == 1)
            {
                return __word[0].ToString().ToUpper();
            }
            else
            {
                return "";
            }
        }
        private void AuthorizationLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((AuthorizationLevelComboBox.SelectedItem.ToString() == "Administrator") || (AuthorizationLevelComboBox.SelectedItem.ToString() == "Teacher"))
            {
                SubjectsTaughtTextBox.Enabled = true;
                SubjectsTaughtTextBox.Show();
                SubjectsTaughtLabel1.Show();
                SubjectsTaughtLabel2.Show();

                GradeComboBox.Enabled = false;
                GradeComboBox.Hide();
                GradeLabel.Hide();

                ClassComboBox.Enabled = false;
                ClassComboBox.Hide();
                ClassLabel.Hide();
            }
            else
            {
                SubjectsTaughtTextBox.Enabled = false;
                SubjectsTaughtTextBox.Hide();
                SubjectsTaughtLabel1.Hide();
                SubjectsTaughtLabel2.Hide();

                GradeComboBox.Enabled = true;
                GradeComboBox.Show();
                GradeLabel.Show();

                ClassComboBox.Enabled = true;
                ClassComboBox.Show();
                ClassLabel.Show();
            }
        }
    }
}
