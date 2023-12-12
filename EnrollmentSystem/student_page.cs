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
    public partial class student_page : Form
    {
        studentHome home;
        studentEnrollment enrollment;
        studentCourse course;
        studentClass class1;
        studentProfile profile;
        private int studId;
        DataClasses1DataContext db = new DataClasses1DataContext();

        public student_page(int studId)
        {
            InitializeComponent();
            this.studId = studId;/*
            MessageBox.Show($"ID: {studId}");*/
            studName();


            var sName = db.getStud(studId).ToList();

            if (sName != null && sName.Any())
            {
                foreach (var item in sName)
                {
                    userFname.Text = item.stud_fname.ToUpper();
                }
            }

        }

        private void changeColor(Button colorBtn)
        {
            colorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
        }

        private void origColor(Button origBtn)
        {
            origBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void admin_page_Load(object sender, EventArgs e)
        {
            homeBtn_Click(sender, e);
            changeColor(homeBtn);
        }

        private void studName()
        {
            //var result = db.studFull(studId).ToList();
            //if(result!=null && result.Any())
            //{
            //    foreach(var item in result)
            //    {
            //        userFname.Text = item.Fullname;
            //    }
            //}
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (enrollment != null)
            {
                enrollment.Close();
            }
            if (course != null)
            {
                course.Close();
            }

            if (class1 != null)
            {
                class1.Close();
            }

            if (profile != null)
            {
                profile.Close();
            }

            if (home == null)
            {
                home = new studentHome();
                home.FormClosed += Home_FormClosed;
                home.MdiParent = this;
                home.Show();

                changeColor(homeBtn);
                home.Dock = DockStyle.Fill;
            }
            else
            {
                home.Activate();

            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            origColor(homeBtn);
            home = null;
        }

        private void enrollmentBtn_Click(object sender, EventArgs e)
        {
            if (home != null)
            {
                home.Close();
            }

            if (course != null)
            {
                course.Close();
            }

            if (class1 != null)
            {
                class1.Close();
            }

            if (profile != null)
            {
                profile.Close();
            }

            if (enrollment == null)
            {
                enrollment = new studentEnrollment(studId);
                enrollment.FormClosed += Enrollment_FormClosed;
                enrollment.MdiParent = this;
                enrollment.Show();

                changeColor(enrollmentBtn);
                enrollment.Dock = DockStyle.Fill;
            }
            else
            {
                enrollment.Activate();

            }
        }

        private void Enrollment_FormClosed(object sender, FormClosedEventArgs e)
        {
            origColor(enrollmentBtn);
            enrollment = null;
        }


        private void profileBtn_Click(object sender, EventArgs e)
        {
            if (enrollment != null)
            {
                enrollment.Close();
            }

            if (course != null)
            {
                course.Close();
            }

            if (class1 != null)
            {
                class1.Close();
            }

            if (home != null)
            {
                home.Close();
            }

            if (profile == null)
            {
                profile = new studentProfile(studId);
                profile.FormClosed += Profile_FormClosed;
                profile.MdiParent = this;
                profile.Show();

                changeColor(profileBtn);
                profile.Dock = DockStyle.Fill;
            }
            else
            {
                profile.Activate();

            }
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            origColor(profileBtn);
            profile = null;
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            if (enrollment != null)
            {
                enrollment.Close();
            }

            if (home != null)
            {
                home.Close();
            }

            if (class1 != null)
            {
                class1.Close();
            }

            if (profile != null)
            {
                profile.Close();
            }

            if (course == null)
            {
                course = new studentCourse(studId);
                course.FormClosed += Course_FormClosed;
                course.MdiParent = this;
                course.Show();

                changeColor(courseBtn);
                course.Dock = DockStyle.Fill;
            }
            else
            {
                course.Activate();

            }
        }

        private void Course_FormClosed(object sender, FormClosedEventArgs e)
        {
            origColor(courseBtn);
            course = null;
        }

        private void classBtn_Click(object sender, EventArgs e)
        {
            if (enrollment != null)
            {
                enrollment.Close();
            }

            if (home != null)
            {
                home.Close();
            }

            if (course != null)
            {
                course.Close();
            }

            if (profile != null)
            {
                profile.Close();
            }

            if (class1 == null)
            {
                class1 = new studentClass(studId);
                class1.FormClosed += Class_FormClosed;
                class1.MdiParent = this;
                class1.Show();

                changeColor(classBtn);
                class1.Dock = DockStyle.Fill;
            }
            else
            {
                class1.Activate();

            }
        }

        private void Class_FormClosed(object sender, FormClosedEventArgs e)
        {
            origColor(classBtn);
            class1 = null;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            changeColor(logoutBtn);
            login back_login = new login();
            back_login.Show();
            Visible = false;
        }

        private void student_page_Load(object sender, EventArgs e)
        {
            homeBtn_Click(sender, e);
            changeColor(homeBtn);
        }
    }
}
