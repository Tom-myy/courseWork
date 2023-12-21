namespace CourseWork
{
    partial class Client_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_Form));
            menuStrip1 = new MenuStrip();
            mainPageToolStripMenuItem = new ToolStripMenuItem();
            dataGridView_Clients = new DataGridView();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            label11 = new Label();
            comboBox_searchType = new ComboBox();
            pictureBox_eraser = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox_refresh = new PictureBox();
            textBox_search = new TextBox();
            panel2 = new Panel();
            textBox_gender = new ComboBox();
            textBox_bithday = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            textBox_idClient = new TextBox();
            textBox_surname = new TextBox();
            textBox_firstName = new TextBox();
            textBox_middleName = new TextBox();
            textBox_clientAddress = new TextBox();
            textBox_clientPhoneNumber = new TextBox();
            textBox_clientPassportNumber = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            button_save = new Button();
            button_change = new Button();
            button_delete = new Button();
            button_newClient = new Button();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clients).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainPageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(797, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainPageToolStripMenuItem
            // 
            mainPageToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            mainPageToolStripMenuItem.Size = new Size(90, 24);
            mainPageToolStripMenuItem.Text = "Main Page";
            mainPageToolStripMenuItem.Click += mainPageToolStripMenuItem_Click;
            // 
            // dataGridView_Clients
            // 
            dataGridView_Clients.AllowUserToAddRows = false;
            dataGridView_Clients.AllowUserToDeleteRows = false;
            dataGridView_Clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clients.Location = new Point(4, 90);
            dataGridView_Clients.Name = "dataGridView_Clients";
            dataGridView_Clients.ReadOnly = true;
            dataGridView_Clients.Size = new Size(786, 226);
            dataGridView_Clients.TabIndex = 1;
            dataGridView_Clients.CellClick += dataGridView_Clients_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(comboBox_searchType);
            panel1.Controls.Add(pictureBox_eraser);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox_refresh);
            panel1.Controls.Add(textBox_search);
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 56);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.client;
            pictureBox3.Location = new Point(8, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label11.Location = new Point(114, 16);
            label11.Name = "label11";
            label11.Size = new Size(125, 37);
            label11.TabIndex = 6;
            label11.Text = "Clients...";
            // 
            // comboBox_searchType
            // 
            comboBox_searchType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_searchType.FormattingEnabled = true;
            comboBox_searchType.Items.AddRange(new object[] { "Surname", "Name", "Middle name", "Birthday", "Gender", "Address", "Phone number", "Passport number" });
            comboBox_searchType.Location = new Point(694, 16);
            comboBox_searchType.Name = "comboBox_searchType";
            comboBox_searchType.Size = new Size(81, 23);
            comboBox_searchType.TabIndex = 5;
            // 
            // pictureBox_eraser
            // 
            pictureBox_eraser.Image = Properties.Resources.erase;
            pictureBox_eraser.Location = new Point(329, 11);
            pictureBox_eraser.Name = "pictureBox_eraser";
            pictureBox_eraser.Size = new Size(39, 34);
            pictureBox_eraser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_eraser.TabIndex = 4;
            pictureBox_eraser.TabStop = false;
            pictureBox_eraser.Click += pictureBox_eraser_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(465, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox_refresh
            // 
            pictureBox_refresh.Image = (Image)resources.GetObject("pictureBox_refresh.Image");
            pictureBox_refresh.Location = new Point(398, 11);
            pictureBox_refresh.Name = "pictureBox_refresh";
            pictureBox_refresh.Size = new Size(39, 34);
            pictureBox_refresh.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_refresh.TabIndex = 2;
            pictureBox_refresh.TabStop = false;
            pictureBox_refresh.Click += pictureBox_refresh_Click;
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(524, 16);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(164, 23);
            textBox_search.TabIndex = 0;
            textBox_search.TextChanged += textBox_search_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_gender);
            panel2.Controls.Add(textBox_bithday);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox_idClient);
            panel2.Controls.Add(textBox_surname);
            panel2.Controls.Add(textBox_firstName);
            panel2.Controls.Add(textBox_middleName);
            panel2.Controls.Add(textBox_clientAddress);
            panel2.Controls.Add(textBox_clientPhoneNumber);
            panel2.Controls.Add(textBox_clientPassportNumber);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(25, 322);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 249);
            panel2.TabIndex = 3;
            // 
            // textBox_gender
            // 
            textBox_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_gender.FormattingEnabled = true;
            textBox_gender.Items.AddRange(new object[] { "Чол", "Жін" });
            textBox_gender.Location = new Point(255, 140);
            textBox_gender.Name = "textBox_gender";
            textBox_gender.Size = new Size(162, 23);
            textBox_gender.TabIndex = 46;
            // 
            // textBox_bithday
            // 
            textBox_bithday.Location = new Point(255, 115);
            textBox_bithday.Name = "textBox_bithday";
            textBox_bithday.Size = new Size(162, 23);
            textBox_bithday.TabIndex = 45;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.records;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // textBox_idClient
            // 
            textBox_idClient.Location = new Point(255, 16);
            textBox_idClient.Multiline = true;
            textBox_idClient.Name = "textBox_idClient";
            textBox_idClient.ReadOnly = true;
            textBox_idClient.Size = new Size(162, 22);
            textBox_idClient.TabIndex = 19;
            // 
            // textBox_surname
            // 
            textBox_surname.Location = new Point(255, 41);
            textBox_surname.Multiline = true;
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(162, 22);
            textBox_surname.TabIndex = 18;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(255, 66);
            textBox_firstName.Multiline = true;
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(162, 22);
            textBox_firstName.TabIndex = 17;
            // 
            // textBox_middleName
            // 
            textBox_middleName.Location = new Point(255, 91);
            textBox_middleName.Multiline = true;
            textBox_middleName.Name = "textBox_middleName";
            textBox_middleName.Size = new Size(162, 22);
            textBox_middleName.TabIndex = 16;
            // 
            // textBox_clientAddress
            // 
            textBox_clientAddress.Location = new Point(255, 166);
            textBox_clientAddress.Multiline = true;
            textBox_clientAddress.Name = "textBox_clientAddress";
            textBox_clientAddress.Size = new Size(162, 22);
            textBox_clientAddress.TabIndex = 13;
            // 
            // textBox_clientPhoneNumber
            // 
            textBox_clientPhoneNumber.Location = new Point(255, 192);
            textBox_clientPhoneNumber.Multiline = true;
            textBox_clientPhoneNumber.Name = "textBox_clientPhoneNumber";
            textBox_clientPhoneNumber.Size = new Size(162, 22);
            textBox_clientPhoneNumber.TabIndex = 12;
            // 
            // textBox_clientPassportNumber
            // 
            textBox_clientPassportNumber.Location = new Point(255, 218);
            textBox_clientPassportNumber.Multiline = true;
            textBox_clientPassportNumber.Name = "textBox_clientPassportNumber";
            textBox_clientPassportNumber.Size = new Size(162, 22);
            textBox_clientPassportNumber.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F);
            label10.Location = new Point(101, 215);
            label10.Name = "label10";
            label10.Size = new Size(148, 23);
            label10.TabIndex = 9;
            label10.Text = "Passport number :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.75F);
            label9.Location = new Point(116, 189);
            label9.Name = "label9";
            label9.Size = new Size(133, 23);
            label9.TabIndex = 8;
            label9.Text = "Phone number :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12.75F);
            label8.Location = new Point(170, 163);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 7;
            label8.Text = "Address :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.75F);
            label7.Location = new Point(174, 138);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 6;
            label7.Text = "Gender :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F);
            label6.Location = new Point(167, 115);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 5;
            label6.Text = "Birthday :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F);
            label5.Location = new Point(130, 90);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 4;
            label5.Text = "Middle name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F);
            label4.Location = new Point(162, 39);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 3;
            label4.Text = "Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F);
            label3.Location = new Point(184, 64);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 2;
            label3.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F);
            label2.Location = new Point(162, 16);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 1;
            label2.Text = "ID_Client :";
            // 
            // panel3
            // 
            panel3.Controls.Add(button_save);
            panel3.Controls.Add(button_change);
            panel3.Controls.Add(button_delete);
            panel3.Controls.Add(button_newClient);
            panel3.Location = new Point(539, 349);
            panel3.Name = "panel3";
            panel3.Size = new Size(186, 222);
            panel3.TabIndex = 4;
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 9.75F);
            button_save.Location = new Point(39, 168);
            button_save.Name = "button_save";
            button_save.Size = new Size(110, 41);
            button_save.TabIndex = 3;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_change
            // 
            button_change.Font = new Font("Segoe UI", 9.75F);
            button_change.Location = new Point(39, 116);
            button_change.Name = "button_change";
            button_change.Size = new Size(110, 41);
            button_change.TabIndex = 2;
            button_change.Text = "Change";
            button_change.UseVisualStyleBackColor = true;
            button_change.Click += button_change_Click;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Segoe UI", 9.75F);
            button_delete.Location = new Point(39, 64);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(110, 41);
            button_delete.TabIndex = 1;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_newClient
            // 
            button_newClient.Font = new Font("Segoe UI", 9.75F);
            button_newClient.Location = new Point(39, 12);
            button_newClient.Name = "button_newClient";
            button_newClient.Size = new Size(110, 41);
            button_newClient.TabIndex = 0;
            button_newClient.Text = "New client";
            button_newClient.UseVisualStyleBackColor = true;
            button_newClient.Click += button_newClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(551, 326);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 5;
            label1.Text = "Records management :";
            // 
            // Client_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 583);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView_Clients);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Client_Form";
            Text = "ClientForm";
            Load += ClientForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clients).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainPageToolStripMenuItem;
        private DataGridView dataGridView_Clients;
        private Panel panel1;
        private TextBox textBox_search;
        private Panel panel2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private TextBox textBox_firstName;
        private TextBox textBox_middleName;
        private TextBox textBox_clientAddress;
        private TextBox textBox_clientPhoneNumber;
        private TextBox textBox_clientPassportNumber;
        private TextBox textBox_idClient;
        private TextBox textBox_surname;
        private Button button_newClient;
        private Button button_save;
        private Button button_change;
        private Button button_delete;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox_refresh;
        private PictureBox pictureBox_eraser;
        private ComboBox comboBox_searchType;
        private ComboBox textBox_gender;
        private MaskedTextBox textBox_bithday;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label11;
        private PictureBox pictureBox3;
    }
}