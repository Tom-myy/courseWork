using CourseWork.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Main_Form : Form
    {
        private readonly CheckUser _user;
        int selectedRow;
        public Main_Form(CheckUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = user;
        }
        private void IsAdmin()
        {
            ToolStripMenuItem_roomType.Enabled = _user.IsAdmin;
        }
        private void createColums()
        {

        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client_Form client_Form = new Client_Form(_user);
            client_Form.Show();
            this.Hide();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration_Form registration_Form = new Registration_Form(_user);
            this.Hide();
            registration_Form.Show();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking_Form booking_Form = new Booking_Form(_user);
            this.Hide();
            booking_Form.Show();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomType_Form roomType_Form = new RoomType_Form(_user);
            this.Hide();
            roomType_Form.Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            IsAdmin();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services_Form services_Form = new Services_Form(_user);
            services_Form.Show();
            this.Hide();
        }

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsageServices_Form usageServices_Form = new UsageServices_Form(_user);
            usageServices_Form.Show();
            this.Hide();
        }
    }
}
