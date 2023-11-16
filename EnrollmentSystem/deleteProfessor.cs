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
    public partial class deleteProfessor : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        int id;
        public deleteProfessor(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            display();
        }
        private void deleteBtn_MouseHover(object sender, EventArgs e)
        {
            deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            deleteBtn.BackColor = System.Drawing.Color.White;
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.White;
        }

        private bool AllRequiredFieldsFilled()
        {
            Control[] requiredControls = { searchTxtbox };

            foreach (Control control in requiredControls)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            searchTxtbox.Text = id.ToString();
        }
        private void display()
        {
            dataGridView1.DataSource = db.showInstructor(verId);
        }

        private void search_Click(object sender, EventArgs e)
        {
            var result = db.searchIns(Convert.ToInt32(searchTxtbox.Text)).ToList();
            if (result != null && result.Any())
            {
                foreach (var item in result)
                {
                    id = Convert.ToInt32(item.ins_no);
                }
            }
            else
            {
                MessageBox.Show("No Professor Found!");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(AllRequiredFieldsFilled())
                {
                    db.insDel(id);
                }
                else
                {
                    MessageBox.Show("Input Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"An Error occured: {ex.Message}");
            }
        }
    }
}
