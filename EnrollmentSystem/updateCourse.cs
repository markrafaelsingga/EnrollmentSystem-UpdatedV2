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
       
        public updateCourse(int verId)
        {
            InitializeComponent();
            this.verId = verId;
            
        }

        

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        private void search_MouseHover(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            search.BackColor = System.Drawing.Color.White;
        }

        private void search_Click(object sender, EventArgs e)
        {
            var result = db.searchCrs(searchTxtbox.Text);
            var resultList = result.ToList();
            if (resultList != null && resultList.Any())
            {
                
                foreach(var item in resultList)
                {
                    string crs_name = item.crs_name;
                    string crs_desc = item.crs_desc;
                    int crs_year = Convert.ToInt32(item.year_id);
                    crsName.Text = crs_name;
                    crsdescTxtbox.Text = crs_desc;
                    comboBox1.Text = crs_year.ToString();
                    /*MessageBox.Show($"Name: {crs_name} Desc: {crs_desc} Year: {crs_year}");*/
                }
            }
            else
            {
                MessageBox.Show("No courses found!");
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var result = db.searchCrs(searchTxtbox.Text);
            var resultList = result.ToList();
            if (resultList != null && resultList.Any())
            {

                foreach (var item in resultList)
                {
                    int crs_id = item.crs_code;
                   /* string crs_name = item.crs_name;
                    string crs_desc = item.crs_desc;*/
                    int crs_year = Convert.ToInt32(item.year_id);
                   /* crsName.Text = crs_name;
                    crsdescTxtbox.Text = crs_desc;
                    comboBox1.Text = crs_year.ToString();*/
                    if (crs_id > 0)
                    {
                        db.updateCrs(crs_id,crsName.Text, crsdescTxtbox.Text, crs_year);
                        MessageBox.Show("Updated Successfully!","Success");
                        Visible = false;
                    }
                    /*MessageBox.Show($"Name: {crs_name} Desc: {crs_desc} Year: {crs_year}");*/
                }
            }
            else
            {
                MessageBox.Show("No courses found!");
            }

        }


    }
}
