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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            fillFields();
         

            var result = db.getStud(studId).ToList();
            if (result != null && result.Any())
            {
                foreach (var item in result)
                {
                    adminId = item.admin_id;
                }
            }

        }

        private void cBox()
        {
            yr.DataSource = db.years.ToList();
            yr.DisplayMember = "year_level";
            yr.ValueMember = "year_id";

            program.DataSource = db.programs.ToList();
            program.DisplayMember = "prog_name";
            program.ValueMember = "prog_id";
        }

        private void studentEnrollment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbmsDataSet28.yearList' table. You can move, or remove it, as needed.
            //this.yearListTableAdapter.Fill(this.dbmsDataSet28.yearList);
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
            var result = db.getStud(studId).ToList();
            var current = db.getSchoolyear().OrderByDescending(x => x.sy_id).FirstOrDefault();
            if (current != null)
            {
                sy.Text = current.currentSy.ToString();
                if (result != null && result.Any())
                {
                    foreach (var item in result)
                    {
                        fnameTxtbox.Text = item.stud_fname;
                        mitextBox.Text = item.stud_mi;
                        lnameTxtbox.Text = item.stud_lname;
                        phoneTxtbox.Text = item.stud_phone;
                        emailTxtbox.Text = item.stud_email;
                        gpa.Text = item.stud_gpa.ToString();
                        user_Id = item.u_id;

                        program.SelectedValue = item.prog_id;
                        program.Text = program.SelectedItem?.ToString(); // Handle null value

                        yr.SelectedValue = item.year_id;
                        yr.Text = yr.SelectedItem?.ToString(); // Handle null value
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No school year is set", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "No enrollment at the moment";
                flowLayoutPanel4.Visible = false;
            }
            
        }
          
        private void saveBtn_Click(object sender, EventArgs e)
        {
            cBox();
            var sem = db.schoolyears.OrderByDescending(x => x.sy_id).FirstOrDefault();
            var check = db.enrollments.ToList();
            int progId = (int)program.SelectedValue;
            int yrId = (int)yr.SelectedValue;
            try 
            {
                if (check == null && check.Any())
                {
                    MessageBox.Show("You already submitted the enrollment form", "Already submitted");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are you enrolling to a regular load?", "Confirmation", MessageBoxButtons.YesNo);
                    // The student is regular so it will automatically pick the course to enroll
                    if (result == DialogResult.Yes)
                    {
                        db.updateInfostud(studId, phoneTxtbox.Text, emailTxtbox.Text, Convert.ToDecimal(gpa.Text), yrId, progId);
                        
                    }
                    // The student is irregular so he/she will pick the course to enroll
                    else
                    {
                        selectCourse select = new selectCourse();
                        select.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
