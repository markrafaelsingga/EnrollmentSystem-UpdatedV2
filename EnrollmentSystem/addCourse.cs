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
            db.addCrs(crscodeTxtbox.Text, crsdescTxtbox.Text, year);
            MessageBox.Show("Added","Successfull");
            adminCourse ac = new adminCourse(verId);
            ac.Show();
            Visible = false;
        }
    }
}
