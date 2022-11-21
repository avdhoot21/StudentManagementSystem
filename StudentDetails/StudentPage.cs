using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace StudentDetails
{
    public partial class StudentPage : Form
    {
        private readonly int _studentID;
        public const string WARNMESSAGE = "This Field is required";

        public StudentPage()
        {
            InitializeComponent();
        }

        public StudentPage(int studentId)
        {
            _studentID = studentId;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentDTO studentDTO = new StudentDTO();
            if (IsValidation())
            {
                studentDTO.Student = new StudentModel();
                studentDTO.Student.StudentID = _studentID;
                studentDTO.Student.FirstName = txtFirstName.Text.Trim();
                studentDTO.Student.LastName = txtLastName.Text.Trim();
                studentDTO.Student.GenderID = Convert.ToInt32(cmbGender.SelectedValue);
                studentDTO.Student.DateOfBirth = dtpDOB.Value;
                studentDTO.Student.Age = Convert.ToInt32(txtAge.Text.Trim());
                studentDTO.Student.Class = txtClass.Text.Trim();
                studentDTO.Student.Address = txtAddress.Text.Trim();
                StudentBusinessLogic studentBusinessLogic = new StudentBusinessLogic();
                studentBusinessLogic.SaveStudent(studentDTO);
                Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure you want to Delete this student Record", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                StudentDTO studentDTO = new StudentDTO();
                studentDTO.Student = new StudentModel();
                studentDTO.Student.StudentID = _studentID;
                StudentBusinessLogic MyLogic = new StudentBusinessLogic();
                MyLogic.DeleteStudent(studentDTO);
            }
            Close();
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {
            StudentBusinessLogic studentBusinessLogic = new StudentBusinessLogic();
            StudentDTO studentDTO = new StudentDTO();
            studentDTO.Genders = new List<GenderModel>();
            studentDTO.Student = new StudentModel();
            studentBusinessLogic.GetStudent(studentDTO);
            cmbGender.DataSource = new BindingSource(studentDTO.Genders, null);
            cmbGender.DisplayMember = "Key";
            cmbGender.ValueMember = "Value";
            if (_studentID > 0)
            {
                lblHeader.Text = "Edit Student";
                btnDelete.Visible = true;
                studentDTO.Student = new StudentModel();
                studentDTO.Student.StudentID = _studentID;
                studentBusinessLogic.GetStudent(studentDTO);
                txtFirstName.Text = studentDTO.Student.FirstName;
                txtLastName.Text = studentDTO.Student.LastName;
                cmbGender.SelectedValue = studentDTO.Student.GenderID;
                dtpDOB.Value = studentDTO.Student.DateOfBirth;
                txtAge.Text = Convert.ToString(studentDTO.Student.Age);
                txtClass.Text = studentDTO.Student.Class;
                txtAddress.Text = studentDTO.Student.Address;
            }
            else
            {
                lblHeader.Text = "Add Student";
                btnDelete.Visible = false;
                cmbGender.SelectedItem = null;
            }
        }
       
       private bool IsValidation()
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                lblFirstNameWarn.Visible = true;
                lblFirstNameWarn.Text = WARNMESSAGE;
                isValid = false;
            }
            else if (txtFirstName.Text.Trim().Length < 3 || txtFirstName.Text.Trim().Length > 15)
            {
                lblFirstNameWarn.Visible = true;
                lblFirstNameWarn.Text = "minimum 3 and maximum 15 characters allowed";
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                lblLastNameWarn.Visible = true;
                lblLastNameWarn.Text = WARNMESSAGE;
                isValid = false;
            }
            else if (txtLastName.Text.Trim().Length < 2 || txtLastName.Text.Trim().Length > 18)
            {
                lblLastNameWarn.Visible = true;
                lblLastNameWarn.Text = "minimum 2 and maximum 18 characters allowed";
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtAge.Text.Trim()))
            {
                lblAgeWarn.Visible = true;
                lblAgeWarn.Text = WARNMESSAGE;
                isValid = false;
            }
            else if (Convert.ToInt32(txtAge.Text.Trim()) < 5 || Convert.ToInt32(txtAge.Text.Trim()) > 99)
            {
                lblAgeWarn.Visible = true;
                lblAgeWarn.Text = "Age should be between 5-99";
                isValid = false;
            }
            if (cmbGender.SelectedIndex < 0)
            {
                lblGenderWarn.Visible = true;
                lblGenderWarn.Text = WARNMESSAGE;
                isValid = false;
            }
            return isValid;
        }
        
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Char = e.KeyChar;
            if (Char != 8 && Char != 17 && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                lblFirstNameWarn.Visible = true;
                lblFirstNameWarn.Text = "Only characters required";
            }
            else
            {
                lblFirstNameWarn.Visible = false;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Char = e.KeyChar;
            if (Char != 8 && Char != 17 && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                lblLastNameWarn.Visible = true;
                lblLastNameWarn.Text = "Only characters required";
            }
            else
            {
                lblLastNameWarn.Visible = false;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char Char = e.KeyChar;
            if (Char != 8 && Char != 17 && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                lblAgeWarn.Visible = true;
                lblAgeWarn.Text = "Only numbers required";
            }
            else
            {
                lblAgeWarn.Visible = false;
            }
        }

        private void cmbGender_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGender.SelectedValue != null)
            {
                lblGenderWarn.Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int currentAge = DateTime.Today.Year - dtpDOB.Value.Year;
            txtAge.Text = currentAge.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            int DOB;
            Int32.TryParse(txtAge.Text.Trim(), out DOB);
            DateTime age = DateTime.Now.AddYears(-DOB);
            dtpDOB.Value = age;
        }
    }
}
