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
    public partial class updateProfessor : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        int adminId;
        int insId;
        int id;
        public updateProfessor(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            display();
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DateTime bd = birthdatePicker.Value;
            DateTime currdate = DateTime.Now;
            TimeSpan age_now = currdate - bd;
            int age = (int)(age_now.TotalDays / 365.25);
            db.updateInstructor(id,fnameTxtbox.Text, miTxtbox.Text,lnameTxtbox.Text,bd,age,phone.Text,emailtextBox.Text,adminId);
            MessageBox.Show("Updated!", "Successfull");
            display();
            Visible = false;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id= int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            fnameTxtbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            miTxtbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lnameTxtbox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            birthdatePicker.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            phone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            emailtextBox.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void display()
        {
            var adId = db.adminID(verId).ToList();
            if(adId != null && adId.Any())
            {
                foreach(var item in adId)
                {
                    adminId = item.admin_id;
                }
            }
            dataGridView1.DataSource = db.showInstructor(adminId);
        }
    }
}
