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
    public partial class addClass : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        public addClass(int verid)
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
        private bool AllRequiredFieldsFilled()
        {
            Control[] requiredControls = { prof,subjectcomboBox,room,fromTime,toTime,section,day };

            foreach (Control control in requiredControls)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    return false;
                }
            }

            return true;
        }

        //private bool Check()
        //{
        //    DateTime selectedTime = fromTime.Value;
        //    TimeSpan ftime = selectedTime.TimeOfDay;

        //    DateTime selectedTo = toTime.Value;
        //    TimeSpan ttime = selectedTo.TimeOfDay;
        //    var result = db.checkClass(section.Text, ftime, ttime, day.Text, Convert.ToInt32(subjectcomboBox.SelectedValue), Convert.ToInt32(room.SelectedValue)).ToList();
        //    if (result != null && result.Any())
        //    {
        //        foreach (var item in result)
        //        {
        //            classId = item.class_code;

        //        }
        //    }
        //    return true;

        //}

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AllRequiredFieldsFilled())
                {
                    int ins = (int)prof.SelectedValue;
                    int crs = (int)subjectcomboBox.SelectedValue;
                    int roomId = (int)room.SelectedValue;

                    DateTime selectedTime = fromTime.Value;
                    TimeSpan ftime = selectedTime.TimeOfDay;

                    DateTime selectedTo = toTime.Value;
                    TimeSpan ttime = selectedTo.TimeOfDay;

                    db.assignClass(section.Text, ftime, ttime, day.Text, crs, ins, roomId);
                    MessageBox.Show("Added!", "Successfull");
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Input fields!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
            }
        }

        private void addClass_Load(object sender, EventArgs e)
        {
            prof.DataSource = db.insFullname().ToList();
            prof.DisplayMember = "Fullname";
            prof.ValueMember = "ins_id";

            room.DataSource = db.rooms.ToList();
            room.DisplayMember = "room_name";
            room.ValueMember = "room_id";

            subjectcomboBox.DataSource = db.showCrs().ToList();
            subjectcomboBox.DisplayMember = "crs_name";
            subjectcomboBox.ValueMember = "crs_code";

            progList();
        }

        private void progList()
        {
            prog.DataSource = db.programs.ToList();
            prog.DisplayMember = "prog_name";
            prog.ValueMember = "prog_id";
        }
    }
}
