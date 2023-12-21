namespace CourseWork.Forms
{
    partial class Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            label11 = new Label();
            panel4 = new Panel();
            button_save = new Button();
            button_delete = new Button();
            panel5 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_countOfPeople = new TextBox();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            label19 = new Label();
            panel6 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            comboBox_searchType = new ComboBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            textBox_search = new TextBox();
            dataGridView_registration = new DataGridView();
            menuStrip1 = new MenuStrip();
            mainPageToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label18 = new Label();
            textBox_Client = new TextBox();
            textBox1 = new TextBox();
            textBox_arrivalDate = new TextBox();
            textBox_departureDate = new TextBox();
            textBox_sumaOfLiving = new TextBox();
            textBox_sumaOfServices = new TextBox();
            textBox_totalSuma = new TextBox();
            textBox_idClient = new TextBox();
            label5 = new Label();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_registration).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label11.Location = new Point(518, 106);
            label11.Name = "label11";
            label11.Size = new Size(161, 20);
            label11.TabIndex = 26;
            label11.Text = "Records management :";
            // 
            // panel4
            // 
            panel4.Controls.Add(button_save);
            panel4.Controls.Add(button_delete);
            panel4.Location = new Point(490, 129);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 148);
            panel4.TabIndex = 25;
            panel4.Paint += panel4_Paint;
            // 
            // button_save
            // 
            button_save.Font = new Font("Segoe UI", 9.75F);
            button_save.Location = new Point(51, 94);
            button_save.Name = "button_save";
            button_save.Size = new Size(113, 32);
            button_save.TabIndex = 3;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Segoe UI", 9.75F);
            button_delete.Location = new Point(51, 12);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(113, 32);
            button_delete.TabIndex = 1;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(label11);
            panel5.Controls.Add(textBox_idClient);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBox_totalSuma);
            panel5.Controls.Add(textBox_sumaOfServices);
            panel5.Controls.Add(textBox_sumaOfLiving);
            panel5.Controls.Add(textBox_departureDate);
            panel5.Controls.Add(textBox_arrivalDate);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(textBox_Client);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(textBox_countOfPeople);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(57, 323);
            panel5.Name = "panel5";
            panel5.Size = new Size(764, 305);
            panel5.TabIndex = 24;
            panel5.Paint += panel5_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F);
            label4.Location = new Point(120, 271);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 52;
            label4.Text = "Total suma :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F);
            label3.Location = new Point(70, 244);
            label3.Name = "label3";
            label3.Size = new Size(151, 23);
            label3.TabIndex = 51;
            label3.Text = "Suma for services :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F);
            label2.Location = new Point(88, 217);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 50;
            label2.Text = "Suma for living :";
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
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(textBox_search);
            panel6.Location = new Point(2, 31);
            panel6.Name = "panel6";
            panel6.Size = new Size(841, 55);
            panel6.TabIndex = 23;
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
            label1.Size = new Size(133, 37);
            label1.TabIndex = 16;
            label1.Text = "Archive...";
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
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.erase;
            pictureBox4.Location = new Point(329, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 34);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
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
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(398, 11);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(39, 34);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
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
            dataGridView_registration.Location = new Point(6, 90);
            dataGridView_registration.Name = "dataGridView_registration";
            dataGridView_registration.ReadOnly = true;
            dataGridView_registration.Size = new Size(830, 227);
            dataGridView_registration.TabIndex = 22;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mainPageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(883, 28);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // mainPageToolStripMenuItem
            // 
            mainPageToolStripMenuItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            mainPageToolStripMenuItem.Size = new Size(90, 24);
            mainPageToolStripMenuItem.Text = "Main Page";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "Text";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(235, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 23);
            comboBox1.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.75F);
            label6.Location = new Point(114, 71);
            label6.Name = "label6";
            label6.Size = new Size(134, 23);
            label6.TabIndex = 58;
            label6.Text = "ID_Registration :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12.75F);
            label18.Location = new Point(140, 44);
            label18.Name = "label18";
            label18.Size = new Size(63, 23);
            label18.TabIndex = 3;
            label18.Text = "Client :";
            // 
            // textBox_Client
            // 
            textBox_Client.Location = new Point(235, 45);
            textBox_Client.Name = "textBox_Client";
            textBox_Client.Size = new Size(162, 23);
            textBox_Client.TabIndex = 60;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(162, 23);
            textBox1.TabIndex = 61;
            // 
            // textBox_arrivalDate
            // 
            textBox_arrivalDate.Location = new Point(230, 162);
            textBox_arrivalDate.Name = "textBox_arrivalDate";
            textBox_arrivalDate.Size = new Size(162, 23);
            textBox_arrivalDate.TabIndex = 62;
            // 
            // textBox_departureDate
            // 
            textBox_departureDate.Location = new Point(237, 192);
            textBox_departureDate.Name = "textBox_departureDate";
            textBox_departureDate.Size = new Size(162, 23);
            textBox_departureDate.TabIndex = 63;
            // 
            // textBox_sumaOfLiving
            // 
            textBox_sumaOfLiving.Location = new Point(230, 218);
            textBox_sumaOfLiving.Name = "textBox_sumaOfLiving";
            textBox_sumaOfLiving.Size = new Size(162, 23);
            textBox_sumaOfLiving.TabIndex = 64;
            // 
            // textBox_sumaOfServices
            // 
            textBox_sumaOfServices.Location = new Point(237, 248);
            textBox_sumaOfServices.Name = "textBox_sumaOfServices";
            textBox_sumaOfServices.Size = new Size(162, 23);
            textBox_sumaOfServices.TabIndex = 65;
            // 
            // textBox_totalSuma
            // 
            textBox_totalSuma.Location = new Point(237, 274);
            textBox_totalSuma.Name = "textBox_totalSuma";
            textBox_totalSuma.Size = new Size(162, 23);
            textBox_totalSuma.TabIndex = 66;
            // 
            // textBox_idClient
            // 
            textBox_idClient.Location = new Point(235, 17);
            textBox_idClient.Multiline = true;
            textBox_idClient.Name = "textBox_idClient";
            textBox_idClient.ReadOnly = true;
            textBox_idClient.Size = new Size(162, 22);
            textBox_idClient.TabIndex = 68;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F);
            label5.Location = new Point(142, 17);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 67;
            label5.Text = "ID_Client :";
            // 
            // Archive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 673);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(dataGridView_registration);
            Controls.Add(menuStrip1);
            Name = "Archive";
            Text = "Archive";
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_registration).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Panel panel4;
        private Button button_save;
        private Button button_delete;
        private Panel panel5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox_countOfPeople;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label19;
        private Panel panel6;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBox_searchType;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox textBox_search;
        private DataGridView dataGridView_registration;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mainPageToolStripMenuItem;
        private ComboBox comboBox1;
        private Label label6;
        private Label label18;
        private TextBox textBox_totalSuma;
        private TextBox textBox_sumaOfServices;
        private TextBox textBox_sumaOfLiving;
        private TextBox textBox_departureDate;
        private TextBox textBox_arrivalDate;
        private TextBox textBox1;
        private TextBox textBox_Client;
        private TextBox textBox_idClient;
        private Label label5;
    }
}