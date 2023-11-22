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
    public partial class updateStudent : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        int adminId;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MI { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string YearLevel { get; set; }
        public string ProgName { get; set; }
        public decimal? GPA { get; set; }

        public updateStudent(int verId)
        {
            InitializeComponent();
            birthdatePicker.MaxDate = DateTime.Now;
            this.verId = verId;
            display();

            idTxtbox.Text = ID.ToString();
        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        public bool HasChanges(string newFirstName, string newLastName, string newMI, DateTime? newBirthdate, string newAddress, string newPhone, string newEmail, string newGender, string newYearLevel, string newProgName, decimal? newGpa)
        {
            return !string.Equals(FirstName, newFirstName, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(LastName, newLastName, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(MI, newMI, StringComparison.OrdinalIgnoreCase) ||
                   !Nullable.Equals(Birthdate?.Date, newBirthdate?.Date) || // Compare only date parts
                   !string.Equals(Address, newAddress, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(Phone, newPhone, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(Email, newEmail, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(Gender, newGender, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(YearLevel, newYearLevel, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(ProgName, newProgName, StringComparison.OrdinalIgnoreCase) ||
                   !Nullable.Equals(GPA, newGpa);
        }

        private bool AllRequiredFieldsFilled()
        {
            Control[] requiredControls = { idTxtbox, fnameTxtbox, lnameTxtbox, miTxtbox, birthdatePicker, addressTxtbox, phone, emailtextBox, gender, yr, course, gpa };

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
            try
            {
                if (AllRequiredFieldsFilled())
                {
                    string selectedCourse = string.Empty;
                    DateTime bd = birthdatePicker.Value;
                    int age = CalculateAge(bd);
                    string gen = gender.SelectedItem.ToString();
                    int year = Convert.ToInt32(yr.SelectedItem);
                    int prog_id = (int)course.SelectedValue;
                    int index = course.FindString(ProgName);

                    if (index != -1)
                    {
                        // The string was found in the ComboBox items
                        selectedCourse = course.Items[index].ToString();
                    }

                    // Use decimal.TryParse for GPA
                    if (!decimal.TryParse(gpa.Text, out var parsedGpa))
                    {
                        // Handle parsing failure or set a default value
                        parsedGpa = 0.0m;
                    }

                    // Check if any of the fields have changed, including the program name
                    if (HasChanges(fnameTxtbox.Text, lnameTxtbox.Text, miTxtbox.Text, bd, addressTxtbox.Text, phone.Text, emailtextBox.Text, gen, year.ToString(), selectedCourse, parsedGpa))
                    {
                        // Perform the update with the Student object
                        db.updateStudent(ID, fnameTxtbox.Text, lnameTxtbox.Text, miTxtbox.Text, bd, age, addressTxtbox.Text, phone.Text, emailtextBox.Text, gen, year, prog_id, parsedGpa, adminId);
                        MessageBox.Show("Updated successfully!", "UPDATED");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nothing changed!", "Warning", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    // Provide more specific feedback about missing required fields
                    MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error parsing date or GPA: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void display()
        {
            var adId = db.adminID(verId).ToList();
            if (adId != null && adId.Any())
            {
                foreach(var item in adId)
                {
                    adminId = item.admin_id;
                }
            }
        }

        private int CalculateAge(DateTime birthdate)
        {
            DateTime now = DateTime.Now;
            DateTime bday = DateTime.Parse(birthdatePicker.Text);
            TimeSpan cal_age = now - bday;
            int age = (int)(cal_age.TotalDays / 365);

            return age;
        }

        private void updateStudent_Load(object sender, EventArgs e)
        {
            PopulateProgramList();

            idTxtbox.Text = ID.ToString();
            fnameTxtbox.Text = FirstName;
            lnameTxtbox.Text = LastName;
            miTxtbox.Text = MI;

            // Check if Birthdate is not null before assigning to the DateTimePicker
            if (Birthdate.HasValue)
            {
                birthdatePicker.Value = Birthdate.Value;
            }

            // Find the index of the item with the specified ProgName
            int index = course.FindString(ProgName);

            // Set the selected item based on the found index
            if (index != -1)
            {
                course.SelectedIndex = index;
            }

            addressTxtbox.Text = Address;
            phone.Text = Phone;
            emailtextBox.Text = Email;
            gender.SelectedItem = Gender;
            yr.SelectedItem = YearLevel;

            // Assuming GPA is a decimal, validate it before setting the Text property
            if (GPA.HasValue)
            {
                gpa.Text = GPA.ToString();
            }
            else
            {
                gpa.Text = string.Empty; // or set a default value if appropriate
            }
        }

        private void PopulateProgramList()
        {
            course.DataSource = db.progList().ToList();
            course.DisplayMember = "prog_name";
            course.ValueMember = "prog_id";
        }
    }
}
