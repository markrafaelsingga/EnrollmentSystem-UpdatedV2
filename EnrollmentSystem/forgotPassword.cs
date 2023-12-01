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
    public partial class forgotPassword : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        string email;
        int id;
        public forgotPassword()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            changePassword change = new changePassword();
            change.Email = email;
            change.ID = id;
            change.FormClosed += Change_FormClosed;
            change.Show();
            Visible = false;
        }

        private void Change_FormClosed(object sender, FormClosedEventArgs e)
        {
            login log = new login();
            log.Show();
            Visible = false;
        }

        private void nextBtn_MouseHover(object sender, EventArgs e)
        {
            nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void nextBtn_MouseLeave(object sender, EventArgs e)
        {
            nextBtn.BackColor = System.Drawing.Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckEmailValidity();
        }

        private void CheckEmailValidity()
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string enteredEmail = textBox1.Text;

            bool isValidEmail = Regex.IsMatch(enteredEmail, pattern, RegexOptions.IgnoreCase);
            var isEmailInDatabase = db.checkEmail(enteredEmail).ToList();

            if (isValidEmail)
            {
                emlLbl.Hide();

                if (isEmailInDatabase != null && isEmailInDatabase.Any())
                {
                    nextBtn.Enabled = true;
                    foreach (var item in isEmailInDatabase)
                    {
                        email = item.stud_email;
                        id = item.stud_id;
                    }
                }
                else
                {
                    emlLbl.Show();
                    emlLbl.Text = "Email not found";
                }
            }
            else
            {
                emlLbl.Show();
                emlLbl.Text = "Invalid email format";
            }
        }

    }
}
