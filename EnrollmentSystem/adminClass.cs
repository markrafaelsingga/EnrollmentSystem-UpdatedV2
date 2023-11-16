﻿using System;
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
    public partial class adminClass : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        public adminClass(int verId)
        {
            InitializeComponent();
            this.verId = verId;
        }

        private void adminClass_Load(object sender, EventArgs e)
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

        private void subject_MouseHover(object sender, EventArgs e)
        {
            subject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(179)))));
        }

        private void subject_MouseLeave(object sender, EventArgs e)
        {
            subject.BackColor = System.Drawing.Color.White;
        }

        private void subject_Click(object sender, EventArgs e)
        {
            adminSubject subjectadmin = new adminSubject();
            subjectadmin.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            addClass classadd = new addClass(verId);
            classadd.ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            updateClass classupdate = new updateClass(verId);
            classupdate.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void display()
        {
            dataGridView1.DataSource = db.showClass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
