namespace CourseWork
{
    partial class NewClient_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewClient_Form));
            button_save = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox_eraser = new PictureBox();
            pictureBox_info = new PictureBox();
            pictureBox_refresh = new PictureBox();
            pictureBox3 = new PictureBox();
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
            textBox_bithday = new MaskedTextBox();
            textBox_gender = new ComboBox();
            button_back = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button_back).BeginInit();
            SuspendLayout();
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 9.75F);
            button_save.Location = new Point(223, 359);
            button_save.Name = "button_save";
            button_save.Size = new Size(110, 41);
            button_save.TabIndex = 21;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox_eraser);
            panel1.Controls.Add(pictureBox_info);
            panel1.Controls.Add(pictureBox_refresh);
            panel1.Location = new Point(131, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 62);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F);
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(180, 23);
            label1.TabIndex = 5;
            label1.Text = "Creating a new client :";
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
            pictureBox_eraser.Click += pictureBox_eraser_Click;
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
            pictureBox_info.Click += pictureBox_info_Click;
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
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 107);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // textBox_surname
            // 
            textBox_surname.Location = new Point(263, 142);
            textBox_surname.Multiline = true;
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(162, 22);
            textBox_surname.TabIndex = 41;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Location = new Point(263, 167);
            textBox_firstName.Multiline = true;
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(162, 22);
            textBox_firstName.TabIndex = 40;
            // 
            // textBox_middleName
            // 
            textBox_middleName.Location = new Point(263, 192);
            textBox_middleName.Multiline = true;
            textBox_middleName.Name = "textBox_middleName";
            textBox_middleName.Size = new Size(162, 22);
            textBox_middleName.TabIndex = 39;
            // 
            // textBox_clientAddress
            // 
            textBox_clientAddress.Location = new Point(263, 267);
            textBox_clientAddress.Multiline = true;
            textBox_clientAddress.Name = "textBox_clientAddress";
            textBox_clientAddress.Size = new Size(162, 22);
            textBox_clientAddress.TabIndex = 36;
            // 
            // textBox_clientPhoneNumber
            // 
            textBox_clientPhoneNumber.Location = new Point(263, 293);
            textBox_clientPhoneNumber.Multiline = true;
            textBox_clientPhoneNumber.Name = "textBox_clientPhoneNumber";
            textBox_clientPhoneNumber.Size = new Size(162, 22);
            textBox_clientPhoneNumber.TabIndex = 35;
            // 
            // textBox_clientPassportNumber
            // 
            textBox_clientPassportNumber.Location = new Point(263, 319);
            textBox_clientPassportNumber.Multiline = true;
            textBox_clientPassportNumber.Name = "textBox_clientPassportNumber";
            textBox_clientPassportNumber.Size = new Size(162, 22);
            textBox_clientPassportNumber.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F);
            label10.Location = new Point(109, 316);
            label10.Name = "label10";
            label10.Size = new Size(148, 23);
            label10.TabIndex = 33;
            label10.Text = "Passport number :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.75F);
            label9.Location = new Point(124, 290);
            label9.Name = "label9";
            label9.Size = new Size(133, 23);
            label9.TabIndex = 32;
            label9.Text = "Phone number :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12.75F);
            label8.Location = new Point(178, 264);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 31;
            label8.Text = "Address :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.75F);
            label7.Location = new Point(182, 239);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 30;
            label7.Text = "Gender :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F);
            label6.Location = new Point(175, 216);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 29;
            label6.Text = "Birthday :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F);
            label5.Location = new Point(138, 191);
            label5.Name = "label5";
            label5.Size = new Size(119, 23);
            label5.TabIndex = 28;
            label5.Text = "Middle name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F);
            label4.Location = new Point(170, 140);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 27;
            label4.Text = "Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F);
            label3.Location = new Point(192, 165);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 26;
            label3.Text = "Name :";
            // 
            // textBox_bithday
            // 
            textBox_bithday.Location = new Point(263, 217);
            textBox_bithday.Name = "textBox_bithday";
            textBox_bithday.Size = new Size(162, 23);
            textBox_bithday.TabIndex = 43;
            // 
            // textBox_gender
            // 
            textBox_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_gender.FormattingEnabled = true;
            textBox_gender.Items.AddRange(new object[] { "Чол", "Жін" });
            textBox_gender.Location = new Point(263, 242);
            textBox_gender.Name = "textBox_gender";
            textBox_gender.Size = new Size(162, 23);
            textBox_gender.TabIndex = 44;
            // 
            // button_back
            // 
            button_back.Image = (Image)resources.GetObject("button_back.Image");
            button_back.Location = new Point(9, 373);
            button_back.Name = "button_back";
            button_back.Size = new Size(82, 37);
            button_back.SizeMode = PictureBoxSizeMode.Zoom;
            button_back.TabIndex = 74;
            button_back.TabStop = false;
            button_back.Click += button_back_Click_1;
            // 
            // NewClient_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 422);
            Controls.Add(button_back);
            Controls.Add(textBox_gender);
            Controls.Add(textBox_bithday);
            Controls.Add(textBox_surname);
            Controls.Add(textBox_firstName);
            Controls.Add(textBox_middleName);
            Controls.Add(textBox_clientAddress);
            Controls.Add(textBox_clientPhoneNumber);
            Controls.Add(textBox_clientPassportNumber);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(button_save);
            Name = "NewClient_Form";
            Text = "NewClientForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)button_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_save;
        private Panel panel1;
        private PictureBox pictureBox_eraser;
        private PictureBox pictureBox_refresh;
        private PictureBox pictureBox_info;
        private PictureBox pictureBox3;
        private Label label1;
        private TextBox textBox_surname;
        private TextBox textBox_firstName;
        private TextBox textBox_middleName;
        private TextBox textBox_clientAddress;
        private TextBox textBox_clientPhoneNumber;
        private TextBox textBox_clientPassportNumber;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private MaskedTextBox textBox_bithday;
        private ComboBox textBox_gender;
        private PictureBox button_back;
    }
}