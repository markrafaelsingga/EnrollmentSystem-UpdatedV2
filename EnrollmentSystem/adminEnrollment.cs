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
    public partial class adminEnrollment : Form
    {
        private int verId;
        int id;
        public adminEnrollment(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            display();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void adminEnrollment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.White;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Approve")
            {
                string approve = "approve";
                db.acceptEnroll(approve, id);
                display();
            }
        }
        private void display()
        {
            dataGridView1.DataSource = db.viewEnrollee();
        }
    }
}
