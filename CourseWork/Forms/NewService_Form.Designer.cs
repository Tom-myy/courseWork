namespace CourseWork.Forms
{
    partial class NewService_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewService_Form));
            button_back = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox_eraser = new PictureBox();
            pictureBox_info = new PictureBox();
            pictureBox_refresh = new PictureBox();
            button_save = new Button();
            textBox_serviceName = new TextBox();
            textBox_serviceDescription = new TextBox();
            textBox_servicePrice = new TextBox();
            textBox_isActiv = new ComboBox();
            label10 = new Label();
            label5 = new Label();
            label17 = new Label();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)button_back).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_info).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).BeginInit();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Image = (Image)resources.GetObject("button_back.Image");
            button_back.Location = new Point(13, 283);
            button_back.Name = "button_back";
            button_back.Size = new Size(82, 37);
            button_back.SizeMode = PictureBoxSizeMode.Zoom;
            button_back.TabIndex = 94;
            button_back.TabStop = false;
            button_back.Click += button_back_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 8);
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
            panel1.Location = new Point(129, 10);
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
            button_save.Location = new Point(227, 269);
            button_save.Name = "button_save";
            button_save.Size = new Size(110, 41);
            button_save.TabIndex = 75;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // textBox_serviceName
            // 
            textBox_serviceName.Location = new Point(240, 127);
            textBox_serviceName.Name = "textBox_serviceName";
            textBox_serviceName.Size = new Size(162, 23);
            textBox_serviceName.TabIndex = 102;
            // 
            // textBox_serviceDescription
            // 
            textBox_serviceDescription.Location = new Point(240, 156);
            textBox_serviceDescription.Name = "textBox_serviceDescription";
            textBox_serviceDescription.Size = new Size(162, 23);
            textBox_serviceDescription.TabIndex = 101;
            // 
            // textBox_servicePrice
            // 
            textBox_servicePrice.Location = new Point(240, 185);
            textBox_servicePrice.Name = "textBox_servicePrice";
            textBox_servicePrice.Size = new Size(162, 23);
            textBox_servicePrice.TabIndex = 100;
            // 
            // textBox_isActiv
            // 
            textBox_isActiv.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_isActiv.FormattingEnabled = true;
            textBox_isActiv.Items.AddRange(new object[] { "True", "False" });
            textBox_isActiv.Location = new Point(240, 214);
            textBox_isActiv.Name = "textBox_isActiv";
            textBox_isActiv.Size = new Size(162, 23);
            textBox_isActiv.TabIndex = 99;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F);
            label10.Location = new Point(160, 211);
            label10.Name = "label10";
            label10.Size = new Size(74, 23);
            label10.TabIndex = 98;
            label10.Text = "Activity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F);
            label5.Location = new Point(162, 127);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 97;
            label5.Text = "Service :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12.75F);
            label17.Location = new Point(178, 185);
            label17.Name = "label17";
            label17.Size = new Size(56, 23);
            label17.TabIndex = 96;
            label17.Text = "Price :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12.75F);
            label19.Location = new Point(129, 153);
            label19.Name = "label19";
            label19.Size = new Size(105, 23);
            label19.TabIndex = 95;
            label19.Text = "Description :";
            // 
            // NewService_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 333);
            Controls.Add(textBox_serviceName);
            Controls.Add(textBox_serviceDescription);
            Controls.Add(textBox_servicePrice);
            Controls.Add(textBox_isActiv);
            Controls.Add(label10);
            Controls.Add(label5);
            Controls.Add(label17);
            Controls.Add(label19);
            Controls.Add(button_back);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(button_save);
            Name = "NewService_Form";
            Text = "NewService_Form";
            ((System.ComponentModel.ISupportInitialize)button_back).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_info).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).EndInit();
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
        private TextBox textBox_serviceName;
        private TextBox textBox_serviceDescription;
        private TextBox textBox_servicePrice;
        private ComboBox textBox_isActiv;
        private Label label10;
        private Label label5;
        private Label label17;
        private Label label19;
    }
}