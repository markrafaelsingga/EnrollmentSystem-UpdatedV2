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
    public partial class updateClass : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        int id;
        public updateClass(int verId)
        {
            InitializeComponent();
            this.verId = verId;
        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.White;
        }

        private void updateClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbmsDataSet11.showClass' table. You can move, or remove it, as needed.
            this.showClassTableAdapter.Fill(this.dbmsDataSet11.showClass);

            room.DataSource = db.roomList().ToList();
            room.DisplayMember = "room_name";
            room.ValueMember = "room_id";

            prof.DataSource = db.insFullname().ToList();
            prof.DisplayMember = "Fullname";
            prof.ValueMember = "ins_id";

            subjectcomboBox.DataSource = db.showCrs().ToList();
            subjectcomboBox.DisplayMember = "crs_name";
            subjectcomboBox.ValueMember = "crs_code";

            display();
        }

        private bool AllRequiredFieldsFilled()
        {
            Control[] requiredControls = { subjectcomboBox,room,prof,section,day };

            foreach (Control control in requiredControls)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    return false;
                }
            }

            return true;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AllRequiredFieldsFilled())
                {
                    int crs = (int)subjectcomboBox.SelectedValue;
                    int roomId = (int)room.SelectedValue;
                    int insId = (int)prof.SelectedValue;
                    DateTime selectedTime = fromTime.Value;
                    TimeSpan ftime = selectedTime.TimeOfDay;

                    DateTime selectedTo = toTime.Value;
                    TimeSpan ttime = selectedTo.TimeOfDay;
                    db.updateClass(id, section.Text, ftime, ttime, day.Text, crs, insId, roomId);

                    MessageBox.Show("Updated!", "Successfull");
                    display();
                }
                else
                {
                    MessageBox.Show("Input fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            section.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fromTime.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            toTime.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            day.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            subjectcomboBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            prof.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            room.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        private void display()
        {
            dataGridView1.DataSource = db.showClass();
        }
    }
}
