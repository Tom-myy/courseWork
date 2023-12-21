namespace CourseWork
{
    partial class RoomType_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomType_Form));
            menuStrip = new MenuStrip();
            mainPageToolStripMenuItem = new ToolStripMenuItem();
            Type = new TabControl();
            tabPage_Room = new TabPage();
            label1 = new Label();
            panel3 = new Panel();
            button_save = new Button();
            button_change = new Button();
            button_delete = new Button();
            button_newClient = new Button();
            panel2 = new Panel();
            textBox_R_typeName = new ComboBox();
            textBox_R_floor = new ComboBox();
            textBox_R_roomNumber = new ComboBox();
            label3 = new Label();
            textBox_R_isActiv = new ComboBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            comboBox_searchType = new ComboBox();
            pictureBox_eraser = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox_refresh = new PictureBox();
            textBox_search = new TextBox();
            dataGridView_Rooms = new DataGridView();
            tabPage_Type = new TabPage();
            label2 = new Label();
            panel4 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel5 = new Panel();
            textBox_T_typeDescription = new MaskedTextBox();
            pictureBox3 = new PictureBox();
            textBox_T_countOfRoomsInType = new TextBox();
            textBox_T_countOfPlacesInType = new TextBox();
            textBox_T_typePrice = new TextBox();
            textBox_T_countOfRoomsInHotel = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            panel6 = new Panel();
            comboBox2 = new ComboBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            textBox8 = new TextBox();
            dataGridView_Types = new DataGridView();
            textBox_T_typeName = new ComboBox();
            menuStrip.SuspendLayout();
            Type.SuspendLayout();
            tabPage_Room.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Rooms).BeginInit();
            tabPage_Type.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Types).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { mainPageToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(814, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // mainPageToolStripMenuItem
            // 
            mainPageToolStripMenuItem.Name = "mainPageToolStripMenuItem";
            mainPageToolStripMenuItem.Size = new Size(75, 20);
            mainPageToolStripMenuItem.Text = "Main Page";
            mainPageToolStripMenuItem.Click += mainPageToolStripMenuItem_Click;
            // 
            // Type
            // 
            Type.Controls.Add(tabPage_Room);
            Type.Controls.Add(tabPage_Type);
            Type.Location = new Point(0, 27);
            Type.Name = "Type";
            Type.SelectedIndex = 0;
            Type.Size = new Size(812, 577);
            Type.TabIndex = 1;
            // 
            // tabPage_Room
            // 
            tabPage_Room.Controls.Add(label1);
            tabPage_Room.Controls.Add(panel3);
            tabPage_Room.Controls.Add(panel2);
            tabPage_Room.Controls.Add(panel1);
            tabPage_Room.Controls.Add(dataGridView_Rooms);
            tabPage_Room.Location = new Point(4, 24);
            tabPage_Room.Name = "tabPage_Room";
            tabPage_Room.Padding = new Padding(3);
            tabPage_Room.Size = new Size(804, 549);
            tabPage_Room.TabIndex = 0;
            tabPage_Room.Text = "Room";
            tabPage_Room.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(555, 300);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 10;
            label1.Text = "Records management :";
            // 
            // panel3
            // 
            panel3.Controls.Add(button_save);
            panel3.Controls.Add(button_change);
            panel3.Controls.Add(button_delete);
            panel3.Controls.Add(button_newClient);
            panel3.Location = new Point(543, 323);
            panel3.Name = "panel3";
            panel3.Size = new Size(186, 222);
            panel3.TabIndex = 9;
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
            // 
            // button_newClient
            // 
            button_newClient.Font = new Font("Segoe UI", 9.75F);
            button_newClient.Location = new Point(39, 12);
            button_newClient.Name = "button_newClient";
            button_newClient.Size = new Size(110, 41);
            button_newClient.TabIndex = 0;
            button_newClient.Text = "New room";
            button_newClient.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox_R_typeName);
            panel2.Controls.Add(textBox_R_floor);
            panel2.Controls.Add(textBox_R_roomNumber);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox_R_isActiv);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(29, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 231);
            panel2.TabIndex = 8;
            // 
            // textBox_R_typeName
            // 
            textBox_R_typeName.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_R_typeName.FormattingEnabled = true;
            textBox_R_typeName.Location = new Point(235, 121);
            textBox_R_typeName.Name = "textBox_R_typeName";
            textBox_R_typeName.Size = new Size(162, 23);
            textBox_R_typeName.TabIndex = 51;
            // 
            // textBox_R_floor
            // 
            textBox_R_floor.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_R_floor.FormattingEnabled = true;
            textBox_R_floor.Location = new Point(235, 93);
            textBox_R_floor.Name = "textBox_R_floor";
            textBox_R_floor.Size = new Size(162, 23);
            textBox_R_floor.TabIndex = 50;
            // 
            // textBox_R_roomNumber
            // 
            textBox_R_roomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_R_roomNumber.FormattingEnabled = true;
            textBox_R_roomNumber.Location = new Point(235, 65);
            textBox_R_roomNumber.Name = "textBox_R_roomNumber";
            textBox_R_roomNumber.Size = new Size(162, 23);
            textBox_R_roomNumber.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F);
            label3.Location = new Point(100, 65);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 48;
            label3.Text = "Room number :";
            // 
            // textBox_R_isActiv
            // 
            textBox_R_isActiv.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_R_isActiv.FormattingEnabled = true;
            textBox_R_isActiv.Items.AddRange(new object[] { "True", "False" });
            textBox_R_isActiv.Location = new Point(235, 148);
            textBox_R_isActiv.Name = "textBox_R_isActiv";
            textBox_R_isActiv.Size = new Size(162, 23);
            textBox_R_isActiv.TabIndex = 47;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.records;
            pictureBox1.Location = new Point(16, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F);
            label10.Location = new Point(155, 145);
            label10.Name = "label10";
            label10.Size = new Size(74, 23);
            label10.TabIndex = 9;
            label10.Text = "Activity :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.75F);
            label9.Location = new Point(127, 118);
            label9.Name = "label9";
            label9.Size = new Size(102, 23);
            label9.TabIndex = 8;
            label9.Text = "Type name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12.75F);
            label8.Location = new Point(172, 91);
            label8.Name = "label8";
            label8.Size = new Size(57, 23);
            label8.TabIndex = 7;
            label8.Text = "Floor :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(comboBox_searchType);
            panel1.Controls.Add(pictureBox_eraser);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox_refresh);
            panel1.Controls.Add(textBox_search);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 56);
            panel1.TabIndex = 7;
            // 
            // comboBox_searchType
            // 
            comboBox_searchType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_searchType.FormattingEnabled = true;
            comboBox_searchType.Items.AddRange(new object[] { "Surname", "Name", "Middle name", "Birthday", "Sex", "Address", "Phone number", "Passport number" });
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
            // 
            // textBox_search
            // 
            textBox_search.Location = new Point(524, 16);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(164, 23);
            textBox_search.TabIndex = 0;
            // 
            // dataGridView_Rooms
            // 
            dataGridView_Rooms.AllowUserToAddRows = false;
            dataGridView_Rooms.AllowUserToDeleteRows = false;
            dataGridView_Rooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Rooms.Location = new Point(147, 71);
            dataGridView_Rooms.Name = "dataGridView_Rooms";
            dataGridView_Rooms.ReadOnly = true;
            dataGridView_Rooms.Size = new Size(560, 226);
            dataGridView_Rooms.TabIndex = 6;
            dataGridView_Rooms.CellClick += dataGridView_Rooms_CellClick;
            // 
            // tabPage_Type
            // 
            tabPage_Type.Controls.Add(label2);
            tabPage_Type.Controls.Add(panel4);
            tabPage_Type.Controls.Add(panel5);
            tabPage_Type.Controls.Add(panel6);
            tabPage_Type.Controls.Add(dataGridView_Types);
            tabPage_Type.Location = new Point(4, 24);
            tabPage_Type.Name = "tabPage_Type";
            tabPage_Type.Padding = new Padding(3);
            tabPage_Type.Size = new Size(804, 549);
            tabPage_Type.TabIndex = 1;
            tabPage_Type.Text = "Type";
            tabPage_Type.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(583, 296);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 15;
            label2.Text = "Records management :";
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Location = new Point(571, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(186, 222);
            panel4.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(39, 168);
            button1.Name = "button1";
            button1.Size = new Size(110, 41);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F);
            button2.Location = new Point(39, 116);
            button2.Name = "button2";
            button2.Size = new Size(110, 41);
            button2.TabIndex = 2;
            button2.Text = "Change";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F);
            button3.Location = new Point(39, 64);
            button3.Name = "button3";
            button3.Size = new Size(110, 41);
            button3.TabIndex = 1;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F);
            button4.Location = new Point(39, 12);
            button4.Name = "button4";
            button4.Size = new Size(110, 41);
            button4.TabIndex = 0;
            button4.Text = "New type";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox_T_typeName);
            panel5.Controls.Add(textBox_T_typeDescription);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(textBox_T_countOfRoomsInType);
            panel5.Controls.Add(textBox_T_countOfPlacesInType);
            panel5.Controls.Add(textBox_T_typePrice);
            panel5.Controls.Add(textBox_T_countOfRoomsInHotel);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label14);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label17);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(29, 296);
            panel5.Name = "panel5";
            panel5.Size = new Size(482, 249);
            panel5.TabIndex = 13;
            // 
            // textBox_T_typeDescription
            // 
            textBox_T_typeDescription.Location = new Point(237, 133);
            textBox_T_typeDescription.Name = "textBox_T_typeDescription";
            textBox_T_typeDescription.Size = new Size(162, 23);
            textBox_T_typeDescription.TabIndex = 45;
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
            // textBox_T_countOfRoomsInType
            // 
            textBox_T_countOfRoomsInType.Location = new Point(237, 81);
            textBox_T_countOfRoomsInType.Multiline = true;
            textBox_T_countOfRoomsInType.Name = "textBox_T_countOfRoomsInType";
            textBox_T_countOfRoomsInType.Size = new Size(162, 22);
            textBox_T_countOfRoomsInType.TabIndex = 17;
            // 
            // textBox_T_countOfPlacesInType
            // 
            textBox_T_countOfPlacesInType.Location = new Point(237, 107);
            textBox_T_countOfPlacesInType.Multiline = true;
            textBox_T_countOfPlacesInType.Name = "textBox_T_countOfPlacesInType";
            textBox_T_countOfPlacesInType.Size = new Size(162, 22);
            textBox_T_countOfPlacesInType.TabIndex = 16;
            // 
            // textBox_T_typePrice
            // 
            textBox_T_typePrice.Location = new Point(237, 160);
            textBox_T_typePrice.Multiline = true;
            textBox_T_typePrice.Name = "textBox_T_typePrice";
            textBox_T_typePrice.Size = new Size(162, 22);
            textBox_T_typePrice.TabIndex = 13;
            // 
            // textBox_T_countOfRoomsInHotel
            // 
            textBox_T_countOfRoomsInHotel.Location = new Point(237, 186);
            textBox_T_countOfRoomsInHotel.Multiline = true;
            textBox_T_countOfRoomsInHotel.Name = "textBox_T_countOfRoomsInHotel";
            textBox_T_countOfRoomsInHotel.Size = new Size(162, 22);
            textBox_T_countOfRoomsInHotel.TabIndex = 12;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12.75F);
            label13.Location = new Point(29, 185);
            label13.Name = "label13";
            label13.Size = new Size(202, 23);
            label13.TabIndex = 8;
            label13.Text = "Count of rooms in hotel :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12.75F);
            label14.Location = new Point(175, 158);
            label14.Name = "label14";
            label14.Size = new Size(56, 23);
            label14.TabIndex = 7;
            label14.Text = "Price :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12.75F);
            label16.Location = new Point(88, 131);
            label16.Name = "label16";
            label16.Size = new Size(143, 23);
            label16.TabIndex = 5;
            label16.Text = "Type description :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12.75F);
            label17.Location = new Point(36, 105);
            label17.Name = "label17";
            label17.Size = new Size(195, 23);
            label17.TabIndex = 4;
            label17.Text = "Count of places in type :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12.75F);
            label18.Location = new Point(129, 53);
            label18.Name = "label18";
            label18.Size = new Size(102, 23);
            label18.TabIndex = 3;
            label18.Text = "Type name :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12.75F);
            label19.Location = new Point(35, 79);
            label19.Name = "label19";
            label19.Size = new Size(196, 23);
            label19.TabIndex = 2;
            label19.Text = "Count of rooms in type :";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(comboBox2);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(pictureBox5);
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(textBox8);
            panel6.Location = new Point(4, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(797, 56);
            panel6.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Surname", "Name", "Middle name", "Birthday", "Sex", "Address", "Phone number", "Passport number" });
            comboBox2.Location = new Point(694, 16);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(81, 23);
            comboBox2.TabIndex = 5;
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
            // textBox8
            // 
            textBox8.Location = new Point(524, 16);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(164, 23);
            textBox8.TabIndex = 0;
            // 
            // dataGridView_Types
            // 
            dataGridView_Types.AllowUserToAddRows = false;
            dataGridView_Types.AllowUserToDeleteRows = false;
            dataGridView_Types.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Types.Location = new Point(29, 64);
            dataGridView_Types.Name = "dataGridView_Types";
            dataGridView_Types.ReadOnly = true;
            dataGridView_Types.Size = new Size(740, 226);
            dataGridView_Types.TabIndex = 11;
            dataGridView_Types.CellClick += dataGridView_Types_CellClick;
            // 
            // textBox_T_typeName
            // 
            textBox_T_typeName.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox_T_typeName.FormattingEnabled = true;
            textBox_T_typeName.Location = new Point(237, 54);
            textBox_T_typeName.Name = "textBox_T_typeName";
            textBox_T_typeName.Size = new Size(162, 23);
            textBox_T_typeName.TabIndex = 52;
            // 
            // RoomType_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 604);
            Controls.Add(Type);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "RoomType_Form";
            Text = "RoomType_From";
            Load += RoomType_Form_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            Type.ResumeLayout(false);
            tabPage_Room.ResumeLayout(false);
            tabPage_Room.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_eraser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Rooms).EndInit();
            tabPage_Type.ResumeLayout(false);
            tabPage_Type.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Types).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem mainPageToolStripMenuItem;
        private TabControl Type;
        private TabPage tabPage_Room;
        private TabPage tabPage_Type;
        private Label label1;
        private Panel panel3;
        private Button button_save;
        private Button button_change;
        private Button button_delete;
        private Button button_newClient;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Panel panel1;
        private ComboBox comboBox_searchType;
        private PictureBox pictureBox_eraser;
        private PictureBox pictureBox2;
        private PictureBox pictureBox_refresh;
        private TextBox textBox_search;
        private DataGridView dataGridView_Rooms;
        private Panel panel5;
        private MaskedTextBox textBox_T_typeDescription;
        private PictureBox pictureBox3;
        private TextBox textBox_T_countOfRoomsInType;
        private TextBox textBox_T_countOfPlacesInType;
        private TextBox textBox_T_typePrice;
        private TextBox textBox_T_countOfRoomsInHotel;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Panel panel6;
        private ComboBox comboBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private TextBox textBox8;
        private DataGridView dataGridView_Types;
        private ComboBox textBox_R_isActiv;
        private Label label2;
        private Panel panel4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private ComboBox textBox_R_typeName;
        private ComboBox textBox_R_floor;
        private ComboBox textBox_R_roomNumber;
        private ComboBox textBox_T_typeName;
    }
}