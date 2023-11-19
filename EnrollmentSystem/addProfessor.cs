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
        private int verId;
        public addProfessor(int verId)
        {
            InitializeComponent();
            this.verId = verId;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
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
                        DateTime bd = birthdatePicker.Value;
                        DateTime currdate = DateTime.Now;
                        TimeSpan age_now = currdate - bd;
                        int age = (int)(age_now.TotalDays / 365.25);
                        string gen = gender.SelectedItem.ToString();
                        db.addInstructor(fnameTxtbox.Text, miTxtbox.Text, lnameTxtbox.Text, bd, age, gen, phone.Text, emailtextBox.Text, adminID);
                        MessageBox.Show("Professor Added!", "Successfull");
                        Visible = false;
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
