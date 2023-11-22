using System;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class studentEnrollment : Form
    {
        public studentEnrollment()
        {
            InitializeComponent();
        }

        private void studentEnrollment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
