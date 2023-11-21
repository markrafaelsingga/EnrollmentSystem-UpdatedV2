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
    public partial class addStudent : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        string insFname, insLname, studFname, studLname;
        private int verId;
        int adminId;
        int id;
        public addStudent()
        {
            InitializeComponent();
            birthdatePicker.MaxDate = DateTime.Now;
            program.DataSource = db.progList().ToList();
            program.DisplayMember = "prog_name";
            program.ValueMember = "prog_id";

            batch.DataSource = db.batchList().ToList();
            batch.DisplayMember = "batch_year";
            batch.ValueMember = "batch_id";

            yr.DataSource = db.yearList().ToList();
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

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //@"(09|+639)\d{9}$"
            check();
            DateTime bd = birthdatePicker.Value;
            DateTime currDate = DateTime.Now;
            TimeSpan age_now = currDate - bd;
            int age = (int)(age_now.TotalDays / 365.25);

            if (studFname != fnameTxtbox.Text && studLname != lnameTxtbox.Text)
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                string eadd = emailtextBox.Text;
                db.createAcc(uname.Text, pword.Text);
                var result = db.accId(uname.Text);
                string phpattern = @"(09|+639)\d{9}$";
                string pNo = phone.Text;
                bool checkPhone = Regex.IsMatch(phpattern, pNo, RegexOptions.IgnoreCase);
                bool checkEmail = Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase);
                if (Regex.IsMatch(phpattern, pNo, RegexOptions.IgnoreCase) && Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase))
                {
                    if (result != null)
                    {

                        var item = result.First();

                        id = item.u_id;
                        decimal grade = Convert.ToDecimal(gpa.Text);
                        int prog_id = (int)program.SelectedValue;
                        int batch_id = (int)batch.SelectedValue;
                        string gen = gender.SelectedItem.ToString();
                        int yrs = (int)yr.SelectedValue;

                        db.enrollStudentbyAdmin(fnameTxtbox.Text, lnameTxtbox.Text, miTxtbox.Text, bd, age, addressTxtbox.Text, phone.Text, emailtextBox.Text, gen, yrs, grade, prog_id, id, 1, batch_id);
                        MessageBox.Show("Successfully enrolled!", "Done");
                    }
                    else
                    {
                        MessageBox.Show("Error retrieving user information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!checkEmail)
                    {
                        emlLbl.Show();
                    }
                    if (!checkPhone)
                    {
                        phLbl.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Student already exist!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addStudent_Load(object sender, EventArgs e)
        {
            phLbl.Hide();
            emlLbl.Hide();
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
    }
}
