using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EnrollmentSystem
{
    public partial class signIn_student : Form
    {
        int adminId;
        string insFname, insLname, studFname, studLname;
        public signIn_student()
        {
            InitializeComponent();
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

        DataClasses1DataContext db = new DataClasses1DataContext();
        int id;
        private void backBtn_Click(object sender, EventArgs e)
        {


            login back_login = new login();
            back_login.Show();
            Visible = false;
        }

       private void check()
        {
            var studCheck = db.checkStud(fnameTxtbox.Text, lnameTxtbox.Text).ToList();
            if(studCheck != null&& studCheck.Any())
            {
                foreach(var item in studCheck)
                {
                    studFname = item.stud_fname;
                    studLname = item.stud_lname;
                }
            }
        }
        private void signinBtn_Click(object sender, EventArgs e)
        {
            check();
            DateTime bd = birthdatePicker.Value;
            DateTime currDate = DateTime.Now;
            TimeSpan age_now = currDate - bd;
            int age = (int)(age_now.TotalDays / 365.25);
            if (studFname != fnameTxtbox.Text && studLname != lnameTxtbox.Text)
            {
                if (pword.Text == repword.Text)
                {
                    db.createAcc(uname.Text, repword.Text);
                    var result = db.accId(uname.Text);

                    if (result != null)
                    {
                        // Assuming accId returns only one item, take the first one
                        var item = result.First();

                        id = item.u_id;
                        decimal grade = Convert.ToDecimal(gpa.Text);
                        int prog_id = (int)program.SelectedValue;
                        int batch_id = (int)batch.SelectedValue;
                        string gen = gender.SelectedItem.ToString();
                        int yrs = (int)yr.SelectedValue;

                        db.enrollStudent(fnameTxtbox.Text, lnameTxtbox.Text, miTxtbox.Text, bd, age, addressTxtbox.Text, phone.Text, emailtextBox.Text, gen, yrs, grade, prog_id, id, 1, batch_id);
                        MessageBox.Show("Successfully enrolled!", "Done");

                        // Redirect to the login page
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
                    MessageBox.Show("Password didn't match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Student already exist!","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

      
        
    }
}
