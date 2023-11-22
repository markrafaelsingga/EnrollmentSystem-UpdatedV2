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
            sem.DataSource = db.semList();
            sem.DisplayMember = "sem_level";
            sem.ValueMember = "sem_id";
        }

        private void crsList()
        {
            comboBox1.DataSource = db.yearList();
            comboBox1.DisplayMember = "year_level";
            comboBox1.ValueMember = "year_id";
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var result = db.searchCrs(idTxtbox.Text);
            var resultList = result.ToList();
            if (resultList != null && resultList.Any())
            {

                foreach (var item in resultList)
                {
                    int crs_id = item.crs_code;
                    string crs_name = item.crs_name;
                    string crs_desc = item.crs_desc;
                    int crs_year = Convert.ToInt32(item.year_id);
                    int sem_id = (int)sem.SelectedValue;
                    int year_id = (int)comboBox1.SelectedValue;
                    crsName.Text = crs_name;
                    crsdescTxtbox.Text = crs_desc;
                    comboBox1.Text = crs_year.ToString();
                    if (crs_id > 0)
                    {
                        db.updateCrs(crs_id, crsName.Text, crsdescTxtbox.Text, year_id, sem_id);
                        MessageBox.Show("Updated Successfully!", "Success");
                        Visible = false;
                    }
                    MessageBox.Show($"Name: {crs_name} Desc: {crs_desc} Year: {crs_year}");
                }
            }
            else
            {
                MessageBox.Show("No courses found!");
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
