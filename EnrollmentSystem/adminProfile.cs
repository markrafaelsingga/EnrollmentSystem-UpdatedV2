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

            if (admin != null)
            {
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
        }

        private void EnableInputFields()
        {
            fnameTxtbox.Enabled = true;
            lnameTxtbox.Enabled = true;
            miTxtbox.Enabled = true;
            phone.Enabled = true;
            emailtextBox.Enabled = true;
            addressTxtbox.Enabled = true;
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
                if (Regex.IsMatch(pNo, phpattern, RegexOptions.IgnoreCase) && Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase))
                {
                    if (admin != null)
                    {
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
                    MessageBox.Show("Fill tthe fields with the required case correctly!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (checkPhone)
            {
                phLbl.Hide();
            }
            else
            {
                phLbl.Show();
            }
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string eadd = emailtextBox.Text;
            bool checkEmail = Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase);

            if (checkEmail)
            {
                emlLbl.Hide();
            }
            else
            {
                emlLbl.Show();
            }
        }
    }
}