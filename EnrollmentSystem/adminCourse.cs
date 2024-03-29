﻿using System;
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
    public partial class adminCourse : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        string name;
        public adminCourse(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            display();
            this.Invalidate();
        }

        private void adminCourse_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            display();
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
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

        private void add_Click(object sender, EventArgs e)
        {
            addCourse courseadd = new addCourse(verId);
            courseadd.FormClosed += Courseadd_FormClosed;
            courseadd.ShowDialog();
        }

        private void Courseadd_FormClosed(object sender, FormClosedEventArgs e)
        {
            display();

            
        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateCourse courseedit = new updateCourse(verId);

            var currentRow = dataGridView1.CurrentRow;

            if (currentRow != null)
            {
                courseedit.ID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()); 
                courseedit.Coursename = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                courseedit.Description = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                courseedit.Year = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                courseedit.Program = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                //courseedit.Semester = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());


                courseedit.FormClosed += Courseedit_FormClosed;
                courseedit.ShowDialog();
            }
            else
            {
                // Handle the case when currentRow is null
                MessageBox.Show("No selected course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Courseedit_FormClosed(object sender, FormClosedEventArgs e)
        {
            display();
        }

        private void display()
        {
            dataGridView1.DataSource = db.showCrs();
        }

        
        private void delete_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView1.CurrentRow;

            try
            {
                if (currentRow != null)
                {
                    name = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete \" " + name + " \"?", "Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        db.delCrs(name);
                        MessageBox.Show("Deleted successfully");
                        display();
                    }
                }
                else
                {
                    // Handle the case when currentRow is null
                    MessageBox.Show("No selected course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void delete_Click_1(object sender, EventArgs e)
        {

        }

        private void searchTxtbox_TextChanged(object sender, EventArgs e)
        {
            display();
            dataGridView1.DataSource = db.searchCourse(searchTxtbox.Text);
        }
    }
}
