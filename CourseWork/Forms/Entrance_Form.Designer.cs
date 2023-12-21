namespace CourseWork
{
    partial class Entering_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            label_login = new Label();
            label_password = new Label();
            button_log_in = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox_passwordUnlock = new PictureBox();
            pictureBox_passwordLock = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_passwordUnlock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_passwordLock).BeginInit();
            SuspendLayout();
            // 
            // textBox_login
            // 
            textBox_login.Font = new Font("Segoe UI", 15.75F);
            textBox_login.Location = new Point(137, 118);
            textBox_login.Multiline = true;
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(244, 57);
            textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Segoe UI", 15.75F);
            textBox_password.Location = new Point(137, 206);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(244, 57);
            textBox_password.TabIndex = 1;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label_login.Location = new Point(49, 139);
            label_login.Name = "label_login";
            label_login.Size = new Size(64, 25);
            label_login.TabIndex = 2;
            label_login.Text = "Login:";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label_password.Location = new Point(15, 226);
            label_password.Name = "label_password";
            label_password.Size = new Size(98, 25);
            label_password.TabIndex = 3;
            label_password.Text = "Password:";
            // 
            // button_log_in
            // 
            button_log_in.BackColor = Color.Lime;
            button_log_in.Font = new Font("Goudy Old Style", 20.25F, FontStyle.Italic);
            button_log_in.Location = new Point(213, 282);
            button_log_in.Name = "button_log_in";
            button_log_in.Size = new Size(108, 40);
            button_log_in.TabIndex = 4;
            button_log_in.Text = "Log in";
            button_log_in.UseVisualStyleBackColor = false;
            button_log_in.Click += button_log_in_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 85);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 32.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(347, 55);
            label1.TabIndex = 8;
            label1.Text = "Registration";
            // 
            // pictureBox_passwordUnlock
            // 
            pictureBox_passwordUnlock.Image = Properties.Resources.unlock1;
            pictureBox_passwordUnlock.Location = new Point(390, 217);
            pictureBox_passwordUnlock.Name = "pictureBox_passwordUnlock";
            pictureBox_passwordUnlock.Size = new Size(40, 37);
            pictureBox_passwordUnlock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_passwordUnlock.TabIndex = 8;
            pictureBox_passwordUnlock.TabStop = false;
            pictureBox_passwordUnlock.Click += pictureBox_passwordUnlock_Click;
            // 
            // pictureBox_passwordLock
            // 
            pictureBox_passwordLock.Image = Properties.Resources.lock1;
            pictureBox_passwordLock.Location = new Point(390, 217);
            pictureBox_passwordLock.Name = "pictureBox_passwordLock";
            pictureBox_passwordLock.Size = new Size(40, 37);
            pictureBox_passwordLock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_passwordLock.TabIndex = 9;
            pictureBox_passwordLock.TabStop = false;
            pictureBox_passwordLock.Click += pictureBox2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(537, 362);
            Controls.Add(pictureBox_passwordLock);
            Controls.Add(pictureBox_passwordUnlock);
            Controls.Add(panel1);
            Controls.Add(button_log_in);
            Controls.Add(label_password);
            Controls.Add(label_login);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_passwordUnlock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_passwordLock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_login;
        private TextBox textBox_password;
        private Label label_login;
        private Label label_password;
        private Button button_log_in;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox_passwordUnlock;
        private PictureBox pictureBox_passwordLock;
    }
}
