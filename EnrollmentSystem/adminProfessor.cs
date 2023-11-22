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
    public partial class adminProfessor : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        int id;
        string insNumber;
        int adminId;
        public adminProfessor(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            
        }

        private void adminProfessor_Load(object sender, EventArgs e)
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
            addProfessor addNewprofessor = new addProfessor(verId);
            addNewprofessor.FormClosed += AddNewprofessor_FormClosed;
            addNewprofessor.ShowDialog();
        }

        private void AddNewprofessor_FormClosed(object sender, FormClosedEventArgs e)
        {
            display();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateProfessor editprofessor = new updateProfessor(verId);

            // Set properties before showing the form
            editprofessor.ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            editprofessor.FirstName = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editprofessor.LastName = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            editprofessor.MI = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            // Parse Birthdate (assuming it's stored as a DateTime in the DataGridView)
            if (DateTime.TryParse(dataGridView1.CurrentRow.Cells[5].Value?.ToString(), out var birthdate))
            {
                editprofessor.Birthdate = birthdate;
            }
            else
            {
                // Handle parsing failure or set a default value
                editprofessor.Birthdate = DateTime.MinValue;
            }

            editprofessor.Phone = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            editprofessor.Email = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            editprofessor.Gender = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            // Now show the form
            editprofessor.FormClosed += Editprofessor_FormClosed;
            editprofessor.ShowDialog();
        }


        private void Editprofessor_FormClosed(object sender, FormClosedEventArgs e)
        {
            display();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            insNumber = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            try
            {
                if (int.TryParse(id.ToString(), out int instructor_id))
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete \" Instructor no. " + insNumber + " \"?", "Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        db.insDel(instructor_id);
                        MessageBox.Show("Successfully deleted!!", "DELETED");
                        display();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid 'id' value. Please enter a valid integer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (adId != null &&  adId.Any())
            {
                foreach(var item in adId)
                {
                    adminId = item.admin_id;
                }
            }
            dataGridView1.DataSource = db.showInstructor(adminId);
        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            display();
        }

        private void search_Click(object sender, EventArgs e)
        {
            var result = db.searchInstructor(searchTxtbox.Text).FirstOrDefault();

            if (result != null)
            {
                dataGridView1.DataSource = db.searchInstructor(searchTxtbox.Text);
            }
            else
            {
                MessageBox.Show("No Instructor Found!");
            }
        }
    }
}
