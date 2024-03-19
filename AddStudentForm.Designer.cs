namespace Dark_Academy_Library
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            panel1 = new Panel();
            btn_exit = new Button();
            lblAddStudent = new Label();
            pictureBox2 = new PictureBox();
            btn_refresh = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            cb_semester = new ComboBox();
            rbtn_female = new RadioButton();
            rbtn_male = new RadioButton();
            label7 = new Label();
            txt_email = new TextBox();
            label6 = new Label();
            txt_contact = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_department = new TextBox();
            label3 = new Label();
            txt_enrollment = new TextBox();
            label1 = new Label();
            txt_studentName = new TextBox();
            label2 = new Label();
            btn_save = new Button();
            btn_delete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(lblAddStudent);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 83);
            panel1.TabIndex = 3;
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
            // lblAddStudent
            // 
            lblAddStudent.AutoSize = true;
            lblAddStudent.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddStudent.Location = new Point(88, 24);
            lblAddStudent.Name = "lblAddStudent";
            lblAddStudent.Size = new Size(162, 35);
            lblAddStudent.TabIndex = 4;
            lblAddStudent.Text = "Add Student";
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
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.Black;
            btn_refresh.FlatStyle = FlatStyle.Popup;
            btn_refresh.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_refresh.ForeColor = Color.White;
            btn_refresh.Location = new Point(599, 99);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(120, 50);
            btn_refresh.TabIndex = 6;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(cb_semester);
            panel2.Controls.Add(btn_refresh);
            panel2.Controls.Add(rbtn_female);
            panel2.Controls.Add(rbtn_male);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_email);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_contact);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txt_department);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_enrollment);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_studentName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_save);
            panel2.Controls.Add(btn_delete);
            panel2.Location = new Point(333, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(754, 432);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // cb_semester
            // 
            cb_semester.FormattingEnabled = true;
            cb_semester.Items.AddRange(new object[] { "IT", "Business", "Logistics" });
            cb_semester.Location = new Point(243, 254);
            cb_semester.Name = "cb_semester";
            cb_semester.Size = new Size(231, 28);
            cb_semester.TabIndex = 45;
            // 
            // rbtn_female
            // 
            rbtn_female.AutoSize = true;
            rbtn_female.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_female.Location = new Point(339, 83);
            rbtn_female.Name = "rbtn_female";
            rbtn_female.Size = new Size(115, 39);
            rbtn_female.TabIndex = 44;
            rbtn_female.TabStop = true;
            rbtn_female.Text = "Female";
            rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_male
            // 
            rbtn_male.AutoSize = true;
            rbtn_male.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            rbtn_male.Location = new Point(243, 83);
            rbtn_male.Name = "rbtn_male";
            rbtn_male.Size = new Size(90, 39);
            rbtn_male.TabIndex = 43;
            rbtn_male.TabStop = true;
            rbtn_male.Text = "Male";
            rbtn_male.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gray;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(24, 70);
            label7.Name = "label7";
            label7.Size = new Size(98, 37);
            label7.TabIndex = 42;
            label7.Text = "Gender";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(243, 367);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(231, 27);
            txt_email.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gray;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(24, 357);
            label6.Name = "label6";
            label6.Size = new Size(77, 37);
            label6.TabIndex = 40;
            label6.Text = "Email";
            // 
            // txt_contact
            // 
            txt_contact.Location = new Point(243, 316);
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(231, 27);
            txt_contact.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gray;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 306);
            label5.Name = "label5";
            label5.Size = new Size(102, 37);
            label5.TabIndex = 38;
            label5.Text = "Contact";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gray;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 245);
            label4.Name = "label4";
            label4.Size = new Size(119, 37);
            label4.TabIndex = 36;
            label4.Text = "Semester";
            // 
            // txt_department
            // 
            txt_department.Location = new Point(243, 198);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(231, 27);
            txt_department.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(24, 188);
            label3.Name = "label3";
            label3.Size = new Size(150, 37);
            label3.TabIndex = 34;
            label3.Text = "Department";
            // 
            // txt_enrollment
            // 
            txt_enrollment.Location = new Point(243, 143);
            txt_enrollment.Name = "txt_enrollment";
            txt_enrollment.Size = new Size(231, 27);
            txt_enrollment.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 133);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 32;
            label1.Text = "Enrollment No";
            // 
            // txt_studentName
            // 
            txt_studentName.Location = new Point(243, 24);
            txt_studentName.Name = "txt_studentName";
            txt_studentName.Size = new Size(231, 27);
            txt_studentName.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 14);
            label2.Name = "label2";
            label2.Size = new Size(175, 37);
            label2.TabIndex = 30;
            label2.Text = "Student Name";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Black;
            btn_save.FlatStyle = FlatStyle.Popup;
            btn_save.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(599, 176);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(120, 49);
            btn_save.TabIndex = 27;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Black;
            btn_delete.FlatStyle = FlatStyle.Popup;
            btn_delete.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(599, 245);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(120, 49);
            btn_delete.TabIndex = 28;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 540);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            Load += AddStudentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_exit;
        private Button btn_refresh;
        private Label lblAddStudent;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btn_save;
        private Button btn_delete;
        private TextBox txt_email;
        private Label label6;
        private TextBox txt_contact;
        private Label label5;
        private Label label4;
        private TextBox txt_department;
        private Label label3;
        private TextBox txt_enrollment;
        private Label label1;
        private TextBox txt_studentName;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private ComboBox cb_semester;
        private RadioButton rbtn_female;
        private RadioButton rbtn_male;
    }
}