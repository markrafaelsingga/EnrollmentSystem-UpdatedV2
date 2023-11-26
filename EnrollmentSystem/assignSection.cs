using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace EnrollmentSystem
{
    public partial class assignSection : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        int studId;
        public assignSection()
        {
            InitializeComponent();
        }

        private void assignSection_Load(object sender, EventArgs e)
        {
            try
            {
                // Populate student IDs ComboBox
                var students = db.notAssign().ToList();
                id.DataSource = students;
                id.DisplayMember = "stud_id";
                id.ValueMember = "stud_id";

                // Populate year ComboBox
                yr.DataSource = db.years.ToList();
                yr.DisplayMember = "year_level";
                yr.ValueMember = "year_id";

                // Populate program ComboBox
                program.DataSource = db.programs.ToList();
                program.DisplayMember = "prog_name";
                program.ValueMember = "prog_id";

                if (id.Items.Count > 0)
                {
                    if (int.TryParse(id.Text, out int selectedStudId))
                    {
                        studId = selectedStudId;

                        // Trigger the SelectedIndexChanged event manually
                        id_SelectedIndexChanged(id, EventArgs.Empty);
                    }
                    else
                    {
                        // Handle the case where the text is not a valid integer
                        MessageBox.Show("Invalid selected value type! Please select a valid student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Optionally, reset the ComboBox selection or take other appropriate actions
                        id.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("All students are asigned to a section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (section.SelectedItem != null)
                {
                    DialogResult result = MessageBox.Show($"Are you assigning student #{studId} in Section {section.Text}?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        db.updateSection(section.Text, studId);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning section: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void id_SelectedIndexChanged(object sender, EventArgs e)
        {
            var studIdString = id.SelectedValue?.ToString();
            if (int.TryParse(studIdString, out int studId))
            {
                // Fetch student information based on the selected ID
                var result = db.getStud(studId).ToList();
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
                    }

                }
                else
                {
                    // Handle the case where no student information is found
                    MessageBox.Show("Student information not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Handle the case where the selected value is not of type int
                MessageBox.Show("Invalid selected value type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
