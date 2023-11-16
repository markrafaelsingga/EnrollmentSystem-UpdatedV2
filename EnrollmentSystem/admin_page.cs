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
    public partial class admin_page : Form
    {
        adminHome home;
        adminEnrollment enrollment;
        adminStudent student;
        adminProfessor professor;
        adminCourse course;
        adminClass class1;
        adminProfile profile;
        private int verId;
        public admin_page(int verId)
        {
            InitializeComponent();
            this.verId = verId;
          

        }

        private void changeColor(Button colorBtn)
        {
            colorBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
        }

        private void origColor (Button origBtn)
        {
            origBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        bool infoExpand = false;
        private void infoTransition_Tick(object sender, EventArgs e)
        {
            if (infoExpand == false)
            {
                infoContainer.Height += 10;
                if (infoContainer.Height >= 138)
                {
                    infoTransition.Stop();
                    infoExpand = true;
                }
            }
            else
            {
                infoContainer.Height -= 10;
                if (infoContainer.Height <= 40)
                {
                    infoTransition.Stop();
                    infoExpand = false;
                }
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            infoTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 57)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    panel1.Width = sidebar.Width;
                    pnHome.Width = sidebar.Width;
                    pnEnroll.Width = sidebar.Width;
                    pnCourse.Width = sidebar.Width;
                    pnClass.Width = sidebar.Width;
                    pnProfile.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    infoContainer.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 226)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    panel1.Width = sidebar.Width;
                    pnHome.Width = sidebar.Width;
                    pnEnroll.Width = sidebar.Width;
                    pnCourse.Width = sidebar.Width;
                    pnClass.Width = sidebar.Width;
                    pnProfile.Width = sidebar.Width;
                    pnLogout.Width = sidebar.Width;
                    infoContainer.Width = sidebar.Width;
                }
            }
        }

        private void hamburger_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void hamburger_MouseHover(object sender, EventArgs e)
        {
            hamburger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void admin_page_Load(object sender, EventArgs e)
        {
            homeBtn_Click(sender, e);
            changeColor(homeBtn);
        }

        private void hamburger_MouseLeave(object sender, EventArgs e)
        {
            hamburger.BackColor = System.Drawing.SystemColors.Control;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (enrollment != null)
            {
                enrollment.Close();
            }

            if (student != null)
            {
                student.Close();
            }

            if (professor != null)
            {
                professor.Close();
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
                home = new adminHome();
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

            if (student != null)
            {
                student.Close();
            }

            if (professor != null)
            {
                professor.Close();
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
                enrollment = new adminEnrollment(verId);
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

        private void studentBtn_Click(object sender, EventArgs e)
        {
            if (enrollment != null)
            {
                enrollment.Close();
            }

            if (home != null)
            {
                home.Close();
            }

            if (professor != null)
            {
                professor.Close();
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

            if (student == null)
            {
                student = new adminStudent(verId);
                student.FormClosed += Student_FormClosed;
                student.MdiParent = this;
                student.Show();

                changeColor(studentBtn);
                student.Dock = DockStyle.Fill;
            }
            else
            {
                student.Activate();

            }
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            origColor(studentBtn);
            student = null;
        }

        private void profBtn_Click(object sender, EventArgs e)
        {
            if (enrollment != null)
            {
                enrollment.Close();
            }

            if (student != null)
            {
                student.Close();
            }

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

            if (professor == null)
            {
                professor = new adminProfessor(verId);
                professor.FormClosed += Professor_FormClosed;
                professor.MdiParent = this;
                professor.Show();

                changeColor(profBtn);
                professor.Dock = DockStyle.Fill;
            }
            else
            {
                professor.Activate();

            }
        }

        private void Professor_FormClosed(object sender, FormClosedEventArgs e)
        {
            origColor(profBtn);
            professor = null;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            if (enrollment != null)
            {
                enrollment.Close();
            }

            if (student != null)
            {
                student.Close();
            }

            if (professor != null)
            {
                professor.Close();
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
                profile = new adminProfile();
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

            if (student != null)
            {
                student.Close();
            }

            if (professor != null)
            {
                professor.Close();
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
                course = new adminCourse(verId);
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

            if (student != null)
            {
                student.Close();
            }

            if (professor != null)
            {
                professor.Close();
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
                class1 = new adminClass(verId);
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
        
    }
}
