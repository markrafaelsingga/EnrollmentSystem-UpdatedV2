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
    public partial class updateCourse : Form
    {
        private int verId;
        public int ID {  get; set; }
        public string Coursename { get; set; }
        public string Description { get; set; }
        public string Program {  get; set; }
        public int Year { get; set; }
        public int Semester {  get; set; }

       
        public updateCourse(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void semList()
        {
            sem.DataSource = db.semesters.ToList();
            sem.DisplayMember = "sem_level";
            sem.ValueMember = "sem_id";
        }

        private void crsList()
        {
            comboBox1.DataSource = db.years.ToList();
            comboBox1.DisplayMember = "year_level";
            comboBox1.ValueMember = "year_id";
        }
        public bool HasChanges(string crs_name,string crs_desc,string year,string sem_id)
        {
            return !string.Equals(Coursename, crs_name, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(Description, crs_desc, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(Year.ToString(), year, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(Semester.ToString(), sem_id, StringComparison.OrdinalIgnoreCase);
                  
        }

        private bool AllRequiredFieldsFilled()
        {
            Control[] requiredControls = { idTxtbox, crsName,crsdescTxtbox,comboBox1,sem };

            foreach (Control control in requiredControls)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    return false;
                }
            }

            return true;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
          
            if (AllRequiredFieldsFilled())
            {            
                int years = (int)comboBox1.SelectedValue;
                int semId = (int)sem.SelectedValue; 
                if (HasChanges(crsName.Text, crsdescTxtbox.Text, comboBox1.Text, sem.Text))
                {
                    db.updateCrs(ID, crsName.Text, crsdescTxtbox.Text, years, semId);
                    MessageBox.Show("Updated Successfully!", "Success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No changes!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No course found!");
            }
        }
         

        private void updateCourse_Load(object sender, EventArgs e)
        {
            semList();
            crsList();

            idTxtbox.Text = ID.ToString();
            crsName.Text = Coursename;
            crsdescTxtbox.Text = Description;
            comboBox1.Text = Year.ToString();
            sem.Text = Semester.ToString();
        }
    }
}
