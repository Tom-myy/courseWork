namespace CourseWork
{
    partial class Registration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_Form));
            menuStrip1 = new MenuStrip();
            mainPageToolStripMenuItem = new ToolStripMenuItem();
            label11 = new Label();
            panel4 = new Panel();
            button_newClient = new Button();
            button_save = new Button();
            button_newRegistration = new Button();
            button_delete = new Button();
            button_change = new Button();
            panel5 = new Panel();
            textBox_idBooking = new ComboBox();
            label5 = new Label();
            textBox_Client = new ComboBox();
            textBox_departureDate = new MaskedTextBox();
            textBox_arrivalDate = new MaskedTextBox();
            textBox_roomNumber = new ComboBox();
            pictureBox3 = new PictureBox();
            textBox_countOfPeople = new TextBox();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBox_searchType = new ComboBox();
            pictureBox_eraser = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox_refresh = new PictureBox();
            textBox_search = new TextBox();
            dataGridView_registration = new DataGridView();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_registration).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainPageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(836, 28);
            menuStrip1.TabIndex = 1;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(573, 332);
            label11.Name = "label11";
            label11.Size = new Size(161, 20);
            label11.TabIndex = 20;
            label11.Text = "Records management :";
            // 
            // panel4
            // 
            panel4.Controls.Add(button_newClient);
            panel4.Controls.Add(button_save);
            panel4.Controls.Add(button_newRegistration);
            panel4.Controls.Add(button_delete);
            panel4.Controls.Add(button_change);
            panel4.Location = new Point(545, 355);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 222);
            panel4.TabIndex = 19;
            // 
            // button_newClient
            // 
            button_newClient.Font = new Font("Segoe UI", 9.75F);
            button_newClient.Location = new Point(60, 12);
            button_newClient.Name = "button_newClient";
            button_newClient.Size = new Size(113, 32);
            button_newClient.TabIndex = 4;
            button_newClient.Text = "New client";
            button_newClient.UseVisualStyleBackColor = true;
            button_newClient.Click += button_newClient_Click;
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 9.75F);
            button_save.Location = new Point(60, 176);
            button_save.Name = "button_save";
            button_save.Size = new Size(113, 32);
            button_save.TabIndex = 3;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            // 
            // button_newRegistration
            // 
            button_newRegistration.Font = new Font("Segoe UI", 9.75F);
            button_newRegistration.Location = new Point(60, 53);
            button_newRegistration.Name = "button_newRegistration";
            button_newRegistration.Size = new Size(113, 32);
            button_newRegistration.TabIndex = 0;
            button_newRegistration.Text = "New registration";
            button_newRegistration.UseVisualStyleBackColor = true;
            button_newRegistration.Click += button_newBooking_Click;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Segoe UI", 9.75F);
            button_delete.Location = new Point(60, 94);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(113, 32);
            button_delete.TabIndex = 1;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            // 
            // button_change
            // 
            button_change.Font = new Font("Segoe UI", 9.75F);
            button_change.Location = new Point(60, 135);
            button_change.Name = "button_change";
            button_change.Size = new Size(113, 32);
            button_change.TabIndex = 2;
            button_change.Text = "Change";
            button_change.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_idBooking);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBox_Client);
            panel5.Controls.Add(textBox_departureDate);
            panel5.Controls.Add(textBox_arrivalDate);
            panel5.Controls.Add(textBox_roomNumber);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(textBox_countOfPeople);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(55, 323);
            panel5.Name = "panel5";
            panel5.Size = new Size(466, 267);
            panel5.TabIndex = 18;
            // 
            // textBox_idBooking
            // 
            textBox_idBooking.DisplayMember = "Text";
            textBox_idBooking.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_idBooking.FormattingEnabled = true;
            textBox_idBooking.Location = new Point(235, 44);
            textBox_idBooking.Name = "textBox_idBooking";
            textBox_idBooking.Size = new Size(162, 23);
            textBox_idBooking.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F);
            label5.Location = new Point(114, 41);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 53;
            label5.Text = "ID_Booking :";
            // 
            // textBox_Client
            // 
            textBox_Client.DisplayMember = "Text";
            textBox_Client.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_Client.FormattingEnabled = true;
            textBox_Client.Location = new Point(235, 74);
            textBox_Client.Name = "textBox_Client";
            textBox_Client.Size = new Size(162, 23);
            textBox_Client.TabIndex = 49;
            // 
            // textBox_departureDate
            // 
            textBox_departureDate.Location = new Point(235, 189);
            textBox_departureDate.Name = "textBox_departureDate";
            textBox_departureDate.Size = new Size(162, 23);
            textBox_departureDate.TabIndex = 48;
            // 
            // textBox_arrivalDate
            // 
            textBox_arrivalDate.Location = new Point(235, 160);
            textBox_arrivalDate.Name = "textBox_arrivalDate";
            textBox_arrivalDate.Size = new Size(162, 23);
            textBox_arrivalDate.TabIndex = 47;
            // 
            // textBox_roomNumber
            // 
            textBox_roomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_roomNumber.FormattingEnabled = true;
            textBox_roomNumber.Location = new Point(235, 131);
            textBox_roomNumber.Name = "textBox_roomNumber";
            textBox_roomNumber.Size = new Size(162, 23);
            textBox_roomNumber.TabIndex = 46;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.records;
            pictureBox3.Location = new Point(12, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // textBox_countOfPeople
            // 
            textBox_countOfPeople.Location = new Point(235, 103);
            textBox_countOfPeople.Multiline = true;
            textBox_countOfPeople.Name = "textBox_countOfPeople";
            textBox_countOfPeople.Size = new Size(162, 22);
            textBox_countOfPeople.TabIndex = 17;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12.75F);
            label14.Location = new Point(86, 188);
            label14.Name = "label14";
            label14.Size = new Size(135, 23);
            label14.TabIndex = 7;
            label14.Text = "Departure date :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12.75F);
            label16.Location = new Point(115, 157);
            label16.Name = "label16";
            label16.Size = new Size(106, 23);
            label16.TabIndex = 5;
            label16.Text = "Arrival date :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12.75F);
            label17.Location = new Point(92, 129);
            label17.Name = "label17";
            label17.Size = new Size(129, 23);
            label17.TabIndex = 4;
            label17.Text = "Room number :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12.75F);
            label18.Location = new Point(158, 73);
            label18.Name = "label18";
            label18.Size = new Size(63, 23);
            label18.TabIndex = 3;
            label18.Text = "Client :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12.75F);
            label19.Location = new Point(78, 101);
            label19.Name = "label19";
            label19.Size = new Size(143, 23);
            label19.TabIndex = 2;
            label19.Text = "Count of people :";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(comboBox_searchType);
            panel6.Controls.Add(pictureBox_eraser);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(pictureBox_refresh);
            panel6.Controls.Add(textBox_search);
            panel6.Location = new Point(0, 31);
            panel6.Name = "panel6";
            panel6.Size = new Size(841, 55);
            panel6.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(110, 15);
            label1.Name = "label1";
            label1.Size = new Size(194, 37);
            label1.TabIndex = 16;
            label1.Text = "Registration...";
            // 
            // comboBox_searchType
            // 
            comboBox_searchType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_searchType.FormattingEnabled = true;
            comboBox_searchType.Items.AddRange(new object[] { "Client", "Count of people", "Room number", "arrivalDate", "departureDate" });
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
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(465, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(39, 34);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
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
            // 
            // dataGridView_registration
            // 
            dataGridView_registration.AllowUserToAddRows = false;
            dataGridView_registration.AllowUserToDeleteRows = false;
            dataGridView_registration.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_registration.Location = new Point(4, 90);
            dataGridView_registration.Name = "dataGridView_registration";
            dataGridView_registration.ReadOnly = true;
            dataGridView_registration.Size = new Size(830, 227);
            dataGridView_registration.TabIndex = 16;
            dataGridView_registration.CellClick += dataGridView_registration_CellClick;
            // 
            // Registration_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 630);
            Controls.Add(label11);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(dataGridView_registration);
            Controls.Add(menuStrip1);
            Name = "Registration_Form";
            Text = "Registration_Form";
            Load += Registration_Form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_registration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainPageToolStripMenuItem;
        private Label label11;
        private Panel panel4;
        private Button button_newClient;
        private Button button_save;
        private Button button_newRegistration;
        private Button button_delete;
        private Button button_change;
        private Panel panel5;
        private ComboBox textBox_Client;
        private MaskedTextBox textBox_departureDate;
        private MaskedTextBox textBox_arrivalDate;
        private ComboBox textBox_roomNumber;
        private PictureBox pictureBox3;
        private TextBox textBox_countOfPeople;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBox_searchType;
        private PictureBox pictureBox_eraser;
        private PictureBox pictureBox5;
        private PictureBox pictureBox_refresh;
        private TextBox textBox_search;
        private DataGridView dataGridView_registration;
        private Label label5;
        private ComboBox textBox_idBooking;
    }
}