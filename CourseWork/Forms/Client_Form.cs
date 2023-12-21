using CourseWork.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{

    public partial class Client_Form : Form
    {
        private readonly CheckUser _user;
            
        Client_Form currentForm;
        int selectedRow;
        //key - displayed name in form, value - field name in our DB --- for searching
        Dictionary<string, string> Dic_fields = new Dictionary<string, string>() {
            {"Surname","surname" },
            {"Name","firstName" },
            {"Middle name","middleName" },
            {"Birthday","birthday" },
            {"Gender","gender" },
            {"Address","clientAddress" },
            {"Phone number","clientPhoneNumber" },
            {"Passport number","clientPassportNumber" }
        };
        public Client_Form(CheckUser user)
        {
            InitializeComponent();
            _user = user;
            StartPosition = FormStartPosition.CenterScreen;
            comboBox_searchType.SelectedItem = "Surname";
            textBox_bithday.Mask = "0000-00-00";
        }
        private void CreateColumns()
        {
            dataGridView_Clients.Columns.Add("indID_Client", "ID_Client");
            dataGridView_Clients.Columns.Add("indSurname", "Surname");
            dataGridView_Clients.Columns.Add("indFirstName", "Name");
            dataGridView_Clients.Columns.Add("indMiddleName", "Middle name");
            dataGridView_Clients.Columns.Add("indBirthday", "Birthday");
            dataGridView_Clients.Columns.Add("indGender", "Gender");
            dataGridView_Clients.Columns.Add("indClientAddress", "Address");
            dataGridView_Clients.Columns.Add("indclientPhoneNumber", "Phone number");
            dataGridView_Clients.Columns.Add("indClientPassportNumber", "Passport number");
            dataGridView_Clients.Columns.Add("indIsNew", String.Empty);
        }
        private void WriteClientToDataGrid(DataGridView dgv, Client client)
        {
            dgv.Rows.Add(client.Id, client.Surname, client.FirstName, client.MiddleName,
                client.Birthday.ToString("yyyy-MM-dd"), client.Gender, client.ClientAddress,
                client.ClientPhoneNumber, client.ClientPassportNumber, RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string strQuery = """
                SELECT ID_Client AS Id, surname AS Surname, firstName AS FirstName,
                	   middleName AS MiddleName, birthday AS Birthday, gender AS Gender,
                	   clientAddress AS ClientAddress, clientPhoneNumber AS ClientPhoneNumber,
                	   clientPassportNumber AS ClientPassportNumber
                FROM Client
                """;

            using var connection = DB.GetOpenedConnection();
            var clients = connection.Query<Client>(strQuery);

            foreach (var client in clients)
            {
                WriteClientToDataGrid(dgv, client);
            }
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_Clients);
        }
        private void cleanFields()
        {
            textBox_idClient.Text = "";
            textBox_surname.Text = "";
            textBox_firstName.Text = "";
            textBox_middleName.Text = "";
            textBox_bithday.Text = "";
            textBox_gender.SelectedItem = null;
            textBox_clientAddress.Text = "";
            textBox_clientPhoneNumber.Text = "";
            textBox_clientPassportNumber.Text = "";
        }
        private void change()
        {
            int selectedRowIndex = dataGridView_Clients.CurrentCell.RowIndex;
            if (textBox_idClient.Text != string.Empty)
            {
                int id = int.Parse(textBox_idClient.Text);
                string surname = textBox_surname.Text;
                string name = textBox_firstName.Text;
                string middlename = textBox_middleName.Text;
                DateTime birthday;
                string sex = textBox_gender.Text;
                string address = textBox_clientAddress.Text;
                string phonenumber = textBox_clientPhoneNumber.Text;
                string pasportnumber = textBox_clientPassportNumber.Text;

                if (dataGridView_Clients.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    if (DateTime.TryParse(textBox_bithday.Text, out birthday))
                    {
                        DateTime minAllowedDate = DateTime.Today.AddYears(-16);
                        if (birthday.Date <= minAllowedDate)
                        {
                            dataGridView_Clients.Rows[selectedRowIndex].SetValues(id, surname, name,
                            middlename, birthday.Date, sex, address, phonenumber, pasportnumber);
                            dataGridView_Clients.Rows[selectedRowIndex].Cells[9].Value = RowState.Modified;
                        }
                        else
                            MessageBox.Show("The person must be over 16 years old");
                    }
                    else
                        MessageBox.Show("Date must be in format 'yyyy-MM-dd'");
                }
            } 
            else
                MessageBox.Show("You need to choose any row");

        }
        private void deleteRow()
        {
            if (textBox_idClient.Text != string.Empty)
            {

                int index = dataGridView_Clients.CurrentCell.RowIndex;

                dataGridView_Clients.Rows[index].Visible = false;

                if (dataGridView_Clients.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView_Clients.Rows[index].Cells[9].Value = RowState.Deleted;
                    return;
                }

                dataGridView_Clients.Rows[index].Cells[9].Value = RowState.Deleted;
            }
            else
                MessageBox.Show("You need to choose any row");
        }
        private void update()
        {
            for (int index = 0; index < dataGridView_Clients.Rows.Count; ++index)
            {
                RowState rS = (RowState)dataGridView_Clients.Rows[index].Cells[9].Value;

                if (rS == RowState.Modified)
                {
                    int ID_Client = (int)dataGridView_Clients.Rows[index].Cells[0].Value;
                    string? surname = dataGridView_Clients.Rows[index].Cells[1].Value.ToString();
                    string? firstName = dataGridView_Clients.Rows[index].Cells[2].Value.ToString();
                    string? middleName = dataGridView_Clients.Rows[index].Cells[3].Value.ToString();
                    DateTime birthday = (DateTime)dataGridView_Clients.Rows[index].Cells[4].Value;
                    string? gender = dataGridView_Clients.Rows[index].Cells[5].Value.ToString();
                    string? clientAddress = dataGridView_Clients.Rows[index].Cells[6].Value.ToString();
                    string? clientPhoneNumber = dataGridView_Clients.Rows[index].Cells[7].Value.ToString();
                    string? clientPassportNumber = dataGridView_Clients.Rows[index].Cells[8].Value.ToString();

                    string tmpBirthday = birthday.Date.ToString("yyyy-MM-dd");

                    string strQueryUpdate = $"""
                        UPDATE Client SET surname = '{surname}', firstName = '{firstName}', middleName ='{middleName}',
                        				  birthday ='{tmpBirthday}', gender ='{gender}', clientAddress ='{clientAddress}',
                        				  clientPhoneNumber ='{clientPhoneNumber}', clientPassportNumber ='{clientPassportNumber}' 
                        WHERE ID_Client ='{ID_Client}'
                        """;

                    using var connection = DB.GetOpenedConnection();
                    var clients = connection.Query<Client>(strQueryUpdate);
                }

                if (rS == RowState.Deleted)
                {
                    int id = (int)(dataGridView_Clients.Rows[index].Cells[0].Value);
                    string strQueryDelete = $"DELETE FROM Client WHERE ID_Client = {id}";

                    using var connection = DB.GetOpenedConnection();
                    var clients = connection.Query<Client>(strQueryDelete);
                }
            }
        }
        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form(_user);
            mainForm.Show();
            this.Hide();
        }
        private void Search(DataGridView dgv)
        {
            string keyForDic_fields = comboBox_searchType.Text;
            string valueForDic_fields = Dic_fields[keyForDic_fields];
            string searchString = textBox_search.Text;

            dgv.Rows.Clear();

            string strQuerySearch = $"SELECT * FROM Client WHERE {valueForDic_fields} LIKE '%" + searchString + "%'";

            using var connection = DB.GetOpenedConnection();
            var clients = connection.Query<Client>(strQuerySearch);

            foreach (var client in clients)
            {
                WriteClientToDataGrid(dgv, client);
            }
        }
        private void dataGridView_Clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView_Clients.Rows[selectedRow];

                textBox_idClient.Text = row.Cells[0].Value.ToString();
                textBox_surname.Text = row.Cells[1].Value.ToString();
                textBox_firstName.Text = row.Cells[2].Value.ToString();
                textBox_middleName.Text = row.Cells[3].Value.ToString();
                textBox_bithday.Text = row.Cells[4].Value.ToString();
                textBox_gender.Text = row.Cells[5].Value.ToString();
                textBox_clientAddress.Text = row.Cells[6].Value.ToString();
                textBox_clientPhoneNumber.Text = row.Cells[7].Value.ToString();
                textBox_clientPassportNumber.Text = row.Cells[8].Value.ToString();
            }
        }

        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
            cleanFields();
            RefreshDataGrid(dataGridView_Clients);
        }

        private void button_newClient_Click(object sender, EventArgs e)
        {
            NewClient_Form newClientForm = new NewClient_Form(this, _user);
            newClientForm.Show();
            this.Hide();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView_Clients);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            cleanFields();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            update();
            cleanFields();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            change();
        }
        private void pictureBox_eraser_Click(object sender, EventArgs e)
        {
            cleanFields();
        }
    }
}
