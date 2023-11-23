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
