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
        int adminId;
        int insId;
        public addClass(int verid)
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            int ins = (int)prof.SelectedValue;
            int crs = (int)subjectcomboBox.SelectedValue;
            int roomId = (int)room.SelectedValue;

            DateTime selectedTime = fromTime.Value;
            TimeSpan ftime = selectedTime.TimeOfDay;

            DateTime selectedTo = toTime.Value;
            TimeSpan ttime = selectedTo.TimeOfDay;

            db.assignClass(section.Text,ftime,ttime,day.Text,crs,ins,roomId);
            MessageBox.Show("Added!", "Successfull");
            Visible = false;
        }

        private void addClass_Load(object sender, EventArgs e)
        {
            prof.DataSource = db.insFullname().ToList();
            prof.DisplayMember = "Fullname";
            prof.ValueMember = "ins_id";

            room.DataSource = db.roomList().ToList();
            room.DisplayMember = "room_name";
            room.ValueMember = "room_id";

            subjectcomboBox.DataSource = db.showCrs().ToList();
            subjectcomboBox.DisplayMember = "crs_name";
            subjectcomboBox.ValueMember = "crs_code";
        }

        private void toTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
