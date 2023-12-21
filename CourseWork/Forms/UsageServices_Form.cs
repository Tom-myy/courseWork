using CourseWork.Models;
using Dapper;
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
    public partial class UsageServices_Form : Form
    {
        private readonly CheckUser _user;
        public UsageServices_Form(CheckUser user)
        {
            InitializeComponent();
            _user = user;
        }
        private void CreateColumns()
        {
            dataGridView_UsageServices.Columns.Add("indService", "Service");
            dataGridView_UsageServices.Columns.Add("indClient", "Client");
            dataGridView_UsageServices.Columns.Add("indcountOfUsedServices", "Count of used services");
            dataGridView_UsageServices.Columns.Add("indSumOfServices", "Sum");
            dataGridView_UsageServices.Columns.Add("indIsNew", String.Empty);
        }
        private void WriteRegistrationToDataGrid(DataGridView dgv, Usage usage)
        {
            dgv.Rows.Add(usage.Service, usage.Client,
                usage.CountOfUsedServices, usage.SumOfServices, RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string strQuery = """
             SELECT serviceName AS [Service], surname + ' ' + firstName + ' ' + middleName AS Client,
                    countOfPeople AS CountOfPeople, u.sumOfServices AS SumOfServices
             FROM Usage u INNER JOIN [Service] s ON u.ID_Service = s.ID_Service
                          INNER JOIN Registration r ON u.ID_Registration = r.ID_Registration
             			  INNER JOIN Client c ON r.ID_Client = c.ID_Client
             """;

            using var connection = DB.GetOpenedConnection();
            var usages = connection.Query<Usage>(strQuery);

            foreach (var usage in usages)
            {
                WriteRegistrationToDataGrid(dgv, usage);
            }
        }
        private void UsageServices_Form_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_UsageServices);
        }

        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form(_user);
            mainForm.Show();
            this.Hide();
        }
    }
}
