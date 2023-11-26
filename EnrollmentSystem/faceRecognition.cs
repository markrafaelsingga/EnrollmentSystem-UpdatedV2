using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using OpenTK.Graphics.OpenGL;


namespace EnrollmentSystem
{
    public partial class faceRecognition : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private int adminId;
        string fullname;
        FaceRec face = new FaceRec();
        public faceRecognition(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            admin_page dashboard = new admin_page(adminId);
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.Show();
            Visible = false;
            face.Close();
           

            //var result = db.verifyAdmin(label2.Text, adminId).ToList();
            //if (result != null && result.Any())
            //{
            //    foreach (var item in result)
            //    {
            //        fullname = item.Fullname;
            //    }
            //}
            //try
            //{
            //    if (fullname == label2.Text)
            //    {
            //        admin_page dashboard = new admin_page(adminId);
            //        dashboard.FormClosed += Dashboard_FormClosed;
            //        dashboard.Show();
            //        Visible = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Verification failed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occured: {ex.Message}");
            //}


        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            login log = new login();
            log.Show();
            Visible = false;
        }

        private void faceRecognition_Load(object sender, EventArgs e)
        {
            label2.Hide();
            face.isTrained = true;
            face.openCamera(pictureBox1, pictureBox1);
            face.getPersonName(label2);
        }

       
    }
}
