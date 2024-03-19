using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Academy_Library
{
    public partial class ViewStudentForm : Form
    {
        public ViewStudentForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            panel3.Hide();
        }

        private void ViewStudentForm_Load(object sender, EventArgs e)
        {
            panel3.Hide();
            SqlConnection sqlConnection = new SqlConnection
            {
                @ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\assignments\\C#Winforms\\Dark Academy Library\\databases\\darkacademy_db.mdf\";Integrated Security=True;Connect Timeout=30"
            };
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM NewStudent";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void txt_searchStudent_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchStudent.Text != "")
            {
                SqlConnection sqlConnection = new SqlConnection
                {
                    @ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\assignments\\C#Winforms\\Dark Academy Library\\databases\\darkacademy_db.mdf\";Integrated Security=True;Connect Timeout=30"
                };
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                //Search Command
                sqlCommand.CommandText = "SELECT * FROM NewStudent WHERE enroll LIKE '" + txt_searchStudent.Text + "%' ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                SqlConnection sqlConnection = new SqlConnection
                {
                    @ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\assignments\\C#Winforms\\Dark Academy Library\\databases\\darkacademy_db.mdf\";Integrated Security=True;Connect Timeout=30"
                };
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM NewStudent";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];

            }
        }
        int studentId;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                studentId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel3.Visible = true;
            SqlConnection sqlConnection = new SqlConnection
            {
                @ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\assignments\\C#Winforms\\Dark Academy Library\\databases\\darkacademy_db.mdf\";Integrated Security=True;Connect Timeout=30"
            };
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM NewStudent WHERE Id = " + studentId + "";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            rowId = Int64.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            txt_studentName.Text = dataSet.Tables[0].Rows[0][1].ToString();
            txt_gender.Text = dataSet.Tables[0].Rows[0][2].ToString();
            txt_enrollment.Text = dataSet.Tables[0].Rows[0][3].ToString();
            txt_department.Text = dataSet.Tables[0].Rows[0][4].ToString();
            txt_semester.Text = dataSet.Tables[0].Rows[0][5].ToString();
            txt_contact.Text = dataSet.Tables[0].Rows[0][6].ToString();
            txt_email.Text = dataSet.Tables[0].Rows[0][7].ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RemoveDeletedRow()
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Remove the selected row(s) from the DataGridView
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
        private void RefreshDataGridView()
        {
            var sqlConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
            };

            // Fetch the updated data from the database
            string selectQuery = "SELECT * FROM NewStudent";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Clear the existing data source of the DataGridView
            dataGridView1.DataSource = null;

            // Set the updated data as the new data source of your DataGridView
            dataGridView1.DataSource = dataSet.Tables[0];
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Data will be changed. Confirm?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String studentName = txt_studentName.Text;
                String gender = txt_gender.Text;
                String enroll = txt_enrollment.Text;
                String department = txt_department.Text;
                String semester = txt_semester.Text;
                String contact = txt_contact.Text;
                String email = txt_email.Text;

                var sqlConnection = new SqlConnection
                {
                    ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
                };
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                string updateQuery = "UPDATE NewStudent SET student_name = @studentName, student_gender = @gender, enroll = @enroll, department = @department, semester = @semester, contact = @contact, email = @email WHERE Id = @rowId";
                sqlCommand.CommandText = updateQuery;
                sqlCommand.Parameters.AddWithValue("@studentName", studentName);
                sqlCommand.Parameters.AddWithValue("@gender", gender);
                sqlCommand.Parameters.AddWithValue("@enroll", enroll);
                sqlCommand.Parameters.AddWithValue("@department", department);
                sqlCommand.Parameters.AddWithValue("@semester", semester);
                sqlCommand.Parameters.AddWithValue("@contact", contact);
                sqlCommand.Parameters.AddWithValue("@email", email);
                sqlCommand.Parameters.AddWithValue("@rowId", rowId);
                sqlConnection.Open();
                int rowsAffected = sqlCommand.ExecuteNonQuery();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                sqlConnection.Close();
                RefreshDataGridView();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted. Confirm?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var sqlConnection = new SqlConnection
                {
                    ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
                };
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "DELETE FROM NewStudent WHERE Id=" + rowId + "";
                sqlCommand.Connection = sqlConnection;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                RemoveDeletedRow();
                RefreshDataGridView();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_searchStudent.Clear();

            panel3.Visible = false;
        }
    }

}
