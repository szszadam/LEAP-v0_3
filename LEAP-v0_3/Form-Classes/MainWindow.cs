using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
namespace LEAP_v0_3
{
    public partial class MainWindow : Form
    {
        
    //      ***** Main Window Class *****
    //
    //
    //      *** Class description ***
    //
    //
    // The main window class is a descendant of the "Form" class and provides navigation between the menu items
    // that implement the main functions, as well as displays on its panel interface the access point of the
    // main functions that are descendants of the "UserControl" class. The main elements of the graphic
    // interface are : "Solve test sheet" button (A, T, S), "View results" button(A, T, S),
    // "Edit tasks" button(A, T), "Edit test sheet" button(A , T), "Send test sheets" button(A, T),
    // "Check test sheets" button(A, T), "Manage users" button(A), "Sign out" button(A, T, S)
    // and the "Change password" button(A, T, S).
    //
    // The letters behind the button names(between the parentheses) indicate the user's required authorization
    // level for accessing the function, therefore the visibility of the button representing the function.
    // ('A'-Administrator, 'T'-Teacher, 'S'-Student). Furthermore, part of this graphical interface is a panel
    // control, in which the following "UserControl" controls are embedded:
    // "TestSheetSelectorUC", "TestSheetCheckerSelectorUC", "TestSheetViewerSelectorUC",
    // "TaskSelectorAndEditorUC", "TestSheetAssemblerSelectorUC", "UserManagementSelectorUC”
    //
    //
    //      *** Methods and event handlers ***
    //
    //
    // MainWindow_Load() event handler - this method runs when the main window is opened, which causes the main
    // data of the logged-in user to be written into the bar of the bottom of window.
    //
    //
    // PanelSwitch() – this method switches between the "UserControl" controls embedded in the main window.It
    // makes visible and moves foregrounds the control it receives as a parameter, and hides the rest.
    //
    //
    // SolveTestSheetButton_Click() event handler – this method runs when the “Solve test sheet” button is
    // clicked and as a result, the PanelSwitch() method makes one instance of the "TestSheetSelectorUC" class
    // embedded in the main window, and activates and prioritizes it(bring it to the front).
    //
    //
    // CheckTestSheetsButton_Click() event handler - this method runs when the “Check test sheet” button is
    // clicked and as a result, the PanelSwitch() method makes one instance of the "TestSheetCheckerSelectorUC"
    // class embedded in the main window, then activates and prioritizes it(bring it to the front).
    //
    //
    // ViewResultsButton_Click() event handler -this method runs when the “View results” button is clicked and
    // as a result, the PanelSwitch() method makes one instance of the "TestSheetViewerSelectorUC" class
    // embedded in the main window, then activates and prioritizes it(bring it to the front).
    //
    //
    // EditTasksButton_Click() event handler - this method runs when the “Edit tasks” button is clicked and as a
    // result, the PanelSwitch() method makes one instance of the "TaskSelectorAndEditorUC" class embedded in
    // the main window, then activates and prioritizes it(bring it to the front).
    //
    //
    // EditTestSheetsButton_Click() event handler - this method runs when the “Edit test sheet” button is
    // clicked and as a result, the PanelSwitch() method makes one instance of the
    // "TestSheetAssemblerSelectorUC" class embedded in the main window, then activates and prioritizes it
    // (bring it to the front).
    //
    //
    // ManageUsersButton_Click() event handler -  this method runs when the “Manage users” button is clicked and
    // as a result, the PanelSwitch() method activates an instance of the "UserManagementSelectorUC" class
    // embedded in the main window, then activates and prioritizes it(bring it to the front).
    //
    //
    // SendTestSheetsButton_Click() event handler - this method runs when the “Send test sheet” button is
    // clicked and as a result, it creates a new instance of the "IndividualTestSheetSendingWindow" class and
    // opens it in a new dialog window.
    //
    //
    // SignOutButton_Click() event handler – by clicking on the "Logout" button, the current main window will be
    // closed and a new instance of the "SingInWindow" class and opens it in a new dialog window.
    //
    //
    // ChangePasswordButton_Click() event handler -  clicking on the "Change Password" button creates a new
    // instance of the "PasswordChangeWindow" class and opens it in a new dialog window.
    //
    //
    // MainWindow_Activated() event handler –  this method runs when the main window becomes active again.
    // Typically, this occurs when a dialog window implementing one of the main functions is closed and the main
    // window becomes active again. As a result, the "DataGridView" data row display control embedded in the
    // main window, located on all "UserControl" controls, updates its content (reads the data again from the
    // static lists of the static "DB_Connection" class).



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
