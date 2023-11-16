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
    public partial class adminProfessor : Form
    {
        private int verId;
        int adminId;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public adminProfessor(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            
        }

        private void adminProfessor_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            display();
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void delete_MouseLeave(object sender, EventArgs e)
        {
            delete.BackColor = System.Drawing.Color.White;
        }

        private void add_MouseLeave(object sender, EventArgs e)
        {
            add.BackColor = System.Drawing.Color.White;
        }

        private void add_MouseHover(object sender, EventArgs e)
        {
            add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void edit_MouseHover(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void edit_MouseLeave(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.White;
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.White;
        }

        private void add_Click(object sender, EventArgs e)
        {
            addProfessor addNewprofessor = new addProfessor(verId);
            addNewprofessor.ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateProfessor editprofessor = new updateProfessor(verId);
            editprofessor.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteProfessor deleteprofessor = new deleteProfessor(verId);
            deleteprofessor.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void display()
        {
            var adId = db.adminID(verId).ToList();
            if (adId != null &&  adId.Any())
            {
                foreach(var item in adId)
                {
                    adminId = item.admin_id;
                }
            }
            dataGridView1.DataSource = db.showInstructor(adminId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
