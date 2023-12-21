using CourseWork.Models;
using Dapper;

namespace CourseWork
{
    public partial class Booking_Form : Form
    {
        private readonly CheckUser _user;

        int selectedRow;
        //key - displayed name in form, value - field name in our DB --- for searching
        Dictionary<string, string> Dic_fields = new Dictionary<string, string>() {
            {"Client","Client" },
            {"Count of people","countOfPeople" },
            {"Room number","roomNumber" },
            {"Arrival date","arrivalDate" },
            {"Departure date","departureDate" }
        };
        public Booking_Form(CheckUser user)
        {
            InitializeComponent();
            _user = user;
        }
        private void CreateColumns()
        {
            dataGridView_booking.Columns.Add("indID_Booking", "ID_Booking");
            dataGridView_booking.Columns.Add("indClient", "Client");
            dataGridView_booking.Columns.Add("indCountOfPeople", "Count of people");
            dataGridView_booking.Columns.Add("indRoomNumber", "Room Number");
            dataGridView_booking.Columns.Add("indArrivalDate", "Arrival Date");
            dataGridView_booking.Columns.Add("indDepartureDate", "Departure Date");
            dataGridView_booking.Columns.Add("indIsNew", String.Empty);
        }
        private void WriteBookingToDataGrid(DataGridView dgv, Booking booking)
        {
            dgv.Rows.Add(booking.Id, booking.Client, booking.CountOfPeople,
                booking.RoomNumber, booking.ArrivalDate.ToString("yyyy-MM-dd"),
                booking.DepartureDate.ToString("yyyy-MM-dd"), RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            const string strQuery = """  
                SELECT 
                	   ID_Booking AS Id, 
                	   surname + ' ' + firstName + ' ' + middleName AS Client, 
                	   countOfPeople AS CountOfPeople, 
                	   roomNumber AS RoomNumber,
                	   arrivalDate AS ArrivalDate,
                	   departureDate AS DepartureDate
                FROM Booking b INNER JOIN Client c ON b.ID_Client = c.ID_Client
                """;

            using var connection = DB.GetOpenedConnection();

            var bookings = connection.Query<Booking>(strQuery);

            foreach (var booking in bookings)
            {
                WriteBookingToDataGrid(dgv, booking);
            }
        }
        private void button_newClient_Click(object sender, EventArgs e)
        {
            NewClient_Form newClientForm = new NewClient_Form(this, _user);
            newClientForm.Show();
            this.Hide();
        }
        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form(_user);
            mainForm.Show();
            this.Hide();
        }
        private void button_newBooking_Click(object sender, EventArgs e)
        {
            NewBooking_Form newBooking = new NewBooking_Form(this);
            this.Hide();
            newBooking.Show();
        }
        private void Booking_Form_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_booking);
            ClientsInComboBox();
            RoomsInComboBox();
            textBox_arrivalDate.Mask = "0000-00-00";
            textBox_departureDate.Mask = "0000-00-00";
            textBox_Client.SelectedItem = null;
            textBox_roomNumber.SelectedItem = null;
        }
        private void CleanFields()
        {
            textBox_idBooking.Text = "";
            textBox_Client.SelectedItem = null;
            textBox_countOfPeople.Text = "";
            textBox_roomNumber.SelectedItem = null;
            textBox_arrivalDate.Text = "";
            textBox_departureDate.Text = "";

        }
        private void Change()
        {
            int selectedRowIndex = dataGridView_booking.CurrentCell.RowIndex;
            if (textBox_idBooking.Text != string.Empty)
            {
                int id = int.Parse(textBox_idBooking.Text);
                string client = textBox_Client.Text;
                int countOfPeople = int.Parse(textBox_countOfPeople.Text);
                string roomNumber = textBox_roomNumber.Text;
                DateTime arrivalDate;
                DateTime departureDate;


                if (dataGridView_booking.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                {
                    if (DateTime.TryParse(textBox_arrivalDate.Text, out arrivalDate) &&
                        DateTime.TryParse(textBox_departureDate.Text, out departureDate))
                    {

                        if (arrivalDate < DateTime.Today || departureDate < arrivalDate)
                        {
                            MessageBox.Show("Your dates are wrong");
                        }
                        else
                        {
                            dataGridView_booking.Rows[selectedRowIndex].SetValues(id, client, countOfPeople,
                                roomNumber, arrivalDate.Date, departureDate.Date);
                            dataGridView_booking.Rows[selectedRowIndex].Cells[6].Value = RowState.Modified;
                            CleanFields();
                        }
                    }
                    else
                        MessageBox.Show("Dates must be in format 'yyyy-MM-dd'");
                }
            }
            else
                MessageBox.Show("You need to choose any row");
        }

        private void DeleteRow()
        {
            if (textBox_idBooking.Text != string.Empty)
            {

                int index = dataGridView_booking.CurrentCell.RowIndex;

                dataGridView_booking.Rows[index].Visible = false;

                if (dataGridView_booking.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    dataGridView_booking.Rows[index].Cells[6].Value = RowState.Deleted;
                    return;
                }

                dataGridView_booking.Rows[index].Cells[6].Value = RowState.Deleted;
            }
            else
                MessageBox.Show("You need to choose any row");
        }
        private void Update()
        {
            for (int index = 0; index < dataGridView_booking.Rows.Count; ++index)
            {
                RowState rS = (RowState)dataGridView_booking.Rows[index].Cells[6].Value;

                if (rS == RowState.Modified)
                {
                    int id = (int)dataGridView_booking.Rows[index].Cells[0].Value;
                    string Client = (string)dataGridView_booking.Rows[index].Cells[1].Value;
                    int countOfPeople = (int)dataGridView_booking.Rows[index].Cells[2].Value;
                    string roomNumber = (string)dataGridView_booking.Rows[index].Cells[3].Value;
                    DateTime arrivalDate = (DateTime)dataGridView_booking.Rows[index].Cells[4].Value;
                    DateTime departureDate = (DateTime)dataGridView_booking.Rows[index].Cells[5].Value;

                    string tmpArrivalDate = arrivalDate.Date.ToString("yyyy-MM-dd");
                    string tmpDepartureDate = departureDate.Date.ToString("yyyy-MM-dd");

                    string tmpStrQuery_IdClientByIdBooking = $"""
                     SELECT ID_Client
                     FROM Booking
                     WHERE ID_Booking = '{id}'
                     """;

                    using var connection = DB.GetOpenedConnection();
                    int idClient = connection.QueryFirstOrDefault<int>(tmpStrQuery_IdClientByIdBooking);

                    string strQueryUpdate = $"""
                     UPDATE Booking SET ID_Client = '{idClient}', countOfPeople = '{countOfPeople}', 
                        roomNumber = '{roomNumber}', arrivalDate ='{tmpArrivalDate}',
                        departureDate ='{tmpDepartureDate}' 
                     WHERE ID_Booking ='{id}'
                     """;

                    var bookings = connection.Query<Booking>(strQueryUpdate);
                }

                if (rS == RowState.Deleted)
                {
                    int id = (int)(dataGridView_booking.Rows[index].Cells[0].Value);
                    string strQueryDelete = $"DELETE FROM Booking WHERE ID_Booking = {id}";

                    using var connection = DB.GetOpenedConnection();
                    var bookings = connection.Query<Booking>(strQueryDelete);

                }
            }
        }
        private void Search(DataGridView dgv)
        {
            string keyForDic_fields = comboBox_searchType.Text;
            string valueForDic_fields = Dic_fields[keyForDic_fields];
            string searchString = textBox_search.Text;

            dgv.Rows.Clear();

            string strQuerySearch = $"SELECT * FROM Booking WHERE {valueForDic_fields} LIKE '%" + searchString + "%'";

            using var connection = DB.GetOpenedConnection();
            var bookings = connection.Query<Booking>(strQuerySearch);

            foreach (var booking in bookings)
            {
                WriteBookingToDataGrid(dgv, booking);
            }
        }
        private void dataGridView_booking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView_booking.Rows[selectedRow];
                textBox_idBooking.Text = row.Cells[0].Value.ToString();
                textBox_Client.Text = row.Cells[1].Value.ToString();
                textBox_countOfPeople.Text = row.Cells[2].Value.ToString();
                textBox_roomNumber.Text = row.Cells[3].Value.ToString();
                textBox_arrivalDate.Text = row.Cells[4].Value.ToString();
                textBox_departureDate.Text = row.Cells[5].Value.ToString();
            }
        }

        private void ClientsInComboBox()
        {
            const string strQuery = """
                        SELECT ID_Client AS Id, surname + ' ' + firstName + ' ' + middleName AS [Text]
                        FROM Client
                        """;

            using var connection = DB.GetOpenedConnection();

            var clients = connection.Query<ComboItem>(strQuery);

            textBox_Client.DataSource = clients.ToList();

        }
        private void RoomsInComboBox()
        {
            const string strQuery = """
                        SELECT roomNumber AS [Text]
                        FROM Room
                        """;

            using var connection = DB.GetOpenedConnection();

            var items = connection.Query<ComboItem>(strQuery);

            textBox_roomNumber.DataSource = items.ToArray();
            textBox_roomNumber.DisplayMember = "Text";
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void pictureBox_refres_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_booking);
            CleanFields();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView_booking);
        }

        private void pictureBox_eraser_Click(object sender, EventArgs e)
        {
            CleanFields();
        }
    }
}
