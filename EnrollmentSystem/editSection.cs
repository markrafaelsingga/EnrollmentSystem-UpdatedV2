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
    public partial class editSection : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public int Studnum {  get; set; }
        public editSection()
        {
            InitializeComponent();

            // Populate year ComboBox
            yr.DataSource = db.years.ToList();
            yr.DisplayMember = "year_level";
            yr.ValueMember = "year_id";

            // Populate program ComboBox
            program.DataSource = db.programs.ToList();
            program.DisplayMember = "prog_name";
            program.ValueMember = "prog_id";
        }

        private void editSection_Load(object sender, EventArgs e)
        {
            id.Text = Studnum.ToString();
            var result = db.getStud(Studnum).ToList();
            if (result != null && result.Any())
            {
                foreach (var item in result)
                {
                    // Populate UI controls with student information
                    fnameTxtbox.Text = item.stud_fname;
                    mitextBox.Text = item.stud_mi;
                    lnameTxtbox.Text = item.stud_lname;
                    phoneTxtbox.Text = item.stud_phone;
                    emailTxtbox.Text = item.stud_email;
                    gpa.Text = item.stud_gpa.ToString();

                    program.SelectedValue = item.prog_id;
                    program.Text = program.SelectedItem?.ToString(); // Handle null value

                    yr.SelectedValue = item.year_id;
                    yr.Text = yr.SelectedItem?.ToString(); // Handle null value

                    sec.Text = item.stud_sec;
                }

            }
            else
            {
                // Handle the case where no student information is found
                MessageBox.Show("Student information not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a section is selected in the ComboBox
                if (section.SelectedItem != null)
                {
                    // Explicitly cast the selected item to a string
                    string selectedSection = section.SelectedItem.ToString();

                    // Perform the check in the database
                    var check = db.checkSection(Studnum, selectedSection).Count();

                    // Check if there are any records indicating that the student is already assigned to the selected section
                    if (check == 0)
                    {
                        // Prompt the user for confirmation
                        DialogResult result = MessageBox.Show($"Are you updating the section of student #{Studnum} in Section {selectedSection}?", "Confirmation", MessageBoxButtons.YesNo);

                        // If the user confirms, update the section and close the form
                        if (result == DialogResult.Yes)
                        {
                            db.updateSection(selectedSection, Studnum);
                            this.Close();
                        }
                    }
                    else
                    {
                        // Display a message if the student is already assigned to the selected section
                        MessageBox.Show($"Student #{Studnum} is already assigned to section {selectedSection}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the update
                MessageBox.Show($"Error assigning section: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }
    }
}
