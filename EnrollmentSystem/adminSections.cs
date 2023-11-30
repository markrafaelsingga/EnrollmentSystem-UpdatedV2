using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace EnrollmentSystem
{
    public partial class adminSections : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        string name;

        public adminSections(int verId)
        {
            InitializeComponent();
            this.verId = verId;
        }

        private void add_MouseLeave(object sender, EventArgs e)
        {
            add.BackColor = System.Drawing.Color.White;
        }

        private void add_MouseHover(object sender, EventArgs e)
        {
            add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void edit_MouseHover(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void edit_MouseLeave(object sender, EventArgs e)
        {
            edit.BackColor = System.Drawing.Color.White;
        }
        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.White;
        }

        private void adminSections_Load(object sender, EventArgs e)
        {
            var sy = db.schoolyears.OrderByDescending(x => x.sy_id).FirstOrDefault();

            yrlevel.DataSource = db.yearList(sy.sy_id).ToList();
            yrlevel.DisplayMember = "year_id";
            yrlevel.ValueMember = "year_id";

            program.DataSource = db.progList(sy.sy_id).ToList();
            program.DisplayMember = "prog_name";
            program.ValueMember = "prog_id";

            section.DataSource = db.assignedStud(sy.sy_id).ToList();
            section.DisplayMember = "stud_sec";
            section.ValueMember = "stud_sec";

            if (yrlevel.SelectedValue != null && program.SelectedValue != null & section.SelectedValue != null)
            {
                load();
            }
            else
            {
                MessageBox.Show("No students enrolled in this school year/ semester!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "No students enrolled in this school year/ semester!";
                search.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel1.Visible = false;
            }

            this.ControlBox = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            assignSection assign = new assignSection();
            assign.ShowDialog();

        }
        private void load()
        {
            var sec = db.students.OrderByDescending(x => x.stud_sec).FirstOrDefault();
            if (sec != null)
            {
                if (sec.stud_sec != null)
                {
                    label1.Text = "LIST OF STUDENTS BY SECTION";
                    search.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    panel1.Visible = true;
                }
                else
                {
                    MessageBox.Show("No students assigns to a section yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label1.Text = "No students assigns to a section yet!";
                    search.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No students!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "No students assigns to a section yet!";
                search.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel1.Visible = false;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            int prog = (int)program.SelectedValue;
            int yrs = (int)yrlevel.SelectedValue;
            label5.Text = program.Text + " "+ yrlevel.Text + "-" + section.Text;
            dataGridView1.DataSource = db.viewSection(section.Text, prog, yrs);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            var sy = db.schoolyears.OrderByDescending(x => x.sy_id).FirstOrDefault();
            load();
            section.DataSource = db.assignedStud(sy.sy_id).ToList();
            section.DisplayMember = "stud_sec";
            section.ValueMember = "stud_sec";
        }

        private void refresh_MouseHover(object sender, EventArgs e)
        {
            refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void refresh_MouseLeave(object sender, EventArgs e)
        {
            refresh.BackColor = System.Drawing.Color.White;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView1.CurrentRow;

            if (currentRow != null)
            {
                editSection edit = new editSection();
                edit.Studnum = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                edit.FormClosed += Edit_FormClosed;
                edit.Show();
            }
            else
            {
                // Handle the case when currentRow is null
                MessageBox.Show("No selected student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            var sy = db.schoolyears.OrderByDescending(x => x.sy_id).FirstOrDefault();
            load();
            section.DataSource = db.assignedStud(sy.sy_id).ToList();
            section.DisplayMember = "stud_sec";
            section.ValueMember = "stud_sec";
        }
    }
}
