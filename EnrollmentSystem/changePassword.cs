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
    public partial class changePassword : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public string Email {  get; set; }
        public int ID {  get; set; }
        public changePassword()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            var email = db.students.FirstOrDefault(a => a.stud_id == ID);

            if (email != null)
            {
                var account = db.user_accounts.FirstOrDefault(y => y.u_id == email.u_id);

                if (account != null)
                {
                    account.u_pass = repword.Text;
                    MessageBox.Show("Password changed successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.SubmitChanges();

                    login log = new login();
                    log.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show($"User account not found for the given email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Email not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextBtn_MouseHover(object sender, EventArgs e)
        {
            nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void nextBtn_MouseLeave(object sender, EventArgs e)
        {
            nextBtn.BackColor = System.Drawing.Color.White;
        }

        private void pword_TextChanged(object sender, EventArgs e)
        {
            if (IsPasswordValid(pword.Text) is false)
            {
                passLbl.Visible = true;
                passLbl.Text = "Password should be at least 8 characters long and ";
                label15.Visible = true;
                label15.Text = "contain at least one uppercase letter, one lowercase ";
                label9.Visible = true;
                label9.Text = "letter, one digit, and one special character.";

                nextBtn.Enabled = false;
            }
            else
            {
                passLbl.Visible = false;
                label15.Visible = false;
                label9.Visible = false;

                nextBtn.Enabled = true;
            }
        }
        private bool IsPasswordValid(string password)
        {
            // Password should be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!])(?=.{8,})";
            return Regex.IsMatch(password, pattern);
        }

        private void repword_TextChanged(object sender, EventArgs e)
        {
            if (pword.Text != repword.Text)
            {
                retype.Visible = true;
                nextBtn.Enabled = false;
            }
            else
            {
                retype.Visible = false;
                nextBtn.Enabled = true;
            }
        }
    }
}
