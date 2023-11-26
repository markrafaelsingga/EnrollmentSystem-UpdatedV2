using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EnrollmentSystem
{
    public partial class adminClass : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        int crs_id;
        public adminClass(int verId)
        {
            InitializeComponent();
            this.verId = verId;
        }

        private void adminClass_Load(object sender, EventArgs e)
        {
           
            this.ControlBox = false;
            display();
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
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
            add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void edit_MouseHover(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void edit_MouseLeave(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.White;
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.White;
        }

        private void add_Click(object sender, EventArgs e)
        {
            addClass classadd = new addClass(verId);
            classadd.FormClosed += Classadd_FormClosed;
            classadd.ShowDialog();
        }

        private void Classadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            display();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateClass classupdate = new updateClass(verId);


            var currentRow = dataGridView1.CurrentRow;

            if (currentRow != null)
            {
                classupdate.Code = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                classupdate.Section = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                // Parse string values to DateTime objects
                classupdate.from = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                classupdate.to = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

                classupdate.Day = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                classupdate.Course = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                classupdate.Instructor = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                classupdate.Room = dataGridView1.CurrentRow.Cells[7].Value.ToString();


                classupdate.FormClosed += Classupdate_FormClosed;
                classupdate.ShowDialog();
            }
            else
            {
                // Handle the case when currentRow is null
                MessageBox.Show("No selected class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Classupdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            crs_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
        private void display()
        {
            dataGridView1.DataSource = db.showClass();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView1.CurrentRow;

            try
            {
                if (currentRow != null)
                {
                    int code = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    if (int.TryParse(code.ToString(), out int clscode))
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete \" Class code: " + clscode + " \"?", "Confirmation", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            db.delClass(code);
                            MessageBox.Show("Successfully deleted!");
                            display();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid 'id' value. Please enter a valid integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Handle the case when currentRow is null
                    MessageBox.Show("No selected class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
