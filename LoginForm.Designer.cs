namespace Dark_Academy_Library
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            txt_username = new TextBox();
            txt_password = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_login = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(151, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txt_username
            // 
            txt_username.BorderStyle = BorderStyle.None;
            txt_username.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txt_username.Location = new Point(160, 230);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(204, 34);
            txt_username.TabIndex = 1;
            txt_username.Text = "Username";
            txt_username.TextAlign = HorizontalAlignment.Center;
            txt_username.MouseClick += txt_username_MouseClick;
            txt_username.MouseEnter += txt_username_MouseEnter;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(160, 328);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '•';
            txt_password.Size = new Size(204, 34);
            txt_password.TabIndex = 2;
            txt_password.Text = "Password";
            txt_password.TextAlign = HorizontalAlignment.Center;
            txt_password.MouseClick += txt_password_MouseClick;
            txt_password.TextChanged += txt_password_TextChanged;
            txt_password.MouseEnter += txt_password_MouseEnter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(61, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(61, 300);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(93, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Black;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(151, 403);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(143, 55);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(160, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 1);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(160, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 1);
            panel2.TabIndex = 8;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.White;
            btn_exit.BackgroundImage = (Image)resources.GetObject("btn_exit.BackgroundImage");
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(351, 0);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(84, 69);
            btn_exit.TabIndex = 9;
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(436, 508);
            Controls.Add(btn_exit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_login);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "w";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_username;
        private TextBox txt_password;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btn_login;
        private Panel panel1;
        private Panel panel2;
        private Button btn_exit;
    }
}