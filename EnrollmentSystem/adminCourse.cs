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
    public partial class adminCourse : Form
    {
        private int verId;
        string name;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public adminCourse(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            display();
            this.Invalidate();
        }

        private void adminCourse_Load(object sender, EventArgs e)
        {
        

            this.ControlBox = false;
            display();
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void delete_MouseLeave(object sender, EventArgs e)
        {
            delete.BackColor = System.Drawing.Color.White;
        }

        private void add_MouseLeave(object sender, EventArgs e)
        {
            add.BackColor = System.Drawing.Color.White;
        }

        private void add_MouseHover(object sender, EventArgs e)
        {
            add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void edit_MouseHover(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void edit_MouseLeave(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.White;
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.White;
        }

        private void college_MouseHover(object sender, EventArgs e)
        {
            college.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void college_MouseLeave(object sender, EventArgs e)
        {
            college.BackColor = System.Drawing.Color.White;
        }

        private void college_Click(object sender, EventArgs e)
        {
            adminCollege collegeadmin = new adminCollege();
            collegeadmin.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            addCourse courseadd = new addCourse(verId);
            courseadd.ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateCourse courseedit = new updateCourse(verId);
            courseedit.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void display()
        {
            dataGridView1.DataSource = db.showCrs();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            db.delCrs(name);
            MessageBox.Show("Successfully Deleted!");
            display();
        }
    }
}
