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
    public partial class signIn_student : Form
    {
        int adminId;
        string studFname, studLname;
        int u_id;
        public signIn_student()
        {
            InitializeComponent();
            program.DataSource = db.programs.ToList();
            program.DisplayMember = "prog_name";
            program.ValueMember = "prog_id";

            yr.DataSource = db.years.ToList();
            yr.DisplayMember = "year_level";
            yr.ValueMember = "year_id";

            var adId = db.adminID(id);
            if (adId != null && adId.Any())
            {
                foreach (var item in adId)
                {
                    adminId = item.admin_id;
                }
            }

            DisableSaveButton();
        }

        private void DisableSaveButton()
        {
            signinBtn.Enabled = false;
        }

        private void EnableSaveButton()
        {
            signinBtn.Enabled = true;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int id;

        private void signIn_student_Load(object sender, EventArgs e)
        {
            DateTime maxDate = DateTime.Now.AddYears(-17);
            phLbl.Hide();
            emlLbl.Hide();

            // Enable the Save button by default.
            EnableSaveButton();
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

            // Check and enable/disable Save button based on valid email and phone formats.
            CheckSaveButtonStatus();
        }

        private void CheckSaveButtonStatus()
        {
            // Enable Save button only if both email and phone formats are valid.
            if (IsValidEmail() && IsValidPhoneNumber() )
            {
                EnableSaveButton();
            }
            else
            {
                DisableSaveButton();
            }
        }

        private bool IsValidEmail()
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string eadd = emailtextBox.Text;
            return Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase);
        }

        private bool IsValidPhoneNumber()
        {
            string phpattern = @"^(\+63|09)\d{9}$";
            string pNo = phone.Text;
            return Regex.IsMatch(pNo, phpattern, RegexOptions.IgnoreCase);
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

            // Check and enable/disable Save button based on valid email and phone formats.
            CheckSaveButtonStatus();
        }

        private void birthdatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (birthdatePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Future date is invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void check()
        {
            var studCheck = db.checkStud(fnameTxtbox.Text, lnameTxtbox.Text).ToList();
            if (studCheck != null && studCheck.Any())
            {
                foreach (var item in studCheck)
                {
                    studFname = item.stud_fname;
                    studLname = item.stud_lname;
                }
            }
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            check();
            try
            {
                if (studFname != fnameTxtbox.Text && studLname != lnameTxtbox.Text)
                {
                    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                    string eadd = emailtextBox.Text;
                    db.createAcc(uname.Text, repword.Text);
                    var result = db.accId(uname.Text, repword.Text);
                    string phpattern = @"^(\+63|09)\d{9}$";
                    string pNo = phone.Text;
                    if (Regex.IsMatch(pNo, phpattern, RegexOptions.IgnoreCase) && Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase))
                    {
                        if (result != null)
                        {
                            var item = result.First();

                            id = item.u_id;
                            decimal grade = Convert.ToDecimal(gpa.Text);
                            int prog_id = (int)program.SelectedValue;
                            string gen = gender.SelectedItem.ToString();
                            int yrs = (int)yr.SelectedValue;

                            db.newStudentAccount(fnameTxtbox.Text, lnameTxtbox.Text, miTxtbox.Text, birthdatePicker.Value, addressTxtbox.Text, phone.Text, emailtextBox.Text, gen, yrs, grade, prog_id, id, 1);
                            MessageBox.Show("Successfully signed in. You can access your account once the admin activates your account", "Done");

                            login back = new login();
                            back.Show();
                            Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Error retrieving user information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessful!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Student already exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void pword_TextChanged(object sender, EventArgs e)
        {
            if (IsPasswordValid(pword.Text) is false)
            {
                passLbl.Visible = true;
                passLbl.Text = "Password should be at least 8 characters long and contain at";
                label15.Visible = true;
                label15.Text = "least one uppercase letter, one lowercase letter, one digit, and one special character.";

                DisableSaveButton();
            }
            else
            {
                passLbl.Visible = false;
                label15.Visible = false;
            }
        }

        private void repword_TextChanged(object sender, EventArgs e)
        {
            if (pword.Text != repword.Text)
            {
                retype.Visible = true;
                DisableSaveButton();
            }
            else
            {
                retype.Visible = false;
            }
        }

        private void uname_TextChanged(object sender, EventArgs e)
        {
            var user = db.checkUsername(uname.Text).ToList();
            if (user != null && user.Any())
            {
                usernameLbl.Visible = true;
                DisableSaveButton();
            }
            else
            {
                usernameLbl.Visible = false;
            }
        }

        private bool IsPasswordValid(string password)
        {
            // Password should be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!])(?=.{8,})";
            return Regex.IsMatch(password, pattern);
        }
    }
}
