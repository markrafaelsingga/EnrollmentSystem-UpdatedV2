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
        public int Code {  get; set; }
        public string Section {  get; set; }
        public DateTime? from { get; set; }
        public DateTime? to { get; set; }
        public string Day { get; set; }
        public string Course { get; set; }
        public string Instructor { get; set; }
        public string Room { get; set; }


        public updateClass(int verId)
        {
            InitializeComponent();
            this.verId = verId;
        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void updateClass_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dbmsDataSet11.showClass' table. You can move, or remove it, as needed.
            //this.showClassTableAdapter.Fill(this.dbmsDataSet11.showClass);

            room.DataSource = db.rooms.ToList();
            room.DisplayMember = "room_name";
            room.ValueMember = "room_id";

            prof.DataSource = db.insFullname().ToList();
            prof.DisplayMember = "Fullname";
            prof.ValueMember = "ins_id";

            subjectcomboBox.DataSource = db.showCrs().ToList();
            subjectcomboBox.DisplayMember = "crs_name";
            subjectcomboBox.ValueMember = "crs_code";

            textBox1.Text = Code.ToString();
            section.Text = Section;
            fromTime.Text = from.ToString();
            toTime.Text = to.ToString();
            day.Text = Day;

            int index = prof.FindString(Instructor);

            if (index != -1)
            {
                prof.SelectedIndex = index;
            }

            int index1 = subjectcomboBox.FindString(Course);

            if (index1 != -1)
            {
                subjectcomboBox.SelectedIndex = index;
            }

            int index2 = room.FindString(Room);

            if (index2 != -1)
            {
                room.SelectedIndex = index;
            }

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
    }
}
