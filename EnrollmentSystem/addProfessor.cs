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
    public partial class addProfessor : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        private int verId;
        int adminId;
        int id;

        public addProfessor(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            DateTime maxDate = DateTime.Now.AddYears(-17);

            // Set the MaxDate property of the DateTimePicker
            birthdatePicker.MaxDate = maxDate;


            var adId = db.adminID(id);
            if (adId != null && adId.Any())
            {
                foreach (var item in adId)
                {
                    adminId = item.admin_id;
                }
            }
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
            Control[] requiredControls = { birthdatePicker, gender,fnameTxtbox,miTxtbox,lnameTxtbox,phone,emailtextBox };

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
            var result = db.adminID(verId).ToList();
            if (AllRequiredFieldsFilled())
            {
                if (result != null && result.Any())
                {
                    foreach (var item in result)
                    {
                        int adminID = item.admin_id;                      
                        string gen = gender.SelectedItem.ToString();
                        db.newAdddInstructor(fnameTxtbox.Text, miTxtbox.Text, lnameTxtbox.Text, birthdatePicker.Value, gen, phone.Text, emailtextBox.Text, adminID);
                        MessageBox.Show("Professor Added!", "Successfull");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Input fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
