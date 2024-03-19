namespace Dark_Academy_Library
{
    partial class ViewStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentForm));
            panel1 = new Panel();
            label8 = new Label();
            btn_exit = new Button();
            btn_refresh = new Button();
            txt_searchStudent = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            txt_gender = new TextBox();
            txt_semester = new TextBox();
            txt_email = new TextBox();
            label9 = new Label();
            txt_contact = new TextBox();
            btn_Update = new Button();
            txt_enrollment = new TextBox();
            btn_Delete = new Button();
            btn_cancel = new Button();
            txt_department = new TextBox();
            txt_studentName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(btn_refresh);
            panel1.Controls.Add(txt_searchStudent);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 83);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(362, 24);
            label8.Name = "label8";
            label8.Size = new Size(186, 35);
            label8.TabIndex = 11;
            label8.Text = "Enrollment No";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.White;
            btn_exit.BackgroundImage = (Image)resources.GetObject("btn_exit.BackgroundImage");
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(996, 5);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(84, 69);
            btn_exit.TabIndex = 10;
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.Black;
            btn_refresh.FlatStyle = FlatStyle.Popup;
            btn_refresh.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_refresh.ForeColor = Color.White;
            btn_refresh.Location = new Point(858, 15);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(120, 50);
            btn_refresh.TabIndex = 6;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // txt_searchStudent
            // 
            txt_searchStudent.Location = new Point(554, 32);
            txt_searchStudent.Name = "txt_searchStudent";
            txt_searchStudent.Size = new Size(231, 27);
            txt_searchStudent.TabIndex = 5;
            txt_searchStudent.TextChanged += txt_searchStudent_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 24);
            label1.Name = "label1";
            label1.Size = new Size(172, 35);
            label1.TabIndex = 4;
            label1.Text = "View Student";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(txt_gender);
            panel3.Controls.Add(txt_semester);
            panel3.Controls.Add(txt_email);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txt_contact);
            panel3.Controls.Add(btn_Update);
            panel3.Controls.Add(txt_enrollment);
            panel3.Controls.Add(btn_Delete);
            panel3.Controls.Add(btn_cancel);
            panel3.Controls.Add(txt_department);
            panel3.Controls.Add(txt_studentName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(6, 371);
            panel3.Name = "panel3";
            panel3.Size = new Size(1074, 221);
            panel3.TabIndex = 12;
            panel3.Paint += panel3_Paint;
            // 
            // txt_gender
            // 
            txt_gender.Location = new Point(240, 71);
            txt_gender.Name = "txt_gender";
            txt_gender.Size = new Size(231, 27);
            txt_gender.TabIndex = 49;
            // 
            // txt_semester
            // 
            txt_semester.Location = new Point(762, 74);
            txt_semester.Name = "txt_semester";
            txt_semester.Size = new Size(231, 27);
            txt_semester.TabIndex = 48;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(240, 172);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(231, 27);
            txt_email.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.WindowFrame;
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(21, 163);
            label9.Name = "label9";
            label9.Size = new Size(77, 37);
            label9.TabIndex = 32;
            label9.Text = "Email";
            // 
            // txt_contact
            // 
            txt_contact.Location = new Point(762, 124);
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(231, 27);
            txt_contact.TabIndex = 30;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.Black;
            btn_Update.FlatStyle = FlatStyle.Popup;
            btn_Update.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(624, 163);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(143, 55);
            btn_Update.TabIndex = 24;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // txt_enrollment
            // 
            txt_enrollment.Location = new Point(240, 124);
            txt_enrollment.Name = "txt_enrollment";
            txt_enrollment.Size = new Size(231, 27);
            txt_enrollment.TabIndex = 29;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.Black;
            btn_Delete.FlatStyle = FlatStyle.Popup;
            btn_Delete.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(773, 163);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(143, 55);
            btn_Delete.TabIndex = 25;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Black;
            btn_cancel.FlatStyle = FlatStyle.Popup;
            btn_cancel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancel.ForeColor = Color.White;
            btn_cancel.Location = new Point(922, 163);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(143, 55);
            btn_cancel.TabIndex = 26;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // txt_department
            // 
            txt_department.Location = new Point(762, 19);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(231, 27);
            txt_department.TabIndex = 28;
            // 
            // txt_studentName
            // 
            txt_studentName.Location = new Point(240, 19);
            txt_studentName.Name = "txt_studentName";
            txt_studentName.Size = new Size(231, 27);
            txt_studentName.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.WindowFrame;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(559, 115);
            label6.Name = "label6";
            label6.Size = new Size(102, 37);
            label6.TabIndex = 23;
            label6.Text = "Contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.WindowFrame;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(559, 63);
            label7.Name = "label7";
            label7.Size = new Size(119, 37);
            label7.TabIndex = 22;
            label7.Text = "Semester";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowFrame;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 62);
            label5.Name = "label5";
            label5.Size = new Size(98, 37);
            label5.TabIndex = 21;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.WindowFrame;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 115);
            label4.Name = "label4";
            label4.Size = new Size(178, 37);
            label4.TabIndex = 20;
            label4.Text = "Enrollment No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(559, 9);
            label3.Name = "label3";
            label3.Size = new Size(150, 37);
            label3.TabIndex = 19;
            label3.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 9);
            label2.Name = "label2";
            label2.Size = new Size(175, 37);
            label2.TabIndex = 6;
            label2.Text = "Student Name";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1065, 276);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ViewStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 593);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewStudentForm";
            Text = "ViewStudentForm";
            Load += ViewStudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_exit;
        private Button btn_refresh;
        private TextBox txt_searchStudent;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel3;
        private TextBox txt_contact;
        private Button btn_Update;
        private TextBox txt_enrollment;
        private Button btn_Delete;
        private Button btn_cancel;
        private TextBox txt_department;
        private TextBox txt_studentName;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label8;
        private Label label9;
        private TextBox txt_semester;
        private TextBox txt_email;
        private TextBox txt_gender;
    }
}