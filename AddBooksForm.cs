using System;
using System.Collections.Generic;
using System.ComponentModel;
using global::System.Data;
using global::System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Academy_Library
{
    public partial class AddBooksForm : Form
    {
        public AddBooksForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //If condition for the case "User is not assigning all the fields required
            //Since in data base we have NOT NULL properties, so to speak, every field has to be assigned
            if (txt_bookName.Text != "" && txt_author.Text != "" && txt_publication.Text != "" && txt_price.Text != "" && txt_amount.Text != "")
            {
                //Variables assigning
                String bookName = txt_bookName.Text;
                String bookAuthor = txt_author.Text;
                String bookPublication = txt_publication.Text;
                String purchaseDate = dtp_purchaseDate.Text;
                Int64 price = Int64.Parse(txt_price.Text);
                Int64 amount = Int64.Parse(txt_amount.Text);

                //Database Connection
                var sqlConnection = new SqlConnection
                {
                    ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
                };

                sqlConnection.Open();
                var sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO NewBook (book_name, book_author, book_publication, book_price, book_amount, book_publication_date) values (@bookName, @bookAuthor ,@bookPublication ,@price ,@amount, @purchaseDate )";
                sqlCommand.Parameters.AddWithValue("@bookName", bookName);
                sqlCommand.Parameters.AddWithValue("@bookAuthor", bookAuthor);
                sqlCommand.Parameters.AddWithValue("@bookPublication", bookPublication);
                sqlCommand.Parameters.AddWithValue("@price", price);
                sqlCommand.Parameters.AddWithValue("@amount", amount);
                sqlCommand.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Data Saved!", "Successful data Upload", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Clearing the fields for the next input after the data is saved properly
                txt_bookName.Clear();
                txt_author.Clear();
                txt_publication.Clear();
                txt_price.Clear();
                txt_amount.Clear();
            }
            else MessageBox.Show("All fields must be assigned!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_purchaseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
