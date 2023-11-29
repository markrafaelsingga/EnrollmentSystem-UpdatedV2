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
            // Get the value in the third column of the current row and parse it to an integer (assuming it's an ID).
            id = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            // Check if the clicked column is "Approve"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Approve")
            {
                // If "Approve" column is clicked, update the database by calling acceptEnroll with "approve" and the ID.
                string approve = "approve";
                db.acceptEnroll(approve, id);
                // Refresh the DataGridView1 after the update.
                display();
            }

            // Check if the clicked column is "Decline"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Decline")
            {
                // If "Decline" column is clicked, update the database by calling acceptEnroll with "Decline" and the ID.
                string decline = "decline";
                db.acceptEnroll(decline, id);
            }

            // Refresh the DataGridView1 (outside the if block so that it's done regardless of the column clicked).
            display();

            // Check if the clicked column is "view"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "view")
            {
                // Set the DataSource of dataGridView2 to the result of db.viewClasstoenroll with the given ID.
                dataGridView2.DataSource = db.viewEnrolleeCourse(id);
                // Make flowLayoutPanel2 visible.
                flowLayoutPanel2.Visible = true;
            }
        }



        private void display()
        {
            dataGridView1.DataSource = db.viewEnrollee();
        }

        private void adminEnrollment_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string course = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Approve1")
            {
                string approve = "approve";
                db.acceptEnroll_1by1(id, approve, course);
            }
            
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Decline1")
            {
                string decline = "decline";
                db.acceptEnroll_1by1(id, decline, course);
            }

            dataGridView2.DataSource = db.viewEnrolleeCourse(id);
        }

    }
}
