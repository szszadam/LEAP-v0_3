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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            if (UserIdentification.ActiveUser is Student)
            {
                EditingTasksButton.Enabled = false;
                EditingTasksButton.Hide();
                EditingTestSheetsButton.Enabled = false;
                EditingTestSheetsButton.Hide();
                SendingTestSheetsButton.Enabled = false;
                SendingTestSheetsButton.Hide();
                CheckingTestSheetsButton.Enabled = false;
                CheckingTestSheetsButton.Hide();
                CheckingTestSheetsButton.Enabled = false;
                CheckingTestSheetsButton.Hide();
                ManagingUsersButton.Enabled = false;
                ManagingUsersButton.Hide();
            }
            else if (UserIdentification.ActiveUser is Teacher)
            {
                EditingTasksButton.Enabled = true;
                EditingTasksButton.Show();
                EditingTestSheetsButton.Enabled = true;
                EditingTestSheetsButton.Show();
                SendingTestSheetsButton.Enabled = true;
                SendingTestSheetsButton.Show();
                CheckingTestSheetsButton.Enabled = true;
                CheckingTestSheetsButton.Show();
                CheckingTestSheetsButton.Enabled = true;
                CheckingTestSheetsButton.Show();
                ManagingUsersButton.Enabled = false;
                ManagingUsersButton.Hide();
            }
            if (UserIdentification.ActiveUser is Administrator)
            {
                EditingTasksButton.Enabled = true;
                EditingTasksButton.Show();
                EditingTestSheetsButton.Enabled = true;
                EditingTestSheetsButton.Show();
                SendingTestSheetsButton.Enabled = true;
                SendingTestSheetsButton.Show();
                CheckingTestSheetsButton.Enabled = true;
                CheckingTestSheetsButton.Show();
                CheckingTestSheetsButton.Enabled = true;
                CheckingTestSheetsButton.Show();
                ManagingUsersButton.Enabled = true;
                ManagingUsersButton.Show();
            }
            PanelSwitch(null);
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            string displayedAuthorizationLevel;
            switch (UserIdentification.ActiveUser.AuthorizationLevel)
            {
                case 'A': displayedAuthorizationLevel = "Administrator"; break;
                case 'T': displayedAuthorizationLevel = "Teacher"; break;
                default: displayedAuthorizationLevel = "Student"; break;
            }
            CurrentUserLabel.Text = $"Active user: {UserIdentification.ActiveUser.FirstName} {UserIdentification.ActiveUser.FamilyName},   Identification number: {UserIdentification.ActiveUser.UserIdentificationNumber},   Authorization level: {displayedAuthorizationLevel}";
        }
        public void PanelSwitch(UserControl active)
        {
            testSheetSelectorUC1.Hide();
            testSheetCheckerSelectorUC1.Hide();
            testSheetViewerSelectorUC1.Hide();
            taskSelectorAndEditorUC1.Hide();
            testSheetAssemblerSelectorUC1.Hide();
            userManagementSelectorUC1.Hide();
            if (active != null)
            {
                active.Show();
                active.BringToFront();
            }
        }
        private void SolveTestSheetButton_Click(object sender, EventArgs e)
        {
            PanelSwitch(testSheetSelectorUC1);
        }
        private void CheckTestSheetsButton_Click(object sender, EventArgs e)
        {
            PanelSwitch(testSheetCheckerSelectorUC1);
        }
        private void ViewResultsButton_Click(object sender, EventArgs e)
        {
            PanelSwitch(testSheetViewerSelectorUC1);
        }
        private void EditTasksButton_Click(object sender, EventArgs e)
        {
            PanelSwitch(taskSelectorAndEditorUC1);
        }
        private void EditTestSheetsButton_Click(object sender, EventArgs e)
        {
            PanelSwitch(testSheetAssemblerSelectorUC1);
        }
        private void ManageUsersButton_Click(object sender, EventArgs e)
        {
            PanelSwitch(userManagementSelectorUC1);
        }
        private void SendTestSheetsButton_Click(object sender, EventArgs e)
        {
            IndividualTestSheetSendingWindow individualTestSheetSendingWindow1 = new IndividualTestSheetSendingWindow();
            individualTestSheetSendingWindow1.ShowDialog();
        }
        private void SignOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread SingInAndOpenThread;
            SingInAndOpenThread = new Thread(OpenSingInWindow);
            SingInAndOpenThread.SetApartmentState(ApartmentState.STA);
            SingInAndOpenThread.Start();

            void OpenSingInWindow()
            {
                Application.Run(new SingInWindow());
            }
        }
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            PasswordChangeWindow passwordChangeWindow1 = new PasswordChangeWindow();
            passwordChangeWindow1.ShowDialog();
        }
        public void MainWindow_Activated(object sender, EventArgs e)
        {
            taskSelectorAndEditorUC1.RefreshTableButton_Click_1(this, EventArgs.Empty);
            testSheetCheckerSelectorUC1.RefreshTableButton_Click(this, EventArgs.Empty);
            testSheetSelectorUC1.RefreshTableButton_Click(this, EventArgs.Empty);
            testSheetViewerSelectorUC1.RefreshTableButton_Click(this, EventArgs.Empty);
            testSheetAssemblerSelectorUC1.RefreshTableButton_Click_1(this, EventArgs.Empty);
            userManagementSelectorUC1.RefreshTableButton_Click(this, EventArgs.Empty);
        }
    }
}
