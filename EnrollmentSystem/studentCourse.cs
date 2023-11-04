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
    public partial class studentCourse : Form
    {
        public studentCourse()
        {
            InitializeComponent();
        }

        private void studentCourse_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
