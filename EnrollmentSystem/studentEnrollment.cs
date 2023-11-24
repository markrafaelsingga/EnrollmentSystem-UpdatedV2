using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class studentEnrollment : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int studId;
        public studentEnrollment(int studId)
        {
            InitializeComponent();
            this.studId = studId;
        }

        private void studentEnrollment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void fillFields()
        {
            var result = db.enrollExisting(studId);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
