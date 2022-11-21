using System;
using System.Windows.Forms;

namespace StudentDetails
{
    public partial class StudentsPage : Form
    {
        public StudentsPage()
        {
            InitializeComponent();
        }

        private void StudentPages_Load(object sender, EventArgs e)
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.ColumnCount = 6;
            DataColumn("StudentID", 0, "StudentID");
            DataColumn("FirstName", 1, "First Name");
            DataColumn("LastName", 2, "Last Name");
            DataColumn("Gender", 3, "Gender");
            DataColumn("Age", 4, "Age");
            DataColumn("Class", 5, "Class");
            dgvStudents.EditMode = DataGridViewEditMode.EditProgrammatically;
            /*StudentDTO studentDTO = new StudentDTO();
            new StudentBusinessLogic().GetStudents(studentDTO);
            dgvStudents.DataSource = studentDTO.Students;*/
            dgvStudents.Columns[0].Visible = false;
            GridDesign();
        }

        private void DataColumn(string name, int index, string header)
        {
            dgvStudents.Columns[index].Name = name;
            dgvStudents.Columns[index].DataPropertyName = name;
            dgvStudents.Columns[index].HeaderText = header;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            StudentDTO studentDTO = new StudentDTO();
            studentDTO.SearchStudents = txtSearch.Text.Trim();
            new StudentBusinessLogic().GetStudents(studentDTO);
            dgvStudents.DataSource = studentDTO.Students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentPage student = new StudentPage();
            student.ShowDialog();
        }

        private void dgvStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                StudentPage myStudent = new StudentPage(Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value.ToString()));
                myStudent.ShowDialog();
            }
        }

        private void StudentPages_Activated(object sender, EventArgs e)
        {
            StudentDTO studentDTO = new StudentDTO();
            new StudentBusinessLogic().GetStudents(studentDTO);
            dgvStudents.DataSource = studentDTO.Students;
        }

        private void GridDesign()
        {
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AllowUserToResizeRows = false;
            dgvStudents.AllowUserToResizeColumns = false;
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.EnableHeadersVisualStyles = false;
            dgvStudents.ColumnHeadersDefaultCellStyle.SelectionBackColor = dgvStudents.ColumnHeadersDefaultCellStyle.BackColor;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
