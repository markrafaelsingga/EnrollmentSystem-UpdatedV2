using System.Linq;
using System.Windows.Forms;
using System;

namespace EnrollmentSystem
{
    public partial class adminHome : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public adminHome()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            batch.DataSource = db.batches.ToList();
            batch.DisplayMember = "batch_year";
            batch.ValueMember = "batch_id";

            sem.DataSource = db.semesters.ToList(); 
            sem.DisplayMember = "sem_level";
            sem.ValueMember = "sem_id";
        }

        private void adminHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            int stud = db.students.Count(x => x.stud_isActive == true);
            int ins = db.instructors.Count(x => x.ins_isActive == true);
            int enroll = db.enrollments
                .Where(x => x.enroll_status == "approve")
                .Select(x => x.stud_id)
                .Distinct()
                .Count();
            int unenroll = db.enrollments
                .Where(x => x.enroll_status == "pending")
                .Select(x => x.stud_id)
                .Distinct()
                .Count();
            int crs = db.programs.Count();

            totalNumStud.Text = stud.ToString();
            instructorNum.Text = ins.ToString();
            enrolledNum.Text = enroll.ToString();
            unenrolledNum.Text = unenroll.ToString();
            courseNum.Text = crs.ToString();

            display();

        }

        private void display()
        {
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

            // Assuming 'db' is your database context or connection
            int check = db.schoolyears.Count(sy => sy.batch_id == batch_id && sy.sem_id == sem_id);

            if (check != 0)
            {
                MessageBox.Show("School year already exists for the selected batch and semester.", "Duplicate Entry");
            }
            else
            {
                // Show a confirmation message with "Yes" or "No"
                DialogResult result = MessageBox.Show("Attempting to add new school year. Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // The school year doesn't exist, you can proceed with adding it.
                    db.addSchoolyear(batch_id, sem_id);
                    MessageBox.Show("School year added successfully", "Successfully added");
                    display();
                }
            }
        }



        private void addBatch_Click(object sender, EventArgs e)
        {
            string batchYear = batchTxtbox.Text.Trim(); // Trim to remove leading/trailing spaces

            // Assuming 'db' is your database context or connection
            int check = db.batches.Count(batch => batch.batch_year == batchYear);

            if (check != 0)
            {
                MessageBox.Show("Batch already exists.", "Duplicate Entry");
            }
            else
            {
                // Ask the user if they want to perform additional actions
                DialogResult result = MessageBox.Show("DO you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // The batch doesn't exist; you can proceed with adding it.
                    db.addBatch(batchYear);
                    MessageBox.Show("Batch added successfully", "Successfully added");
                }
            }
        }

        private void addBatch_MouseHover(object sender, EventArgs e)
        {
            addBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void addBatch_MouseLeave(object sender, EventArgs e)
        {
            addBatch.BackColor = System.Drawing.Color.White;
        }

        private void addRoom_Click(object sender, EventArgs e)
        {
            string roomName = roomTxtbox.Text.Trim();

            // Assuming 'db' is your database context or connection
            var rooms = db.rooms.ToList();  // Retrieve all rooms

            int check = rooms.Count(room => room.room_name.Equals(roomName, StringComparison.OrdinalIgnoreCase));

            if (check != 0)
            {
                MessageBox.Show("Room already exists.", "Duplicate Entry");
            }
            else
            {
                // Ask the user if they want to proceed
                DialogResult result = MessageBox.Show("Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // The room doesn't exist; you can proceed with adding it.
                    db.addRoom(roomName);
                    MessageBox.Show("Room added successfully", "Successfully added");
                }
            }
        }



        private void addRoom_MouseHover(object sender, EventArgs e)
        {
            addRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void addRoom_MouseLeave(object sender, EventArgs e)
        {
            addRoom.BackColor = System.Drawing.Color.White;
        }
    }
}
