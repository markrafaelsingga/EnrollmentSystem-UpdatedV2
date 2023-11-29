using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;



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
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int id;

        private void signIn_student_Load(object sender, EventArgs e)
        {
            phLbl.Hide();
            emlLbl.Hide();
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
                    if (pword.Text == repword.Text)
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
                                MessageBox.Show("Successfully signed in. You can access your account once the admin activate your account", "Done");

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
                            MessageBox.Show("Unsuccessfull!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password didn't match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Student already exist!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}


