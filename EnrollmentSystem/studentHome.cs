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
    public partial class studentHome : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int studId;
        public studentHome()
        {
            InitializeComponent();
        }

        private void studentHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            var sy = db.schoolyears.OrderByDescending(x => x.sy_id).FirstOrDefault();

            if (sy != null)
            {
                var batchId = sy.batch.batch_year;
                syLbl.Text = batchId.ToString();

                var semid = sy.semester.sem_level;
                semLbl.Text = semid.ToString();
            }
            else
            {
                Console.WriteLine("No batches found in the table.");
            }
        }
    }
}
