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
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(comboBox1.SelectedItem);
            int prog_id = (int)prog.SelectedValue;
            int sem_id = (int)sem.SelectedValue;
            db.addCrs(crscodeTxtbox.Text, crsdescTxtbox.Text, year,prog_id,sem_id);
            MessageBox.Show("Added", "Successfull");
            adminCourse ac = new adminCourse(verId);
            
            
        }

        private void progList()
        {
            prog.DataSource = db.progList();
            prog.DisplayMember = "prog_name";
            prog.ValueMember = "prog_id";
        }

        private void semList()
        {
            sem.DataSource = db.semList();
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
