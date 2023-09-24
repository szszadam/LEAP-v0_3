using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LEAP_v0_3
{
    //      ***** Sign In Window class *****
    //
    //
    // This is a class for identifying the user who wants to log in, which is the first
    // opening window when the program starts.It is a descendant of the "Form" class.
    // The main elements appearing on its graphical interface are the user ID field,
    // the password field, as well as the login and close buttons.
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // OpenMainWindow() – Create an instance of the "MainWindow" class, run it and open
    // the Main window representing the main menu.
    //
    //
    // SingInButton_Click() event handler – As a result of clicking on the "login" button,
    // the entered username is compared with the elements of both the Administrator list,
    // the Teacher list and the Student list, and if a match is found somewhere,
    // that will be the user who wants to log in. The stored, hash encrypted password of
    // this user is compared with the hash encrypted password typed by the user when logging in.
    // If a match is found, the user's entry is allowed and the OpenMainWindow() method is called.
    // In case of an incorrect username or password, an error message is received.
    //
    //
    // CloseButton_Click() event handler – closing the login window and stopping the program.

    public partial class SingInWindow : Form
    {
        public SingInWindow()
        {
            InitializeComponent();
        }
        public void OpenMainWindow()
        {
            Application.Run(new MainWindow());
        }
        private void SingInButton_Click(object sender, EventArgs e)
        {
            List<User> checkerList = new List<User>();
            bool userIdentificationNumberFound = false;
            int index = -1;
            if (!userIdentificationNumberFound)
            {
                index = -1;
                for (int i = 0; i < DB_Connection.AdministratorList.Count; i++)
                {
                    if (DB_Connection.AdministratorList[i].UserIdentificationNumber.ToUpper() == UserIdentificationNumber_comboBox1.Text.ToUpper())
                    {
                        checkerList = DB_Connection.AdministratorList.Cast<User>().ToList();
                        index = i;
                        userIdentificationNumberFound = true;
                        break;
                    }
                }
            }
            if (!userIdentificationNumberFound)
            {
                index = -1;
                for (int i = 0; i < DB_Connection.TeacherList.Count; i++)
                {
                    if (DB_Connection.TeacherList[i].UserIdentificationNumber.ToUpper() == UserIdentificationNumber_comboBox1.Text.ToUpper())
                    {
                        checkerList = DB_Connection.TeacherList.Cast<User>().ToList();
                        index = i;
                        userIdentificationNumberFound = true;
                        break;
                    }
                }
            }
            if (!userIdentificationNumberFound)
            {
                index = -1;
                for (int i = 0; i < DB_Connection.StudentList.Count; i++)
                {
                    if (DB_Connection.StudentList[i].UserIdentificationNumber.ToUpper() == UserIdentificationNumber_comboBox1.Text.ToUpper())
                    {
                        checkerList = DB_Connection.StudentList.Cast<User>().ToList();
                        index = i;
                        userIdentificationNumberFound = true;
                        break;
                    }
                }
            }
            if (!userIdentificationNumberFound)
            {
                MessageBox.Show("Wrong user identification nmber or password!");
            }
            if (userIdentificationNumberFound == true && index != -1 && checkerList[index].PasswordHashCode == UserIdentification.hashPassword(Password_textBox.Text))
            {
                UserIdentification.ActiveUser = checkerList[index];
                this.Close();
                Thread MainWindowOpeningThread;
                MainWindowOpeningThread = new Thread(OpenMainWindow);
                MainWindowOpeningThread.SetApartmentState(ApartmentState.STA);
                MainWindowOpeningThread.Start();
            }
            else
            {
                MessageBox.Show("Wrong user identification nmber or password!");
            }
        }
        private void UserIdentificationNumber_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Made for testing and demonstration purposes only. Otherwise, the fields are always empty!
            Password_textBox.Text = UserIdentificationNumber_comboBox1.SelectedItem.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
