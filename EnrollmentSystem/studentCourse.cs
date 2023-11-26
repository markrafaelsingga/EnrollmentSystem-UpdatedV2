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
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int studId;
        public studentCourse(int studId)
        {
            InitializeComponent();
            this.studId = studId;
        }

        private void studentCourse_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
