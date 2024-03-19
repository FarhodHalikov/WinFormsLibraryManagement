using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
namespace Dark_Academy_Library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_username_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txt_username_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.Clear();
            }
        }

        private void txt_password_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txt_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt_password.Text == "Password" || txt_password.Text == "")
            {
                txt_password.Clear();
                txt_password.PasswordChar = '•';
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var sqlConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\assignments\C#Winforms\Dark Academy Library\databases\darkacademy_db.mdf"";Integrated Security=True;Connect Timeout=30"
            };
            var sqlCommand = new SqlCommand
            {
                Connection = sqlConnection,
                CommandText = "SELECT * FROM login WHERE username ='" + txt_username.Text + "' AND password = '" + txt_password.Text + "'"
            };

            var dataAdapter = new SqlDataAdapter(sqlCommand);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                DashboardForm dashBoard = new();
                dashBoard.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}