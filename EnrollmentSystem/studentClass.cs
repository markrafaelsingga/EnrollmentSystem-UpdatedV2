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
    public partial class studentClass : Form
    {
        public studentClass()
        {
            InitializeComponent();
        }

        private void studentClass_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
