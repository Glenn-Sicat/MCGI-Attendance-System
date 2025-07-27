using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MCGI_Attendance_System
{
    public partial class Update_Information : Form
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfBaptism { get; set; }
        public string ChurchID { get; set; }
        public string ChurchStatus { get; set; }
        public string ImageName { get; set; }

        private string imageFilePath;
        private string newFileName;

        public Update_Information()
        {
            InitializeComponent();
        }

        private void Update_Information_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendanceRecord form = new AttendanceRecord();
            form.Show();
        }

        private void Update_Information_Load(object sender, EventArgs e)
        {
            
            DateTime parsedDateOfBirth = DateTime.ParseExact(DateOfBirth, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime parsedDateOfBaptism = DateTime.ParseExact(DateOfBaptism, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            txtEditMemberID.Text = ID;
            txtEditFullName.Text = FullName;

            //For DateTimePicker
            dtpEditDateofBirth.Value = parsedDateOfBirth;
            dtpEditDateOfBaptism.Value = parsedDateOfBaptism;
            txtEditChuchID.Text = ChurchID;
            txtEditChurchStatus.Text = ChurchStatus;

            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(exePath, @"..\..\"));

            //Create or ensure the "Member Images" folder exists
            string imagesFolder = Path.Combine(projectRoot, "Files", "Member Images");

            if (!Directory.Exists(imagesFolder))
            {
                Directory.CreateDirectory(imagesFolder);
            }
            imageFilePath = Path.Combine(imagesFolder, ImageName);
            pictBoxReg.ImageLocation = imageFilePath;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string dateToday = DateTime.Today.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(txtEditMemberID.Text) || string.IsNullOrWhiteSpace(txtEditFullName.Text) || string.IsNullOrWhiteSpace(txtEditChuchID.Text) || string.IsNullOrWhiteSpace(txtEditChurchStatus.Text) || dtpEditDateofBirth.ToString() == dateToday || dtpEditDateOfBaptism.ToString() == dateToday)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (File.Exists(imageFilePath))
            {
                string exePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = Path.GetFullPath(Path.Combine(exePath, @"..\..\"));

                //Create or ensure the "Member Images" folder exists
                string imagesFolder = Path.Combine(projectRoot, "Files", "Member Images");

                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                Console.WriteLine(imagesFolder);

                //Rename the image file again
                string ext = Path.GetExtension(imageFilePath); // e.g. ".jpg"
                newFileName = $"{FullName}{ext}";

                // Save file with specific name of user
                string fullPath = Path.Combine(imagesFolder, newFileName);

                try
                {
                    System.IO.File.Copy(imageFilePath, fullPath);
                }
                catch (IOException ex)
                {
                    if (File.Exists(fullPath))
                    {
                        File.Delete(fullPath);
                        System.IO.File.Copy(imageFilePath, fullPath);
                    }
                    else
                    {
                        System.IO.File.Copy(imageFilePath, fullPath);
                    }
                }
            }

            CRUD update = new CRUD();

            DialogResult result = MessageBox.Show("Are you sure to save this information?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string newID = txtEditMemberID.Text;
                string newFullName = txtEditFullName.Text;
                string newDateOfBirth = dtpEditDateofBirth.Value.ToString("yyyy-MM-dd");
                string newDateOfBaptism = dtpEditDateOfBaptism.Value.ToString("yyyy-MM-dd");
                string newChurchID = txtEditChuchID.Text;
                string newChurchStatus = txtEditChurchStatus.Text;
                string newImageName = newFileName;

                update.UpdateUserData(ID, newID, newFullName, newDateOfBirth, newDateOfBaptism, newChurchID, newChurchStatus, newImageName);
                update.UpdateUserRecord(ID, newID, newFullName);
                MessageBox.Show("Record saved successfully!");
            }
        }

        private void btnUpldoadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFolder = new OpenFileDialog();
            openFolder.Title = "Upload Member Image";
            openFolder.InitialDirectory = "C:\\";
            openFolder.Filter = "Image Files (*jpg)|*.jpg|All Files(*.*)|*.*";
            openFolder.FilterIndex = 1;

            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                pictBoxReg.Image = new Bitmap(openFolder.FileName);
                Console.WriteLine(openFolder.FileName);
                imageFilePath = openFolder.FileName;
            }
        }
    }
}
