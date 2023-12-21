namespace CourseWork
{
    partial class Main_Form
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
            menuStrip1 = new MenuStrip();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            registrationToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItem_roomType = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            usageToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientsToolStripMenuItem, registrationToolStripMenuItem, ToolStripMenuItem_roomType, bookingToolStripMenuItem, servicesToolStripMenuItem, usageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(764, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(65, 24);
            clientsToolStripMenuItem.Text = "Clients";
            clientsToolStripMenuItem.Click += clientsToolStripMenuItem_Click;
            // 
            // registrationToolStripMenuItem
            // 
            registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            registrationToolStripMenuItem.Size = new Size(101, 24);
            registrationToolStripMenuItem.Text = "Registration";
            registrationToolStripMenuItem.Click += registrationToolStripMenuItem_Click;
            // 
            // ToolStripMenuItem_roomType
            // 
            ToolStripMenuItem_roomType.Name = "ToolStripMenuItem_roomType";
            ToolStripMenuItem_roomType.Size = new Size(98, 24);
            ToolStripMenuItem_roomType.Text = "Room\\Type";
            ToolStripMenuItem_roomType.Click += roomTypeToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(76, 24);
            bookingToolStripMenuItem.Text = "Booking";
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;
            // 
            // servicesToolStripMenuItem
            // 
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(74, 24);
            servicesToolStripMenuItem.Text = "Services";
            servicesToolStripMenuItem.Click += servicesToolStripMenuItem_Click;
            // 
            // usageToolStripMenuItem
            // 
            usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            usageToolStripMenuItem.Size = new Size(62, 24);
            usageToolStripMenuItem.Text = "Usage";
            usageToolStripMenuItem.Click += usageToolStripMenuItem_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 409);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main_Form";
            Text = "Main Form";
            Load += Main_Form_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem registrationToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItem_roomType;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem servicesToolStripMenuItem;
        private ToolStripMenuItem usageToolStripMenuItem;
    }
}