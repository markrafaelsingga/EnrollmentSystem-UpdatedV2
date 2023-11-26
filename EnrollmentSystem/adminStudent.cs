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
    public partial class adminStudent : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        private int verId;
        int id;
        string studNumber;
        int adminId;

        public adminStudent(int verId)
        {
            InitializeComponent();
            this.verId = verId;
        }

        private void adminStudent_Load(object sender, EventArgs e)
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
            addStudent addNewstudent = new addStudent();
            addNewstudent.FormClosed += AddNewstudent_FormClosed;
            addNewstudent.ShowDialog();
        }

        private void AddNewstudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            display();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateStudent editstudent = new updateStudent(verId);

            var currentRow = dataGridView1.CurrentRow;

            if (currentRow != null)
            {
                // Set properties before showing the form
                editstudent.ID = int.Parse(currentRow.Cells[0].Value?.ToString() ?? "0");
                editstudent.FirstName = currentRow.Cells[2].Value?.ToString();
                editstudent.LastName = currentRow.Cells[3].Value?.ToString();
                editstudent.MI = currentRow.Cells[4].Value?.ToString();

                // Parse Birthdate (assuming it's stored as a DateTime in the DataGridView)
                if (DateTime.TryParse(currentRow.Cells[5].Value?.ToString(), out var birthdate))
                {
                    editstudent.Birthdate = birthdate;
                }
                else
                {
                    // Handle parsing failure or set a default value
                    editstudent.Birthdate = DateTime.MinValue;
                }

                editstudent.Address = currentRow.Cells[6].Value?.ToString();
                editstudent.Phone = currentRow.Cells[7].Value?.ToString();
                editstudent.Email = currentRow.Cells[8].Value?.ToString();
                editstudent.Gender = currentRow.Cells[9].Value?.ToString();
                editstudent.YearLevel = currentRow.Cells[10].Value?.ToString();
                editstudent.ProgName = currentRow.Cells[11].Value?.ToString();

                // Parse GPA (assuming it's stored as a decimal in the DataGridView)
                if (decimal.TryParse(currentRow.Cells[12].Value?.ToString(), out var gpa))
                {
                    editstudent.GPA = gpa;
                }
                else
                {
                    // Handle parsing failure or set a default value (consistent with DateTime parsing)
                    editstudent.GPA = 0.0m;
                }

                // Now show the form
                editstudent.FormClosed += Editstudent_FormClosed;
                editstudent.ShowDialog();
            }
            else
            {
                // Handle the case when currentRow is null
                MessageBox.Show("No selected student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Editstudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            display();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView1.CurrentRow;
            
            try
            {
                if (currentRow != null)
                {
                    id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    studNumber = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    if (int.TryParse(id.ToString(), out int student_id))
                    {
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete \" Student no. " + studNumber + " \"?", "Confirmation", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            db.studDel(student_id);
                            MessageBox.Show("Successfully deleted!!", "DELETED");
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
                    MessageBox.Show("No selected student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void display()
        {
            var adId = db.adminID(verId).ToList();
            if (adId != null && adId.Any())
            {
                foreach (var item in adId)
                {
                    adminId = item.admin_id;
                }
            }
            dataGridView1.DataSource = db.showStudent(adminId);
        }

        private void search_Click(object sender, EventArgs e)
        {
            var result = db.searchStudent(searchTxtbox.Text).FirstOrDefault();

            if (result != null)
            {
                dataGridView1.DataSource = db.searchStudent(searchTxtbox.Text);
            }
            else
            {
                MessageBox.Show("No Student Found!");
            }
        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            display();
           dataGridView1.DataSource = db.searchStudent(searchTxtbox.Text);
        }
    }
}
