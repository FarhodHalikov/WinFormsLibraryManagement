namespace Dark_Academy_Library
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addBookToolStripMenuItem = new ToolStripMenuItem();
            viewBookToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentInfoToolStripMenuItem = new ToolStripMenuItem();
            reportBookToolStripMenuItem = new ToolStripMenuItem();
            returnBookToolStripMenuItem = new ToolStripMenuItem();
            completeBookToolStripMenuItem = new ToolStripMenuItem();
            leaveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentToolStripMenuItem, reportBookToolStripMenuItem, returnBookToolStripMenuItem, completeBookToolStripMenuItem, leaveToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1117, 126);
            menuStrip1.TabIndex = 0;
            menuStrip1.TabStop = true;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.AutoSize = false;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addBookToolStripMenuItem, viewBookToolStripMenuItem });
            booksToolStripMenuItem.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(152, 100);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // addBookToolStripMenuItem
            // 
            addBookToolStripMenuItem.CheckOnClick = true;
            addBookToolStripMenuItem.Image = (Image)resources.GetObject("addBookToolStripMenuItem.Image");
            addBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            addBookToolStripMenuItem.Size = new Size(254, 56);
            addBookToolStripMenuItem.Text = "Add Book";
            addBookToolStripMenuItem.Click += addBookToolStripMenuItem_Click;
            // 
            // viewBookToolStripMenuItem
            // 
            viewBookToolStripMenuItem.Image = (Image)resources.GetObject("viewBookToolStripMenuItem.Image");
            viewBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            viewBookToolStripMenuItem.Size = new Size(254, 56);
            viewBookToolStripMenuItem.Text = "View Book";
            viewBookToolStripMenuItem.Click += viewBookToolStripMenuItem_Click;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentInfoToolStripMenuItem });
            studentToolStripMenuItem.Image = (Image)resources.GetObject("studentToolStripMenuItem.Image");
            studentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(163, 122);
            studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Image = (Image)resources.GetObject("addStudentToolStripMenuItem.Image");
            addStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(329, 56);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            viewStudentInfoToolStripMenuItem.Image = (Image)resources.GetObject("viewStudentInfoToolStripMenuItem.Image");
            viewStudentInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            viewStudentInfoToolStripMenuItem.Size = new Size(329, 56);
            viewStudentInfoToolStripMenuItem.Text = "View Student Info";
            viewStudentInfoToolStripMenuItem.Click += viewStudentInfoToolStripMenuItem_Click;
            // 
            // reportBookToolStripMenuItem
            // 
            reportBookToolStripMenuItem.Image = (Image)resources.GetObject("reportBookToolStripMenuItem.Image");
            reportBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            reportBookToolStripMenuItem.Name = "reportBookToolStripMenuItem";
            reportBookToolStripMenuItem.Size = new Size(216, 122);
            reportBookToolStripMenuItem.Text = "Report Book";
            // 
            // returnBookToolStripMenuItem
            // 
            returnBookToolStripMenuItem.Image = (Image)resources.GetObject("returnBookToolStripMenuItem.Image");
            returnBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            returnBookToolStripMenuItem.Size = new Size(214, 122);
            returnBookToolStripMenuItem.Text = "Return Book";
            // 
            // completeBookToolStripMenuItem
            // 
            completeBookToolStripMenuItem.Image = (Image)resources.GetObject("completeBookToolStripMenuItem.Image");
            completeBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            completeBookToolStripMenuItem.Name = "completeBookToolStripMenuItem";
            completeBookToolStripMenuItem.Size = new Size(217, 122);
            completeBookToolStripMenuItem.Text = "Book Details";
            // 
            // leaveToolStripMenuItem
            // 
            leaveToolStripMenuItem.Image = (Image)resources.GetObject("leaveToolStripMenuItem.Image");
            leaveToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            leaveToolStripMenuItem.Name = "leaveToolStripMenuItem";
            leaveToolStripMenuItem.Size = new Size(142, 122);
            leaveToolStripMenuItem.Text = "Leave";
            leaveToolStripMenuItem.Click += leaveToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(14, 122);
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(0, 129);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1117, 587);
            mainPanel.TabIndex = 2;
            mainPanel.Paint += panel1_Paint;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1117, 717);
            Controls.Add(mainPanel);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addBookToolStripMenuItem;
        private ToolStripMenuItem viewBookToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private ToolStripMenuItem reportBookToolStripMenuItem;
        private ToolStripMenuItem returnBookToolStripMenuItem;
        private ToolStripMenuItem completeBookToolStripMenuItem;
        private ToolStripMenuItem leaveToolStripMenuItem;
        private Panel mainPanel;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}