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
    public partial class studentEnrollment : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int studId;
        int adminId;
        int user_Id;
        int batchId;
        public studentEnrollment(int studId)
        {
            InitializeComponent();
            this.studId = studId;
            cBox();
         

            var result = db.studwithAdmin(studId).ToList();
            if (result != null && result.Any())
            {
                foreach (var item in result)
                {
                    adminId = item.admin_id;
                }
            }

            fillFields();
        }

        private void cBox()
        {
            batch.DataSource = db.batchList().ToList();
            batch.DisplayMember = "batch_year";
            batch.ValueMember = "batch_id";

            sem.DataSource = db.semList().ToList();
            sem.DisplayMember = "sem_level";
            sem.ValueMember = "sem_id";
/*
            yr.DataSource = db.yearList().ToList();
            yr.DisplayMember = "year_level";
            yr.ValueMember = "year_id";*/

            program.DataSource = db.progList().ToList();
            program.DisplayMember = "prog_name";
            program.ValueMember = "prog_id";

            batch.DataSource = db.batchList().ToList();
            batch.DisplayMember = "batch_year";
            batch.ValueMember = "batch_id";

      
        }

        private void studentEnrollment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbmsDataSet28.yearList' table. You can move, or remove it, as needed.
            this.yearListTableAdapter.Fill(this.dbmsDataSet28.yearList);
            this.ControlBox = false;
        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void fillFields()
        {
            var result = db.studName(studId).ToList();
            if (result != null && result.Any())
            {
                foreach(var item in result)
                {
                    fnameTxtbox.Text = item.stud_fname;
                    mitextBox.Text = item.stud_mi;
                    lnameTxtbox.Text = item.stud_lname;
                    dateTimePicker1.Value = item.stud_bday;
                    phoneTxtbox.Text = item.stud_phone;
                    emailTxtbox.Text = item.stud_email;
                    gen.Text = item.stud_gender;
                    batch.SelectedValue = item.batch_id;
                   /* yr.SelectedValue = item.year_id;*/
                    /*sem.SelectedValue = item.sem_id;*/
                    gpa.Text = item.stud_gpa.ToString();
                    user_Id = item.u_id;
                    /*batchId = item.batch_id;*/
                }
            }
        }
          
        private void saveBtn_Click(object sender, EventArgs e)
        {
            cBox();

            int progId = (int)program.SelectedValue;
            int yrId = (int)yr.SelectedValue;
            batchId = (int)batch.SelectedValue;
            try
            {
                db.enrollExisting(studId, fnameTxtbox.Text, lnameTxtbox.Text, mitextBox.Text, dateTimePicker1.Value, phoneTxtbox.Text, emailTxtbox.Text, gen.Text, yrId, Decimal.Parse(gpa.Text), progId, user_Id, adminId, batchId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void flowLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
