using Emgu.CV.UI.GLView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class adminProfile : Form
    {
        private readonly DataClasses1DataContext db = new DataClasses1DataContext();
        private readonly int adminId;

        public adminProfile(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
            getAdmin();
        }

        private void adminProfile_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            DisableInputFields();
        }

        private void getAdmin()
        {
            var admin = db.admins.FirstOrDefault(a => a.admin_id == adminId);
            var account = db.user_accounts.FirstOrDefault(x => x.u_id == adminId);
            if (account != null && admin != null)
            {
                usernameTxtbox.Text = account.u_name;
                passTxtbox.Text = account.u_pass;
                retypeTxtbox.Text = account.u_pass;
                fnameTxtbox.Text = admin.admin_fname;
                lnameTxtbox.Text = admin.admin_lname;
                miTxtbox.Text = admin.admin_mi;
                phone.Text = admin.admin_phone;
                emailtextBox.Text = admin.admin_email;
                addressTxtbox.Text = admin.admin_address;
            }
        }

        private void DisableInputFields()
        {
            fnameTxtbox.Enabled = false;
            lnameTxtbox.Enabled = false;
            miTxtbox.Enabled = false;
            phone.Enabled = false;
            emailtextBox.Enabled = false;
            addressTxtbox.Enabled = false;
            usernameTxtbox.Enabled = false;
            passTxtbox.Enabled = false;

            retype_panel.Visible = false;
            usernameLbl.Hide();
            label8.Hide();
            label10.Hide();

        }

        private void EnableInputFields()
        {
            fnameTxtbox.Enabled = true;
            lnameTxtbox.Enabled = true;
            miTxtbox.Enabled = true;
            phone.Enabled = true;
            emailtextBox.Enabled = true;
            addressTxtbox.Enabled = true;
            usernameTxtbox.Enabled = true;
            passTxtbox.Enabled = true;
            retype_panel.Visible = true;
        }

        private void ToggleButtons(bool editing)
        {
            Save.Visible = editing;
            cancel.Visible = editing;
            edit.Visible = !editing;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            EnableInputFields();
            ToggleButtons(true);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DisableInputFields();
            ToggleButtons(false);
            getAdmin();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                string eadd = emailtextBox.Text;
                string phpattern = @"^(\+63|09)\d{9}$";
                string pNo = phone.Text;

                DisableInputFields();
                ToggleButtons(false);

                var admin = db.admins.FirstOrDefault(a => a.admin_id == adminId);
                var account = db.user_accounts.FirstOrDefault(x => x.u_id == adminId);

                if (Regex.IsMatch(pNo, phpattern, RegexOptions.IgnoreCase) && Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase))
                {
                    if (account != null && admin != null)
                    {
                        account.u_name = usernameTxtbox.Text;
                        account.u_pass = retypeTxtbox.Text;
                        admin.admin_fname = fnameTxtbox.Text;
                        admin.admin_lname = lnameTxtbox.Text;
                        admin.admin_mi = miTxtbox.Text;
                        admin.admin_phone = phone.Text;
                        admin.admin_email = emailtextBox.Text;
                        admin.admin_address = addressTxtbox.Text;

                        MessageBox.Show("Update successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.SubmitChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Fill the fields with the required case correctly!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DisableInputFields();
                    ToggleButtons(false);
                    getAdmin();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating administrator: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            string phpattern = @"^(\+63|09)\d{9}$";
            string pNo = phone.Text;
            bool checkPhone = Regex.IsMatch(pNo, phpattern, RegexOptions.IgnoreCase);
            var admin = db.admins.FirstOrDefault(a => a.admin_id == adminId);
            if (pNo == admin.admin_phone)
            {
                phLbl.Hide();
                Save.Enabled = true;
            }
            else if (checkPhone)
            {
                phLbl.Hide();
            }
            else
            {
                phLbl.Show();
                Save.Enabled = false;
            }
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string eadd = emailtextBox.Text;
            bool checkEmail = Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase);
            var admin = db.admins.FirstOrDefault(a => a.admin_id == adminId);
            if (eadd == admin.admin_phone)
            {
                emlLbl.Hide();
                Save.Enabled = true;
            }
            else if (checkEmail)
            {
                emlLbl.Hide();
            }
            else
            {
                emlLbl.Show();
                Save.Enabled = false;
            }
        }

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {
            var admin = db.admins.FirstOrDefault(a => a.admin_id == adminId);
            var account = db.user_accounts.FirstOrDefault(x => x.u_id == adminId);
            var user = db.checkUsername(usernameTxtbox.Text).ToList();
            if (usernameTxtbox.Text == account.u_name)
            {
                usernameLbl.Hide();
                Save.Enabled = true;
            }
            else if (user != null && user.Any())
            {
                usernameLbl.Show();
                Save.Enabled = false;
            }
            else
            {
                usernameLbl.Hide();
            }
        }

        private void passTxtbox_TextChanged(object sender, EventArgs e)
        {
            var admin = db.admins.FirstOrDefault(a => a.admin_id == adminId);
            var account = db.user_accounts.FirstOrDefault(x => x.u_id == adminId);
            if (passTxtbox.Text == account.u_pass)
            {
                label8.Hide();
                Save.Enabled = true;
            }
            else if (IsPasswordValid(passTxtbox.Text) is false)
            {
                label8.Show();
                label8.Text = "Password should be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.";

                Save.Enabled = false;
            }
            else
            {
                label8.Hide();
            }
        }
        private bool IsPasswordValid(string password)
        {
            // Password should be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!])(?=.{8,})";
            return Regex.IsMatch(password, pattern);
        }

        private void retypeTxtbox_TextChanged(object sender, EventArgs e)
        {
            if (passTxtbox.Text != retypeTxtbox.Text)
            {
                label10.Show();
                Save.Enabled = false;
            }
            else
            {
                label10.Hide();
            }
        }
    }
}