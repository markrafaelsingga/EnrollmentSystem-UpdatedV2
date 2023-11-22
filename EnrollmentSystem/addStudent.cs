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
            DateTime maxDate = DateTime.Now.AddYears(-17);

            // Set the MaxDate property of the DateTimePicker
            birthdatePicker.MaxDate = maxDate;

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
            check();
            DateTime bd = birthdatePicker.Value;
            DateTime currDate = DateTime.Now;
            TimeSpan age_now = currDate - bd;
            int age = (int)(age_now.TotalDays / 365.25);

            if (studFname != fnameTxtbox.Text && studLname != lnameTxtbox.Text)
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                string eadd = emailTxtbox.Text;
                db.createAcc(uname.Text, pword.Text);
                var result = db.accId(uname.Text);
                string phpattern = @"(09|\+639)\d{9}$";
                string pNo = phone.Text;
                bool checkPhone = Regex.IsMatch(pNo, phpattern, RegexOptions.IgnoreCase);
                bool checkEmail = Regex.IsMatch(eadd, pattern, RegexOptions.IgnoreCase);

            }
            else
            {
                MessageBox.Show("Student already exist!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string eadd = emailTxtbox.Text;
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

        private void lnameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnameTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void miTxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthdatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void emailLbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void addStudent_Load(object sender, EventArgs e)
        {
            phLbl.Hide();
            emlLbl.Hide();
            semList();
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

        private void semList()
        {
            sem.DataSource = db.semList();
            sem.DisplayMember = "sem_level";
            sem.ValueMember = "sem_id";
        }
    }
}
