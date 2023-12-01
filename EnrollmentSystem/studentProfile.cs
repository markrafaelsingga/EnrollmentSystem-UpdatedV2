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
    public partial class studentProfile : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int studId;
        public studentProfile(int studId)
        {
            InitializeComponent();
            this.studId = studId;
            getStud();
        }

        private void studentProfile_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void getStud()
        {
            var sName = db.getStud(studId).ToList();
            if (sName != null && sName.Any())
            {
                foreach (var item in sName)
                {
                    idTxtbox.Text = item.stud_id.ToString();
                    fnameTxtbox.Text = item.stud_fname;
                    miTxtbox.Text = item.stud_mi;
                    lnameTxtbox.Text = item.stud_lname;
                    addressTxtbox.Text = item.stud_address;
                    birthdateTxtbox.Text = item.stud_bday.ToString();
                    phone.Text = item.stud_phone;
                    emailtextBox.Text = item.stud_email;
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            getStud();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateProfile update = new updateProfile();
            update.ID = Convert.ToInt32(idTxtbox.Text);
            update.Lastname = lnameTxtbox.Text;
            update.Firstname = fnameTxtbox.Text;
            update.MI = miTxtbox.Text;
            update.Phonenum = phone.Text;
            update.Email = emailtextBox.Text;
            update.Address = addressTxtbox.Text;
            update.FormClosed += Update_FormClosed;
            update.Show();
        }

        private void Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            getStud();
        }
    }
}
