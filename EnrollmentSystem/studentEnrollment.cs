using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int prog;
        public studentEnrollment(int studId)
        {
            InitializeComponent();
            this.studId = studId;
         

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
            this.ControlBox = false;

            cBox();
            fillFields();
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
            var current = db.getSchoolyear().OrderByDescending(x => x.sy_id).FirstOrDefault();
            if (current != null)
            {
                sy.Text = current.currentSy.ToString();

                var result = db.getStud(studId).ToList();
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
                        prog = item.prog_id;

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
            var sem = db.schoolyears.OrderByDescending(x => x.sy_id).FirstOrDefault();
            var check = db.checkEnroll(studId, sem.sy_id).ToList();
            int progId = (int)program.SelectedValue;
            int yrId = (int)yr.SelectedValue;

            try
            {
                if (check != null && check.Any())
                {
                    MessageBox.Show("You have already submitted the enrollment form", "Already Submitted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var assignResult = db.checkAssign(studId).FirstOrDefault();
                    int assignedClassCount = assignResult?.result ?? 0;

                    if (assignedClassCount == 0)
                    {
                        DialogResult resultDialog = MessageBox.Show($"You are enrolling in school year {sy.Text}. Is this correct?", "Confirmation", MessageBoxButtons.YesNo);

                        if (resultDialog == DialogResult.Yes)
                        {
                            db.updateInfostud(studId, phoneTxtbox.Text, emailTxtbox.Text, Convert.ToDecimal(gpa.Text), yrId, progId);

                            var stud = db.studSection(studId).FirstOrDefault();

                            if (stud != null)
                            {
                                string section1 = stud.stud_sec;

                                // Check if the section string is not empty before accessing the first letter
                                if (!string.IsNullOrEmpty(section1))
                                {
                                    char firstLetter = section1[0];
                                    var section = db.compareSec(firstLetter.ToString(), yrId, progId, sem.sem_id).ToList();

                                    if (section != null && section.Any())
                                    {
                                        DialogResult resultDialog1 = MessageBox.Show($"Are you enrolling to a regular load?", "Confirmation", MessageBoxButtons.YesNo);
                                        if (resultDialog1 == DialogResult.Yes)
                                        {
                                            foreach (var result in section)
                                            {
                                                var classCode = result.class_code;
                                                db.enroll(studId, classCode, sem.sy_id);
                                            }
                                            MessageBox.Show("Enrollment successful! Waiting for approval", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            chooseClass choose = new chooseClass();
                                            choose.ID = studId;
                                            choose.SY = sem.sy_id;
                                            choose.Program = prog;
                                            choose.ShowDialog();
                                        }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("No available classes for enrollment", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Student section is empty.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Student not found or no section assigned.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You are not assigned to a class yet! Please notify the admin about your situation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
