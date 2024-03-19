using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Academy_Library
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_studentName.Clear();
            rbtn_female.Checked = false;
            rbtn_male.Checked = false;
            txt_enrollment.Clear();
            txt_department.Clear();
            //semester is missing
            txt_contact.Clear();
            txt_email.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Only if all the field are assigned, the insert to data is possbile
            if (txt_studentName.Text != "" && (rbtn_female.Checked == true || rbtn_male.Checked == true) && txt_enrollment.Text != "" && txt_department.Text != "" && cb_semester.Text != "" && txt_contact.Text != "" && txt_email.Text != "")
            {
                String studentName = txt_studentName.Text;
                String gender = rbtn_female.Checked == true ? "F" : "M";
                String enrollment = txt_enrollment.Text;
                String department = txt_department.Text;
                String semester = cb_semester.Text;
                Int64 contact = Int64.Parse(txt_contact.Text);
                String email = txt_email.Text;

                var sqlConnection = new SqlConnection
                {
                    ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
                };
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlCommand.CommandText = "SELECT * FROM NewStudent";
                sqlDataAdapter.Fill(dataSet);
                sqlCommand.CommandText = "INSERT INTO NewStudent (student_name, student_gender, enroll, department, semester, contact, email) values (@studentName, @gender ,@enrollment ,@department ,@semester, @contact, @email)";
                sqlCommand.Parameters.AddWithValue("@studentName", studentName);
                sqlCommand.Parameters.AddWithValue("@gender", gender);
                sqlCommand.Parameters.AddWithValue("@enrollment", enrollment);
                sqlCommand.Parameters.AddWithValue("@department", department);
                sqlCommand.Parameters.AddWithValue("@semester", semester);
                sqlCommand.Parameters.AddWithValue("@contact", contact);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("successful data upload", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
            }//Message if user forgot to assign any of the fields.
            else MessageBox.Show("All Fields must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
