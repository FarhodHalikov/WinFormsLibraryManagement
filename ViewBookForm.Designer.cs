namespace Dark_Academy_Library
{
    partial class ViewBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookForm));
            panel1 = new Panel();
            btn_exit = new Button();
            btn_refresh = new Button();
            txt_searchBook = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            dtp_purchaseDate = new DateTimePicker();
            txt_amount = new TextBox();
            btn_Update = new Button();
            txt_publication = new TextBox();
            btn_Delete = new Button();
            txt_author = new TextBox();
            btn_cancel = new Button();
            txt_price = new TextBox();
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
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(btn_refresh);
            panel1.Controls.Add(txt_searchBook);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1092, 83);
            panel1.TabIndex = 2;
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
            btn_refresh.Location = new Point(490, 15);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(120, 50);
            btn_refresh.TabIndex = 6;
            btn_refresh.Text = "Refresh";
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // txt_searchBook
            // 
            txt_searchBook.Location = new Point(234, 32);
            txt_searchBook.Name = "txt_searchBook";
            txt_searchBook.Size = new Size(231, 27);
            txt_searchBook.TabIndex = 5;
            txt_searchBook.TextChanged += txt_searchBook_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 24);
            label1.Name = "label1";
            label1.Size = new Size(140, 35);
            label1.TabIndex = 4;
            label1.Text = "View Book";
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
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(5, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(1075, 475);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Controls.Add(dtp_purchaseDate);
            panel3.Controls.Add(txt_amount);
            panel3.Controls.Add(btn_Update);
            panel3.Controls.Add(txt_publication);
            panel3.Controls.Add(btn_Delete);
            panel3.Controls.Add(txt_author);
            panel3.Controls.Add(btn_cancel);
            panel3.Controls.Add(txt_price);
            panel3.Controls.Add(txt_studentName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(10, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(1074, 221);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // dtp_purchaseDate
            // 
            dtp_purchaseDate.Location = new Point(762, 9);
            dtp_purchaseDate.Name = "dtp_purchaseDate";
            dtp_purchaseDate.Size = new Size(231, 27);
            dtp_purchaseDate.TabIndex = 31;
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(762, 124);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(231, 27);
            txt_amount.TabIndex = 30;
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
            // txt_publication
            // 
            txt_publication.Location = new Point(240, 124);
            txt_publication.Name = "txt_publication";
            txt_publication.Size = new Size(231, 27);
            txt_publication.TabIndex = 29;
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
            // txt_author
            // 
            txt_author.Location = new Point(240, 73);
            txt_author.Name = "txt_author";
            txt_author.Size = new Size(231, 27);
            txt_author.TabIndex = 28;
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
            btn_cancel.Click += btn_cancel_Click_1;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(762, 72);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(231, 27);
            txt_price.TabIndex = 28;
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
            label6.Size = new Size(191, 37);
            label6.TabIndex = 23;
            label6.Text = "Overall Amount";
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
            label7.Size = new Size(71, 37);
            label7.TabIndex = 22;
            label7.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.WindowFrame;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 63);
            label5.Name = "label5";
            label5.Size = new Size(93, 37);
            label5.TabIndex = 21;
            label5.Text = "Author";
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
            label4.Size = new Size(203, 37);
            label4.TabIndex = 20;
            label4.Text = "Book Publication";
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
            label3.Size = new Size(176, 37);
            label3.TabIndex = 19;
            label3.Text = "Purchase Date";
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
            label2.Size = new Size(147, 37);
            label2.TabIndex = 6;
            label2.Text = "Book Name";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1065, 242);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ViewBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1092, 593);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBookForm";
            Text = "ViewBookForm";
            Load += ViewBookForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox txt_viewBook;
        private Button btn_refresh;
        private Panel panel2;
        private Button btn_close;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Label label2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_amount;
        private TextBox txt_publication;
        private TextBox txt_author;
        private TextBox txt_price;
        private TextBox txt_studentName;
        private Button btn_cancel;
        private Button btn_Delete;
        private Button btn_Update;
        private Label label6;
        private DateTimePicker dtp_purchaseDate;
        private TextBox txt_searchBook;
        private Button btn_exit;
    }
}