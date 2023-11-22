using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnrollmentSystem
{
    public partial class updateProfessor : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int verId;
        int adminId;
        int insId;
        int id;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MI { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public updateProfessor(int verId)
        {
            InitializeComponent();
            DateTime maxDate = DateTime.Now.AddYears(-17);

            // Set the MaxDate property of the DateTimePicker
            birthdatePicker.MaxDate = maxDate;
            this.verId = verId;
        }

        private void saveBtn_MouseHover(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(138)))), ((int)(((byte)(204)))));
        }

        private void saveBtn_MouseLeave(object sender, EventArgs e)
        {
            saveBtn.BackColor = System.Drawing.Color.White;
        }

        public bool HasChanges(string newFirstName, string newLastName, string newMI, DateTime? newBirthdate, string newPhone, string newEmail, string newGender)
        {
            return !string.Equals(FirstName, newFirstName, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(LastName, newLastName, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(MI, newMI, StringComparison.OrdinalIgnoreCase) ||
                   !Nullable.Equals(Birthdate?.Date, newBirthdate?.Date) || // Compare only date parts
                   !string.Equals(Phone, newPhone, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(Email, newEmail, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(Gender, newGender, StringComparison.OrdinalIgnoreCase);
        }

        private bool AllRequiredFieldsFilled()
        {
            Control[] requiredControls = { idTxtbox, fnameTxtbox, lnameTxtbox, miTxtbox, birthdatePicker, phone, emailtextBox, gender};

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

                    // Check if any of the fields have changed, including the program name
                    if (HasChanges(fnameTxtbox.Text, lnameTxtbox.Text, miTxtbox.Text, bd, phone.Text, emailtextBox.Text, gen))
                    {
                        // Perform the update with the Student object
                        db.updateInstructor(ID, fnameTxtbox.Text, miTxtbox.Text, lnameTxtbox.Text, bd, age, gen, phone.Text, emailtextBox.Text, adminId);
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

        private int CalculateAge(DateTime birthdate)
        {
            DateTime now = DateTime.Now;
            DateTime bday = DateTime.Parse(birthdatePicker.Text);
            TimeSpan cal_age = now - bday;
            int age = (int)(cal_age.TotalDays / 365);

            return age;
        }

        private void updateProfessor_Load(object sender, EventArgs e)
        {
            idTxtbox.Text = ID.ToString();
            fnameTxtbox.Text = FirstName;
            lnameTxtbox.Text = LastName;
            miTxtbox.Text = MI;

            // Check if Birthdate is not null before assigning to the DateTimePicker
            if (Birthdate.HasValue)
            {
                birthdatePicker.Value = Birthdate.Value;
            }

            phone.Text = Phone;
            emailtextBox.Text = Email;
            gender.SelectedItem = Gender;
        }
    }
}
