using System.Linq;
using System.Windows.Forms;
using System;

namespace EnrollmentSystem
{
    public partial class adminHome : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int id;
        private int studId;

        public adminHome()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            batch.DataSource = db.batchList().ToList();
            batch.DisplayMember = "batch_year";
            batch.ValueMember = "batch_id";

            sem.DataSource = db.semList();
            sem.DisplayMember = "sem_level";
            sem.ValueMember = "sem_id";
        }

        private void adminHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            int stud = db.students.Count();
            int ins = db.instructors.Count(x => x.ins_isActive == true);
            int enroll = db.students.Count(x => x.stud_isActive == true);
            int unenroll = db.students.Count(x => x.stud_isActive == false);
            int crs = db.programs.Count();

            totalNumStud.Text = stud.ToString();
            instructorNum.Text = ins.ToString();
            enrolledNum.Text = enroll.ToString();
            unenrolledNum.Text = unenroll.ToString();
            courseNum.Text = crs.ToString();

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

        private void add_MouseLeave(object sender, EventArgs e)
        {
            add.BackColor = System.Drawing.Color.White;
        }

        private void add_MouseHover(object sender, EventArgs e)
        {
            add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void add_Click(object sender, EventArgs e)
        {
            int sem_id = (int)sem.SelectedValue;
            int batch_id = (int)batch.SelectedValue;
            db.addSchoolyear(batch_id, sem_id);
            MessageBox.Show("Successfully modify school year", "Modified success");
        }

        private void addBatch_Click(object sender, EventArgs e)
        {
            db.addBatch(batchTxtbox.Text);
            MessageBox.Show("Added successfully", "Successfully added");
        }
    }
}
