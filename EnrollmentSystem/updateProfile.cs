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
    public partial class updateProfile : Form
    {
        private readonly DataClasses1DataContext db = new DataClasses1DataContext();
        public int ID { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string MI { get; set; }
        public string Phonenum {  get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        string studFname, studLname;

        public updateProfile()
        {
            InitializeComponent();
            DisableSaveButton();
        }

        private void DisableSaveButton()
        {
            saveBtn.Enabled = false;
        }

        private void EnableSaveButton()
        {
            saveBtn.Enabled = true;
        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void updateProfile_Load(object sender, EventArgs e)
        {
            var student = db.students.FirstOrDefault(a => a.stud_id == ID);
            var account = db.user_accounts.FirstOrDefault(x => x.u_id == student.u_id);
            lnameTxtbox.Text = Lastname;
            fnameTxtbox.Text = Firstname;
            miTxtbox.Text = MI;
            phoneTxtbox.Text = Phonenum;
            emailtextBox.Text = Email;
            addressTextbox.Text = Address;
            usernameTxtbox.Text = account.u_name;
            passtextBox.Text = account.u_pass;
            retypetextBox.Text = account.u_pass;

            // Enable the Save button by default.
            usernameLbl.Visible = false;
            passLbl.Visible = false;
            label15.Visible = false;
            label9.Visible = false;
            EnableSaveButton();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            check();
            try
            {
                if (studFname != fnameTxtbox.Text && studLname != lnameTxtbox.Text)
                {
                    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                    string eadd = emailtextBox.Text;
                    string phpattern = @"^(\+63|09)\d{9}$";
                    string pNo = phoneTxtbox.Text;
                    var student = db.students.FirstOrDefault(a => a.stud_id == ID);
                    var account = db.user_accounts.FirstOrDefault(x => x.u_id == student.u_id);

                    if (Regex.IsMatch(pNo, phpattern, RegexOptions.IgnoreCase) && Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase))
                    {
                        if (account != null)
                        {
                            if (student != null)
                            {
                                account.u_name = usernameTxtbox.Text;
                                account.u_pass = retypetextBox.Text;
                                student.stud_fname = fnameTxtbox.Text;
                                student.stud_lname = lnameTxtbox.Text;
                                student.stud_mi = miTxtbox.Text;
                                student.stud_phone = phoneTxtbox.Text;
                                student.stud_email = emailtextBox.Text;
                                student.stud_address = addressTextbox.Text;
                                MessageBox.Show("Update successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                db.SubmitChanges();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error retrieving user information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fill the fields with the required case correctly!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Student already exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Check and enable/disable Save button based on valid email and phone formats.
            CheckSaveButtonStatus();
        }

        private void CheckSaveButtonStatus()
        {
            // Enable Save button only if both email and phone formats are valid.
            if (IsValidEmail() && IsValidPhoneNumber())
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
            string pNo = phoneTxtbox.Text;
            return Regex.IsMatch(pNo, phpattern, RegexOptions.IgnoreCase);
        }

        private void phoneTxtbox_TextChanged(object sender, EventArgs e)
        {
            string phpattern = @"^(\+63|09)\d{9}$";
            string pNo = phoneTxtbox.Text;
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

        private void usernameTxtbox_TextChanged(object sender, EventArgs e)
        {
            var user = db.checkUsername(usernameTxtbox.Text).ToList();
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

        private void passtextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsPasswordValid(passtextBox.Text) is false)
            {
                passLbl.Visible = true;
                passLbl.Text = "Password should be at least 8 characters long and ";
                label15.Visible = true;
                label15.Text = "contain at least one uppercase letter, one lowercase ";
                label9.Visible = true;
                label9.Text = "letter, one digit, and one special character.";

                DisableSaveButton();
            }
            else
            {
                passLbl.Visible = false;
                label15.Visible = false;
                label9.Visible = false;
            }
        }
        private bool IsPasswordValid(string password)
        {
            // Password should be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!])(?=.{8,})";
            return Regex.IsMatch(password, pattern);
        }

        private void retypetextBox_TextChanged(object sender, EventArgs e)
        {
            if (passtextBox.Text != retypetextBox.Text)
            {
                retype.Visible = true;
                DisableSaveButton();
            }
            else
            {
                retype.Visible = false;
            }
        }
    }
}