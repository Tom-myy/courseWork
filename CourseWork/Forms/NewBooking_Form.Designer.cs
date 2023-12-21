namespace CourseWork
{
    partial class NewBooking_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBooking_Form));
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox_eraser = new PictureBox();
            pictureBox_info = new PictureBox();
            pictureBox_refresh = new PictureBox();
            button_save = new Button();
            textBox_departureDate = new MaskedTextBox();
            textBox_arrivalDate = new MaskedTextBox();
            textBox_roomNumber = new ComboBox();
            textBox_countOfPeople = new TextBox();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            button_back = new PictureBox();
            textBox_Client = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button_back).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 47;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_eraser);
            panel1.Controls.Add(pictureBox_info);
            panel1.Controls.Add(pictureBox_refresh);
            panel1.Location = new Point(128, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 62);
            panel1.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(201, 23);
            label1.TabIndex = 5;
            label1.Text = "Creating a new booking :";
            // 
            // pictureBox_eraser
            // 
            pictureBox_eraser.Image = Properties.Resources.erase;
            pictureBox_eraser.Location = new Point(245, 12);
            pictureBox_eraser.Name = "pictureBox_eraser";
            pictureBox_eraser.Size = new Size(39, 34);
            pictureBox_eraser.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_eraser.TabIndex = 4;
            pictureBox_eraser.TabStop = false;
            pictureBox_eraser.Click += pictureBox_eraser_Click;
            // 
            // pictureBox_info
            // 
            pictureBox_info.Image = (Image)resources.GetObject("pictureBox_info.Image");
            pictureBox_info.Location = new Point(381, 12);
            pictureBox_info.Name = "pictureBox_info";
            pictureBox_info.Size = new Size(39, 34);
            pictureBox_info.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_info.TabIndex = 3;
            pictureBox_info.TabStop = false;
            pictureBox_info.Click += pictureBox_info_Click;
            // 
            // pictureBox_refresh
            // 
            pictureBox_refresh.Image = (Image)resources.GetObject("pictureBox_refresh.Image");
            pictureBox_refresh.Location = new Point(314, 12);
            pictureBox_refresh.Name = "pictureBox_refresh";
            pictureBox_refresh.Size = new Size(39, 34);
            pictureBox_refresh.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_refresh.TabIndex = 2;
            pictureBox_refresh.TabStop = false;
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 9.75F);
            button_save.Location = new Point(219, 283);
            button_save.Name = "button_save";
            button_save.Size = new Size(110, 41);
            button_save.TabIndex = 45;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textBox_departureDate
            // 
            textBox_departureDate.Location = new Point(263, 244);
            textBox_departureDate.Name = "textBox_departureDate";
            textBox_departureDate.Size = new Size(162, 23);
            textBox_departureDate.TabIndex = 72;
            // 
            // textBox_arrivalDate
            // 
            textBox_arrivalDate.Location = new Point(263, 215);
            textBox_arrivalDate.Name = "textBox_arrivalDate";
            textBox_arrivalDate.Size = new Size(162, 23);
            textBox_arrivalDate.TabIndex = 71;
            // 
            // textBox_roomNumber
            // 
            textBox_roomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_roomNumber.FormattingEnabled = true;
            textBox_roomNumber.Location = new Point(263, 186);
            textBox_roomNumber.Name = "textBox_roomNumber";
            textBox_roomNumber.Size = new Size(162, 23);
            textBox_roomNumber.TabIndex = 70;
            // 
            // textBox_countOfPeople
            // 
            textBox_countOfPeople.Location = new Point(263, 158);
            textBox_countOfPeople.Multiline = true;
            textBox_countOfPeople.Name = "textBox_countOfPeople";
            textBox_countOfPeople.Size = new Size(162, 22);
            textBox_countOfPeople.TabIndex = 68;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12.75F);
            label14.Location = new Point(122, 241);
            label14.Name = "label14";
            label14.Size = new Size(135, 23);
            label14.TabIndex = 67;
            label14.Text = "Departure date :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12.75F);
            label16.Location = new Point(151, 213);
            label16.Name = "label16";
            label16.Size = new Size(106, 23);
            label16.TabIndex = 66;
            label16.Text = "Arrival date :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12.75F);
            label17.Location = new Point(128, 185);
            label17.Name = "label17";
            label17.Size = new Size(129, 23);
            label17.TabIndex = 65;
            label17.Text = "Room number :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12.75F);
            label18.Location = new Point(194, 130);
            label18.Name = "label18";
            label18.Size = new Size(63, 23);
            label18.TabIndex = 64;
            label18.Text = "Client :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12.75F);
            label19.Location = new Point(114, 157);
            label19.Name = "label19";
            label19.Size = new Size(143, 23);
            label19.TabIndex = 63;
            label19.Text = "Count of people :";
            // 
            // button_back
            // 
            button_back.Image = (Image)resources.GetObject("button_back.Image");
            button_back.Location = new Point(12, 296);
            button_back.Name = "button_back";
            button_back.Size = new Size(82, 37);
            button_back.SizeMode = PictureBoxSizeMode.Zoom;
            button_back.TabIndex = 73;
            button_back.TabStop = false;
            button_back.Click += button_back_Click;
            // 
            // textBox_Client
            // 
            textBox_Client.FormattingEnabled = true;
            textBox_Client.Location = new Point(263, 130);
            textBox_Client.Name = "textBox_Client";
            textBox_Client.Size = new Size(162, 23);
            textBox_Client.TabIndex = 74;
            // 
            // NewBooking_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 345);
            Controls.Add(textBox_Client);
            Controls.Add(button_back);
            Controls.Add(textBox_departureDate);
            Controls.Add(textBox_arrivalDate);
            Controls.Add(textBox_roomNumber);
            Controls.Add(textBox_countOfPeople);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(button_save);
            Name = "NewBooking_Form";
            Text = "NewBooking_Form";
            Load += NewBooking_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)button_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox_eraser;
        private PictureBox pictureBox_info;
        private PictureBox pictureBox_refresh;
        private Button button_save;
        private MaskedTextBox textBox_departureDate;
        private MaskedTextBox textBox_arrivalDate;
        private ComboBox textBox_roomNumber;
        private TextBox textBox_countOfPeople;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private PictureBox button_back;
        private ComboBox textBox_Client;
    }
}