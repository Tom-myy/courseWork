namespace CourseWork.Forms
{
    partial class UsageServices_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsageServices_Form));
            label11 = new Label();
            panel4 = new Panel();
            button_save = new Button();
            button_newRegistration = new Button();
            button_delete = new Button();
            button_change = new Button();
            panel5 = new Panel();
            textBox_serviceName = new TextBox();
            textBox_serviceDescription = new TextBox();
            textBox_servicePrice = new TextBox();
            textBox_isActiv = new ComboBox();
            label10 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label17 = new Label();
            label19 = new Label();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBox_searchType = new ComboBox();
            pictureBox_eraser = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox_refresh = new PictureBox();
            textBox_search = new TextBox();
            dataGridView_UsageServices = new DataGridView();
            menuStrip1 = new MenuStrip();
            mainPageToolStripMenuItem = new ToolStripMenuItem();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_UsageServices).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(580, 321);
            label11.Name = "label11";
            label11.Size = new Size(161, 20);
            label11.TabIndex = 32;
            label11.Text = "Records management :";
            // 
            // panel4
            // 
            panel4.Controls.Add(button_save);
            panel4.Controls.Add(button_newRegistration);
            panel4.Controls.Add(button_delete);
            panel4.Controls.Add(button_change);
            panel4.Location = new Point(552, 344);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 175);
            panel4.TabIndex = 31;
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 9.75F);
            button_save.Location = new Point(55, 134);
            button_save.Name = "button_save";
            button_save.Size = new Size(113, 32);
            button_save.TabIndex = 3;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            // 
            // button_newRegistration
            // 
            button_newRegistration.Font = new Font("Segoe UI", 9.75F);
            button_newRegistration.Location = new Point(55, 11);
            button_newRegistration.Name = "button_newRegistration";
            button_newRegistration.Size = new Size(113, 32);
            button_newRegistration.TabIndex = 0;
            button_newRegistration.Text = "New service";
            button_newRegistration.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Segoe UI", 9.75F);
            button_delete.Location = new Point(55, 52);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(113, 32);
            button_delete.TabIndex = 1;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            // 
            // button_change
            // 
            button_change.Font = new Font("Segoe UI", 9.75F);
            button_change.Location = new Point(55, 93);
            button_change.Name = "button_change";
            button_change.Size = new Size(113, 32);
            button_change.TabIndex = 2;
            button_change.Text = "Change";
            button_change.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_serviceName);
            panel5.Controls.Add(textBox_serviceDescription);
            panel5.Controls.Add(textBox_servicePrice);
            panel5.Controls.Add(textBox_isActiv);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(55, 321);
            panel5.Name = "panel5";
            panel5.Size = new Size(466, 175);
            panel5.TabIndex = 30;
            // 
            // textBox_serviceName
            // 
            textBox_serviceName.Location = new Point(209, 34);
            textBox_serviceName.Name = "textBox_serviceName";
            textBox_serviceName.Size = new Size(162, 23);
            textBox_serviceName.TabIndex = 60;
            // 
            // textBox_serviceDescription
            // 
            textBox_serviceDescription.Location = new Point(209, 63);
            textBox_serviceDescription.Name = "textBox_serviceDescription";
            textBox_serviceDescription.Size = new Size(162, 23);
            textBox_serviceDescription.TabIndex = 59;
            // 
            // textBox_servicePrice
            // 
            textBox_servicePrice.Location = new Point(209, 92);
            textBox_servicePrice.Name = "textBox_servicePrice";
            textBox_servicePrice.Size = new Size(162, 23);
            textBox_servicePrice.TabIndex = 58;
            // 
            // textBox_isActiv
            // 
            textBox_isActiv.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_isActiv.FormattingEnabled = true;
            textBox_isActiv.Items.AddRange(new object[] { "True", "False" });
            textBox_isActiv.Location = new Point(209, 121);
            textBox_isActiv.Name = "textBox_isActiv";
            textBox_isActiv.Size = new Size(162, 23);
            textBox_isActiv.TabIndex = 57;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F);
            label10.Location = new Point(129, 118);
            label10.Name = "label10";
            label10.Size = new Size(74, 23);
            label10.TabIndex = 56;
            label10.Text = "Activity :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F);
            label5.Location = new Point(131, 34);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 53;
            label5.Text = "Service :";
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12.75F);
            label17.Location = new Point(147, 92);
            label17.Name = "label17";
            label17.Size = new Size(56, 23);
            label17.TabIndex = 4;
            label17.Text = "Price :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12.75F);
            label19.Location = new Point(98, 60);
            label19.Name = "label19";
            label19.Size = new Size(105, 23);
            label19.TabIndex = 2;
            label19.Text = "Description :";
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
            panel6.Location = new Point(0, 29);
            panel6.Name = "panel6";
            panel6.Size = new Size(841, 55);
            panel6.TabIndex = 29;
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
            label1.Size = new Size(139, 37);
            label1.TabIndex = 16;
            label1.Text = "Services...";
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
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(524, 16);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(164, 23);
            textBox_search.TabIndex = 0;
            // 
            // dataGridView_UsageServices
            // 
            dataGridView_UsageServices.AllowUserToAddRows = false;
            dataGridView_UsageServices.AllowUserToDeleteRows = false;
            dataGridView_UsageServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_UsageServices.Location = new Point(4, 88);
            dataGridView_UsageServices.Name = "dataGridView_UsageServices";
            dataGridView_UsageServices.ReadOnly = true;
            dataGridView_UsageServices.Size = new Size(830, 227);
            dataGridView_UsageServices.TabIndex = 28;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainPageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(842, 28);
            menuStrip1.TabIndex = 27;
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
            // UsageServices_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 532);
            Controls.Add(label11);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(dataGridView_UsageServices);
            Controls.Add(menuStrip1);
            Name = "UsageServices_Form";
            Text = "UsageServices_Form";
            Load += UsageServices_Form_Load;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView_UsageServices).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Panel panel4;
        private Button button_save;
        private Button button_newRegistration;
        private Button button_delete;
        private Button button_change;
        private Panel panel5;
        private TextBox textBox_serviceDescription;
        private TextBox textBox_servicePrice;
        private Label label10;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label17;
        private Label label19;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBox_searchType;
        private PictureBox pictureBox_eraser;
        private PictureBox pictureBox5;
        private PictureBox pictureBox_refresh;
        private TextBox textBox_search;
        private DataGridView dataGridView_UsageServices;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainPageToolStripMenuItem;
        private TextBox textBox_serviceName;
        private ComboBox textBox_isActiv;
    }
}