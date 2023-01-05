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
            //Made for testing and demonstration purposes only. Anyway, the fields are always empty!
            Password_textBox.Text = UserIdentificationNumber_comboBox1.SelectedItem.ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
