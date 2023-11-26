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
    public partial class addCourse : Form
    {
        private int verId;
        public addCourse(int verId)
        {
            InitializeComponent();
            this.verId = verId;
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

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
            var result = db.adminID(verId).ToList();
            if (AllRequiredFieldsFilled())
            {
                if (result != null && result.Any())
                {
                    foreach (var item in result)
                    {
                        int year = Convert.ToInt32(comboBox1.SelectedItem);
                        int prog_id = (int)prog.SelectedValue;
                        int sem_id = (int)sem.SelectedValue;
                        db.addCrs(crscodeTxtbox.Text, crsdescTxtbox.Text, year, prog_id, sem_id);
                        MessageBox.Show("Added", "Successfull");
                        adminCourse ac = new adminCourse(verId);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Input fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AllRequiredFieldsFilled()
        {
            Control[] requiredControls = { crscodeTxtbox, crsdescTxtbox, comboBox1, prog, sem };

            foreach (Control control in requiredControls)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private void progList()
        {
            prog.DataSource = db.programs;
            prog.DisplayMember = "prog_name";
            prog.ValueMember = "prog_id";
        }

        private void semList()
        {
            sem.DataSource = db.semesters;
            sem.DisplayMember = "sem_level";
            sem.ValueMember = "sem_id";
        }

        private void addCourse_Load(object sender, EventArgs e)
        {
            semList();
            progList();
        }
    }
}
