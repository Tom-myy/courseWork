using CourseWork.Models;
using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Forms
{
    public partial class Services_Form : Form
    {
        private readonly CheckUser _user;

        public Services_Form(CheckUser user)
        {
            InitializeComponent();
            _user = user;
            CreateColumns();
            RefreshDataGrid(dataGridView_Services);
        }

        int selectedRow;

        //key - displayed name in form, value - field name in our DB --- for searching
        /*       Dictionary<string, string> Dic_fields = new Dictionary<string, string>() {
                   {"Surname","surname" },
                   {"Name","firstName" },
                   {"Middle name","middleName" },
                   {"Birthday","birthday" },
                   {"Gender","gender" },
                   {"Address","clientAddress" },
                   {"Phone number","clientPhoneNumber" },
                   {"Passport number","clientPassportNumber" }
               };*/
        private void CreateColumns()
        {
            dataGridView_Services.Columns.Add("indService", "Service");
            dataGridView_Services.Columns.Add("indDescription", "Description");
            dataGridView_Services.Columns.Add("indPrice", "Price");
            dataGridView_Services.Columns.Add("indActivity", "Activity");
            dataGridView_Services.Columns.Add("indIsNew", String.Empty);
        }
        private void WriteRegistrationToDataGrid(DataGridView dgv, Service service)
        {
            dgv.Rows.Add(service.ServiceName, service.ServiceDescription,
                service.ServicePrice, service.IsActiv, RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string strQuery = """
                SELECT serviceName AS ServiceName, serviceDescription AS ServiceDescription,
                	   servicePrice AS ServicePrice, isActiv AS IsActiv 
                FROM [Service]
                """;

            using var connection = DB.GetOpenedConnection();
            var services = connection.Query<Service>(strQuery);

            foreach (var service in services)
            {
                WriteRegistrationToDataGrid(dgv, service);
            }
        }
        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form(_user);
            mainForm.Show();
            this.Hide();
        }
        private void dataGridView_Services_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView_Services.Rows[selectedRow];

                textBox_serviceName.Text = row.Cells[0].Value.ToString();
                textBox_serviceDescription.Text = row.Cells[1].Value.ToString();
                textBox_servicePrice.Text = row.Cells[2].Value.ToString();
                textBox_isActiv.Text = row.Cells[3].Value.ToString();
            }
        }
        private void CleanFields()
        {
            textBox_serviceName.Text = "";
            textBox_serviceDescription.Text = "";
            textBox_servicePrice.Text = "";
            textBox_isActiv.SelectedItem = null;
        }
        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_Services);
            CleanFields();
        }

        private void pictureBox_eraser_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        private void button_newRegistration_Click(object sender, EventArgs e)
        {
            NewService_Form newService_Form = new NewService_Form(this);
            newService_Form.Show();
            this.Hide();
        }
    }
}
