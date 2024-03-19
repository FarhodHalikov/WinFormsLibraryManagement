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
    public partial class ViewBookForm : Form
    {
        public ViewBookForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewBookForm_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            var sqlConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
            };
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM NewBook";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int bookId;
        Int64 rowId;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bookId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(());
            }
            panel3.Visible = true;
            var sqlConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
            };
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM NewBook WHERE book_id = " + bookId + "";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            rowId = Int64.Parse(dataSet.Tables[0].Rows[0][0].ToString());
            txt_studentName.Text = dataSet.Tables[0].Rows[0][1].ToString();
            txt_author.Text = dataSet.Tables[0].Rows[0][2].ToString();
            txt_publication.Text = dataSet.Tables[0].Rows[0][3].ToString();
            txt_price.Text = dataSet.Tables[0].Rows[0][4].ToString();
            txt_amount.Text = dataSet.Tables[0].Rows[0][5].ToString();
            dtp_purchaseDate.Text = dataSet.Tables[0].Rows[0][6].ToString();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void txt_searchBook_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchBook.Text != "")
            {
                var sqlConnection = new SqlConnection
                {
                    ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
                };
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM NewBook WHERE book_name LIKE '" + txt_searchBook.Text + "%'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                var sqlConnection = new SqlConnection
                {
                    ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
                };
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM NewBook";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_searchBook.Clear();

            panel3.Visible = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be changed. Confirm?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bookName = txt_studentName.Text;
                String bookAuthor = txt_author.Text;
                String bookPublication = txt_publication.Text;
                String purchaseDate = dtp_purchaseDate.Text;
                Int64 price = Int64.Parse(txt_price.Text);
                Int64 amount = Int64.Parse(txt_amount.Text);

                var sqlConnection = new SqlConnection
                {
                    ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
                };
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                string updateQuery = "UPDATE NewBook SET book_name = @bookName, book_author = @bookAuthor, book_publication = @bookPublication, book_price = @price, book_amount = @amount, book_publication_date = @purchaseDate WHERE book_Id = @rowId";
                sqlCommand.CommandText = updateQuery;
                sqlCommand.Parameters.AddWithValue("@bookName", bookName);
                sqlCommand.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                sqlCommand.Parameters.AddWithValue("@bookPublication", bookPublication);
                sqlCommand.Parameters.AddWithValue("@price", price);
                sqlCommand.Parameters.AddWithValue("@amount", amount);
                sqlCommand.Parameters.AddWithValue("@purchaseDate", purchaseDate);
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
            string selectQuery = "SELECT * FROM NewBook";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectQuery, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            // Clear the existing data source of the DataGridView
            dataGridView1.DataSource = null;

            // Set the updated data as the new data source of your DataGridView
            dataGridView1.DataSource = dataSet.Tables[0];
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
                sqlCommand.CommandText = "DELETE FROM NewBook WHERE book_id=" + rowId + "";
                sqlCommand.Connection = sqlConnection;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                RemoveDeletedRow();
                RefreshDataGridView();
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
