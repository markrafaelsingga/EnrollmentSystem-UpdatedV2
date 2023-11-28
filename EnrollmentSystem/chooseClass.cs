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
    public partial class chooseClass : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public int Program {  get; set; }
        public int ID { get; set; }
        public int SY {  get; set; }

        private List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

        public chooseClass()
        {
            InitializeComponent();

        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void display()
        {
            dataGridView1.DataSource = db.viewClasstoenroll(Program);
        }

        private void chooseClass_Load(object sender, EventArgs e)
        {
            display();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int countRow = selectedRows.Count;

            DialogResult result = MessageBox.Show($"You are enrolling {countRow} courses", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Iterate through selected rows and remove them
                foreach (DataGridViewRow row in selectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        int id = Convert.ToInt32(row.Cells["class_code"].Value);
                        db.enroll(ID, id, SY);
                    }
                }

                // Clear the list of selected rows
                selectedRows.Clear();
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["check"].Index)
            {
                DataGridViewCheckBoxCell checkbox = dataGridView1.Rows[e.RowIndex].Cells["check"] as DataGridViewCheckBoxCell;
                checkbox.Value = !Convert.ToBoolean(checkbox.Value);

                if ((bool)checkbox.Value)
                {
                    // Add the selected row to the list
                    selectedRows.Add(dataGridView1.Rows[e.RowIndex]);
                }
                else
                {
                    // Remove the row from the list if the checkbox is unchecked
                    selectedRows.Remove(dataGridView1.Rows[e.RowIndex]);
                }
            }
        }
    }
}
