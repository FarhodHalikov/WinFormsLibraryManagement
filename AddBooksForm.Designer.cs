namespace Dark_Academy_Library
{
    partial class AddBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooksForm));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btn_exit = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btn_save = new Button();
            panel2 = new Panel();
            dtp_purchaseDate = new DateTimePicker();
            txt_amount = new MaskedTextBox();
            txt_price = new MaskedTextBox();
            txt_publication = new MaskedTextBox();
            txt_author = new MaskedTextBox();
            txt_bookName = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 495);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 83);
            panel1.TabIndex = 1;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.White;
            btn_exit.BackgroundImage = (Image)resources.GetObject("btn_exit.BackgroundImage");
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(1021, 5);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(84, 69);
            btn_exit.TabIndex = 13;
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 26);
            label1.Name = "label1";
            label1.Size = new Size(130, 35);
            label1.TabIndex = 4;
            label1.Text = "Add Book";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(5, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Black;
            btn_save.FlatStyle = FlatStyle.Popup;
            btn_save.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(357, 395);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(143, 55);
            btn_save.TabIndex = 12;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Controls.Add(dtp_purchaseDate);
            panel2.Controls.Add(txt_amount);
            panel2.Controls.Add(txt_price);
            panel2.Controls.Add(btn_save);
            panel2.Controls.Add(txt_publication);
            panel2.Controls.Add(txt_author);
            panel2.Controls.Add(txt_bookName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(234, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 495);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // dtp_purchaseDate
            // 
            dtp_purchaseDate.Location = new Point(265, 212);
            dtp_purchaseDate.Name = "dtp_purchaseDate";
            dtp_purchaseDate.Size = new Size(432, 27);
            dtp_purchaseDate.TabIndex = 24;
            dtp_purchaseDate.ValueChanged += dtp_purchaseDate_ValueChanged;
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(265, 334);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(432, 27);
            txt_amount.TabIndex = 23;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(265, 273);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(432, 27);
            txt_price.TabIndex = 22;
            // 
            // txt_publication
            // 
            txt_publication.Location = new Point(265, 150);
            txt_publication.Name = "txt_publication";
            txt_publication.Size = new Size(432, 27);
            txt_publication.TabIndex = 21;
            // 
            // txt_author
            // 
            txt_author.Location = new Point(265, 88);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(432, 27);
            txt_author.TabIndex = 20;
            // 
            // txt_bookName
            // 
            txt_bookName.Location = new Point(265, 27);
            txt_bookName.Name = "txt_bookName";
            txt_bookName.Size = new Size(432, 27);
            txt_bookName.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 264);
            label7.Name = "label7";
            label7.Size = new Size(71, 37);
            label7.TabIndex = 18;
            label7.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 324);
            label6.Name = "label6";
            label6.Size = new Size(191, 37);
            label6.TabIndex = 17;
            label6.Text = "Overall Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 78);
            label5.Name = "label5";
            label5.Size = new Size(93, 37);
            label5.TabIndex = 16;
            label5.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 141);
            label4.Name = "label4";
            label4.Size = new Size(203, 37);
            label4.TabIndex = 15;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 202);
            label3.Name = "label3";
            label3.Size = new Size(176, 37);
            label3.TabIndex = 14;
            label3.Text = "Purchase Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 18);
            label2.Name = "label2";
            label2.Size = new Size(147, 37);
            label2.TabIndex = 5;
            label2.Text = "Book Name";
            // 
            // AddBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1117, 587);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBooksForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Button btn_save;
        private MaskedTextBox txt_bookName;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtp_purchaseDate;
        private MaskedTextBox txt_amount;
        private MaskedTextBox txt_price;
        private MaskedTextBox txt_publication;
        private MaskedTextBox txt_author;
        private Button btn_exit;
    }
}