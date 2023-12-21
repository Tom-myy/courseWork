using CourseWork.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RoomType_Form : Form
    {
        private readonly CheckUser _user;

        int selectedRow;
        public RoomType_Form(CheckUser user)
        {
            InitializeComponent();
            _user = user;
        }
        private void RoomType_Form_Load(object sender, EventArgs e)
        {
            CreateColumnsForRooms();
            RefreshDataGridForRooms(dataGridView_Rooms);
            RoomsInComboBox();
            textBox_R_roomNumber.SelectedItem = null;
            FloorsInComboBox();
            textBox_R_floor.SelectedItem = null;
            TypesInComboBox(textBox_R_typeName);
            textBox_R_typeName.SelectedItem = null;



            CreateColumnsForTypes();
            RefreshDataGridForTypes(dataGridView_Types);
            TypesInComboBox(textBox_T_typeName);
            textBox_T_typeName.SelectedItem = null;
        }
        private void CreateColumnsForRooms()
        {
            dataGridView_Rooms.Columns.Add("indRoomNumber", "Room number");
            dataGridView_Rooms.Columns.Add("indFloor", "Floor");
            dataGridView_Rooms.Columns.Add("indTypeName", "Type name");
            dataGridView_Rooms.Columns.Add("indIsActiv", "Activity");
            dataGridView_Rooms.Columns.Add("indIsNew", String.Empty);
        }
        private void WriteRoomToDataGrid(DataGridView dgv, Room room)
        {
            dgv.Rows.Add(room.RoomNumber, room.Floor, room.TypeName,
                room.IsActiv, RowState.ModifiedNew);
        }
        private void RefreshDataGridForRooms(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string strQuery = """
             SELECT roomNumber AS RoomNumber, [floor] AS [Floor], 
                    typeName AS TypeName, isActiv AS IsActiv
             FROM Room
             """;

            using var connection = DB.GetOpenedConnection();
            var rooms = connection.Query<Room>(strQuery);

            foreach (var room in rooms)
            {
                WriteRoomToDataGrid(dgv, room);
            }

        }
        private void dataGridView_Rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView_Rooms.Rows[selectedRow];

                textBox_R_roomNumber.Text = row.Cells[0].Value.ToString();
                textBox_R_floor.Text = row.Cells[1].Value.ToString();
                textBox_R_typeName.Text = row.Cells[2].Value.ToString();
                textBox_R_isActiv.Text = row.Cells[3].Value.ToString();
            }
        }
        private void CreateColumnsForTypes()
        {
            dataGridView_Types.Columns.Add("indTypeName", "Type Name");
            dataGridView_Types.Columns.Add("indCountOfRoomsInType", "Count of rooms in type");
            dataGridView_Types.Columns.Add("indCountOfPlacesInType", "Count of places in type");
            dataGridView_Types.Columns.Add("indTypeDescription", "Type description");
            dataGridView_Types.Columns.Add("indTypePrice", "Type price");
            dataGridView_Types.Columns.Add("indCountOfRoomsInHotel", "Count of rooms in hotel");
            dataGridView_Types.Columns.Add("indIsNew", String.Empty);
        }
        private void WriteTypeToDataGrid(DataGridView dgv, Typee type)
        {
            dgv.Rows.Add(type.TypeName, type.CountOfRoomsInType, type.CountOfPlacesInType,
                type.TypeDescription, type.TypePrice, type.CountOfRoomInHotel, RowState.ModifiedNew);
        }
        private void RefreshDataGridForTypes(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string strQuery = """
             SELECT typeName AS TypeName, countOfRoomsInType AS CountOfRoomsInType, 
             	   countOfPlacesInType AS CountOfPlacesInType, typeDescription AS TypeDescription,
             	   typePrice AS TypePrice, countOfRoomInHotel AS CountOfRoomInHotel
             FROM [Type]
             """;

            using var connection = DB.GetOpenedConnection();
            var types = connection.Query<Typee>(strQuery);

            foreach (var type in types)
            {
                WriteTypeToDataGrid(dgv, type);
            }

        }
        private void dataGridView_Types_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView_Types.Rows[selectedRow];

                textBox_T_typeName.Text = row.Cells[0].Value.ToString();
                textBox_T_countOfRoomsInType.Text = row.Cells[1].Value.ToString();
                textBox_T_countOfPlacesInType.Text = row.Cells[2].Value.ToString();
                textBox_T_typeDescription.Text = row.Cells[3].Value.ToString();
                textBox_T_typePrice.Text = row.Cells[4].Value.ToString();
                textBox_T_countOfRoomsInHotel.Text = row.Cells[5].Value.ToString();
            }
        }

        private void RoomsInComboBox()
        {
            const string strQuery = """
             SELECT roomNumber AS [Text]
             FROM Room
             """;

            using var connection = DB.GetOpenedConnection();

            var rooms = connection.Query<ComboItem>(strQuery);

            textBox_R_roomNumber.DataSource = rooms.ToArray();
            textBox_R_roomNumber.DisplayMember = "Text";
        }
        private void FloorsInComboBox()
        {
            const string strQuery = $"""
             SELECT DISTINCT [floor] AS [Text]
             FROM Room
             """;

            using var connection = DB.GetOpenedConnection();
            var floors = connection.Query<ComboBox>(strQuery);

            textBox_R_floor.DataSource = floors.ToArray();
            textBox_R_floor.DisplayMember = "Text";
        }
        private void TypesInComboBox(ComboBox cb)
        {
            const string strQuery = $"""
             SELECT typeName AS [Text]
             FROM [Type]
             """;

            using var connection = DB.GetOpenedConnection();
            var types = connection.Query<ComboBox>(strQuery);

            cb.DataSource = types.ToArray();
            cb.DisplayMember = "Text";
        }
        /*        private void changeRoom()
                {
                    int selectedRowIndex = dataGridView_Rooms.CurrentCell.RowIndex;
                    if (textBox_R_isActiv.Text != string.Empty)
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

                        if (dataGridView_Rooms.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                        {
                            if (DateTime.TryParse(textBox_bithday.Text, out birthday))
                            {
                                DateTime minAllowedDate = DateTime.Today.AddYears(-16);
                                if (birthday.Date <= minAllowedDate)
                                {
                                    dataGridView_Rooms.Rows[selectedRowIndex].SetValues(id, surname, name,
                                    middlename, birthday.Date, sex, address, phonenumber, pasportnumber);
                                    dataGridView_Rooms.Rows[selectedRowIndex].Cells[9].Value = RowState.Modified;
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
                            string surname = dataGridView_Clients.Rows[index].Cells[1].Value.ToString();
                            string firstName = dataGridView_Clients.Rows[index].Cells[2].Value.ToString();
                            string middleName = dataGridView_Clients.Rows[index].Cells[3].Value.ToString();
                            DateTime birthday = (DateTime)dataGridView_Clients.Rows[index].Cells[4].Value;
                            string gender = dataGridView_Clients.Rows[index].Cells[5].Value.ToString();
                            string clientAddress = dataGridView_Clients.Rows[index].Cells[6].Value.ToString();
                            string clientPhoneNumber = dataGridView_Clients.Rows[index].Cells[7].Value.ToString();
                            string clientPassportNumber = dataGridView_Clients.Rows[index].Cells[8].Value.ToString();

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
                }*/
        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form(_user);
            mainForm.Show();
            this.Hide();
        }
        private void button_change_Click(object sender, EventArgs e)
        {
            
        }
    }
}
