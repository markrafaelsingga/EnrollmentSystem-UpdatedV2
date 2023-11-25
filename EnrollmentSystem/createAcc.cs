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
    public partial class createAcc : Form
    {
        public createAcc()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void proceedBtn_Click(object sender, EventArgs e)
        {
           
           /* if (pword.Text == repword.Text)
            {
                *//*  db.createAcc(uname.Text, pword.Text);*//*
                // Assuming createAccWithLastID returns the new user ID
                

      

            }
            else
            {
                MessageBox.Show("Password didn't match!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
        }
    }
}
