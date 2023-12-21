namespace CourseWork
{
    partial class NewRegistration_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRegistration_Form));
            button_back = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox_eraser = new PictureBox();
            pictureBox_info = new PictureBox();
            pictureBox_refresh = new PictureBox();
            button_save = new Button();
            textBox_idBooking = new ComboBox();
            label5 = new Label();
            textBox_Client = new ComboBox();
            textBox_departureDate = new MaskedTextBox();
            textBox_roomNumber = new ComboBox();
            label14 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            textBox_countOfPeople = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)button_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textBox_countOfPeople).BeginInit();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Image = (Image)resources.GetObject("button_back.Image");
            button_back.Location = new Point(19, 291);
            button_back.Name = "button_back";
            button_back.Size = new Size(82, 37);
            button_back.SizeMode = PictureBoxSizeMode.Zoom;
            button_back.TabIndex = 78;
            button_back.TabStop = false;
            button_back.Click += button_back_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(8, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 77;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_eraser);
            panel1.Controls.Add(pictureBox_info);
            panel1.Controls.Add(pictureBox_refresh);
            panel1.Location = new Point(130, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 62);
            panel1.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F);
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(226, 23);
            label1.TabIndex = 5;
            label1.Text = "Creating a new registration :";
            // 
            // pictureBox_eraser
            // 
            pictureBox_eraser.Image = Properties.Resources.erase;
            pictureBox_eraser.Location = new Point(245, 10);
            pictureBox_eraser.Name = "pictureBox_eraser";
            pictureBox_eraser.Size = new Size(39, 34);
            pictureBox_eraser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_eraser.TabIndex = 4;
            pictureBox_eraser.TabStop = false;
            // 
            // pictureBox_info
            // 
            pictureBox_info.Image = (Image)resources.GetObject("pictureBox_info.Image");
            pictureBox_info.Location = new Point(381, 10);
            pictureBox_info.Name = "pictureBox_info";
            pictureBox_info.Size = new Size(39, 34);
            pictureBox_info.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_info.TabIndex = 3;
            pictureBox_info.TabStop = false;
            // 
            // pictureBox_refresh
            // 
            pictureBox_refresh.Image = (Image)resources.GetObject("pictureBox_refresh.Image");
            pictureBox_refresh.Location = new Point(314, 10);
            pictureBox_refresh.Name = "pictureBox_refresh";
            pictureBox_refresh.Size = new Size(39, 34);
            pictureBox_refresh.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_refresh.TabIndex = 2;
            pictureBox_refresh.TabStop = false;
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 9.75F);
            button_save.Location = new Point(233, 277);
            button_save.Name = "button_save";
            button_save.Size = new Size(110, 41);
            button_save.TabIndex = 75;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textBox_idBooking
            // 
            textBox_idBooking.DisplayMember = "Text";
            textBox_idBooking.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_idBooking.FormattingEnabled = true;
            textBox_idBooking.Location = new Point(272, 122);
            textBox_idBooking.Name = "textBox_idBooking";
            textBox_idBooking.Size = new Size(162, 23);
            textBox_idBooking.TabIndex = 95;
            textBox_idBooking.SelectedIndexChanged += textBox_idBooking_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F);
            label5.Location = new Point(151, 119);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 94;
            label5.Text = "ID_Booking :";
            // 
            // textBox_Client
            // 
            textBox_Client.DisplayMember = "Text";
            textBox_Client.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_Client.FormattingEnabled = true;
            textBox_Client.Location = new Point(272, 152);
            textBox_Client.Name = "textBox_Client";
            textBox_Client.Size = new Size(162, 23);
            textBox_Client.TabIndex = 90;
            // 
            // textBox_departureDate
            // 
            textBox_departureDate.Location = new Point(272, 238);
            textBox_departureDate.Name = "textBox_departureDate";
            textBox_departureDate.Size = new Size(162, 23);
            textBox_departureDate.TabIndex = 89;
            // 
            // textBox_roomNumber
            // 
            textBox_roomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_roomNumber.FormattingEnabled = true;
            textBox_roomNumber.Location = new Point(272, 181);
            textBox_roomNumber.Name = "textBox_roomNumber";
            textBox_roomNumber.Size = new Size(162, 23);
            textBox_roomNumber.TabIndex = 87;
            textBox_roomNumber.SelectedIndexChanged += textBox_roomNumber_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12.75F);
            label14.Location = new Point(123, 237);
            label14.Name = "label14";
            label14.Size = new Size(135, 23);
            label14.TabIndex = 84;
            label14.Text = "Departure date :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12.75F);
            label17.Location = new Point(129, 179);
            label17.Name = "label17";
            label17.Size = new Size(129, 23);
            label17.TabIndex = 82;
            label17.Text = "Room number :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12.75F);
            label18.Location = new Point(195, 151);
            label18.Name = "label18";
            label18.Size = new Size(63, 23);
            label18.TabIndex = 81;
            label18.Text = "Client :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12.75F);
            label19.Location = new Point(115, 208);
            label19.Name = "label19";
            label19.Size = new Size(143, 23);
            label19.TabIndex = 80;
            label19.Text = "Count of people :";
            // 
            // textBox_countOfPeople
            // 
            textBox_countOfPeople.Location = new Point(272, 210);
            textBox_countOfPeople.Name = "textBox_countOfPeople";
            textBox_countOfPeople.Size = new Size(162, 23);
            textBox_countOfPeople.TabIndex = 96;
            // 
            // NewRegistration_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 338);
            Controls.Add(textBox_countOfPeople);
            Controls.Add(textBox_idBooking);
            Controls.Add(label5);
            Controls.Add(textBox_Client);
            Controls.Add(textBox_departureDate);
            Controls.Add(textBox_roomNumber);
            Controls.Add(label14);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(button_back);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(button_save);
            Name = "NewRegistration_Form";
            Text = "NewRegistration_Form";
            Load += NewRegistration_Form_Load;
            ((System.ComponentModel.ISupportInitialize)button_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)textBox_countOfPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox button_back;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox_eraser;
        private PictureBox pictureBox_info;
        private PictureBox pictureBox_refresh;
        private Button button_save;
        private ComboBox textBox_idBooking;
        private Label label5;
        private ComboBox textBox_Client;
        private MaskedTextBox textBox_departureDate;
        private ComboBox textBox_roomNumber;
        private Label label14;
        private Label label17;
        private Label label18;
        private Label label19;
        private NumericUpDown textBox_countOfPeople;
    }
}