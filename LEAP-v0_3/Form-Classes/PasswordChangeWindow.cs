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
using System.Data.SqlClient;

namespace LEAP_v0_3
{
    public partial class PasswordChangeWindow : Form
    {
        public PasswordChangeWindow()
        {
            InitializeComponent();
        }
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string oldPasswordHash = UserIdentification.hashPassword(oldPassword_textBox1.Text);
            string newPasswordHash = UserIdentification.hashPassword(newPassword_textBox1.Text);
            string newConfirmedPasswordHash = UserIdentification.hashPassword(newConfirmedPassword_textBox1.Text);
            if (oldPasswordHash == UserIdentification.ActiveUser.PasswordHashCode)
            {
                if (newPasswordHash == newConfirmedPasswordHash)
                {
                    UserIdentification.ActiveUser.PasswordHashCode = newPasswordHash;
                    try
                    {
                        using (SqlConnection connectingToLEAP_DB = new SqlConnection(DB_Connection.DB_Info))
                        {
                            string UpdatePassword = "UPDATE Users SET PasswordHashCode=@passwordHashCodeData WHERE Id=@idData";
                            using (SqlCommand CommandToUpdatePassword = new SqlCommand(UpdatePassword, connectingToLEAP_DB))
                            {
                                CommandToUpdatePassword.Parameters.AddWithValue("@idData", UserIdentification.ActiveUser.SQL_ID);
                                CommandToUpdatePassword.Parameters.AddWithValue("@passwordHashCodeData", newPasswordHash);
                                connectingToLEAP_DB.Open();
                                CommandToUpdatePassword.ExecuteNonQuery();
                                MessageBox.Show("The password has been updated successfully!");
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Connection failed", "Error");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Confirmation of the new password failed!", "Error");
                }
            }
            else
            {
                MessageBox.Show("The old password is wrong!", "Error");
            }
        }
    }
}
