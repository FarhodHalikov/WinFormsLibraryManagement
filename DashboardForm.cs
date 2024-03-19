using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark_Academy_Library
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            menuStrip1.BringToFront();
            menuStrip1.Visible = true;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormManager.Instance.OpenChildForm<AddBooksForm>(mainPanel);
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Singleton realisation for creating only one object of each Form
            ChildFormManager.Instance.OpenChildForm<ViewBookForm>(mainPanel);
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormManager.Instance.OpenChildForm<AddStudentForm>(mainPanel);
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildFormManager.Instance.OpenChildForm<ViewStudentForm>(mainPanel);
        }
    }
}
