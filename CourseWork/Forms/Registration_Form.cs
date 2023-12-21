using CourseWork.Models;
using Dapper;

namespace CourseWork
{
    public partial class Registration_Form : Form
    {
        private readonly CheckUser _user;
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
        public Registration_Form(CheckUser user)
        {
            InitializeComponent();
            _user = user;
        }
        private void CreateColumns()
        {
            /*dataGridView_registration.Columns.Add("indID_Registration", "ID_Registration");*/
            dataGridView_registration.Columns.Add("indID_Booking", "ID_Booking");
            dataGridView_registration.Columns.Add("indClient", "Client");
            dataGridView_registration.Columns.Add("indCountOfPeople", "Count of people");
            dataGridView_registration.Columns.Add("indRoomNumber", "Room number");
            dataGridView_registration.Columns.Add("indArrivalDate", "Arrival date");
            dataGridView_registration.Columns.Add("indDepartureDate", "Departure date");
            /*            dataGridView_registration.Columns.Add("indSumOfLiving", "Suma for living");
                        dataGridView_registration.Columns.Add("indSumOfServices", "Suma for services");
                        dataGridView_registration.Columns.Add("indTotalSum", "Total suma");*/
            dataGridView_registration.Columns.Add("indIsNew", String.Empty);
        }
        private void WriteRegistrationToDataGrid(DataGridView dgv, Registration registration)
        {
            dgv.Rows.Add(/*registration.Id, */registration.IdBooking, registration.Client,
                registration.CountOfPeople, registration.RoomNumber, registration.ArrivalDate.ToString("yyyy-MM-dd"),
                registration.DepartureDate.ToString("yyyy-MM-dd"), /*registration.SumOfLiving,
                registration.SumOfServices, registration.TotalSum,*/ RowState.ModifiedNew);
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string strQuery = """
                SELECT ID_Registration AS Id, ID_Booking AS IdBooking, 
                	surname + ' ' + firstName + ' ' + middleName AS Client, 
                    countOfPeople AS CountOfPeople, roomNumber AS RoomNumber, arrivalDate AS ArrivalDate, 
                    departureDate AS DepartureDate, sumOfLiving AS SumOfLiving, 
                	sumOfServices AS SumOfServices, totalSum AS TotalSum
                FROM Registration r INNER JOIN Client c ON r.ID_Client = c.ID_Client  
                """;

            using var connection = DB.GetOpenedConnection();
            var registrations = connection.Query<Registration>(strQuery);

            foreach (var registration in registrations)
            {
                WriteRegistrationToDataGrid(dgv, registration);
            }
        }
        private void mainPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form(_user);
            mainForm.Show();
            this.Hide();
        }
        private void Registration_Form_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView_registration);
            BookingInComboBox();
            textBox_idBooking.SelectedItem = null;
            ClientInComboBox();
            textBox_Client.SelectedItem = null;
            RoomInComboBox();
            textBox_roomNumber.SelectedItem = null;
        }
        private void BookingInComboBox()
        {
            const string strQuery = """
             SELECT ID_Booking AS [Text]
             FROM Booking
             """;

            using var connection = DB.GetOpenedConnection();
            var bookings = connection.Query<ComboItem>(strQuery);

            List<ComboItem> bookingList = new List<ComboItem>(bookings);
            bookingList.Insert(0, new ComboItem { Text = "0" });

            bookings = bookingList;
            textBox_idBooking.DataSource = bookings.ToList();
        }
        private void ClientInComboBox()
        {
            const string strQuery = """
             SELECT ID_Client AS Id, surname + ' ' + firstName + ' ' + middleName AS [Text]
             FROM Client
             """;

            using var connection = DB.GetOpenedConnection();
            var clients = connection.Query<ComboItem>(strQuery);

            textBox_Client.DataSource = clients.ToList();
        }
        private void RoomInComboBox()
        {
            const string strQuery = """
             SELECT roomNumber AS [Text]
             FROM Room
             """;

            using var connection = DB.GetOpenedConnection();
            var rooms = connection.Query<ComboBox>(strQuery);

            textBox_roomNumber.DataSource = rooms.ToList();
            textBox_roomNumber.DisplayMember = "Text";
        }

        private void button_newClient_Click(object sender, EventArgs e)
        {
            NewClient_Form newClient_Form = new NewClient_Form(this, _user);
            newClient_Form.Show();
            this.Hide();
        }

        private void button_newBooking_Click(object sender, EventArgs e)
        {
            NewRegistration_Form newRegistration_Form = new NewRegistration_Form(this, _user);
            newRegistration_Form.Show();
            this.Hide();
        }

        private void dataGridView_registration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (selectedRow >= 0)
            {
                DataGridViewRow row = dataGridView_registration.Rows[selectedRow];

                /*                textBox_idRegistration.Text = row.Cells[0].Value.ToString();*/
                textBox_idBooking.Text = row.Cells[0].Value.ToString();
                textBox_Client.Text = row.Cells[1].Value.ToString();
                textBox_countOfPeople.Text = row.Cells[2].Value.ToString();
                textBox_roomNumber.Text = row.Cells[3].Value.ToString();
                textBox_arrivalDate.Text = row.Cells[4].Value.ToString();
                textBox_departureDate.Text = row.Cells[5].Value.ToString();
                /*                textBox_sumaOfLiving.Text = row.Cells[6].Value.ToString();
                                textBox_sumaOfServices.Text = row.Cells[7].Value.ToString();
                                textBox_totalSuma.Text = row.Cells[8].Value.ToString();*/
            }
        }
        private void MethodForUpdateRegistrationAndArchiveTables()
        { //метод для переміщення даних з реєстрації (де дата виїзду менша за сьогоднішню) та їх
          //видалення з реєстрації
            const string queryClients = """
             SELECT ID_Client AS Id, surname AS Surname, firstName AS FirstName, middleName AS MiddleName 
             FROM Client
             """;
            using var connection = DB.GetOpenedConnection();
            var clients = connection.Query<Client>(queryClients);

            const string queryRegistrations = """
             SELECT ID_Registration AS Id, ID_Client AS IdClient, countOfPeople AS CountOfPeople,
                roomNumber AS RoomNumber, arrivalDate AS ArrivalDate, departureDate AS DepartureDate,
                sumOfLiving AS SumOfLiving,sumOfServices AS SumOfServices, totalSum AS TotalSum
             FROM Registration
             """;
            var registrations = connection.Query<Registration>(queryRegistrations);

        }
        private void CleanFields()
        {
            textBox_idBooking.SelectedItem = null;
            textBox_Client.SelectedItem = null;
            textBox_countOfPeople.Text = "";
            textBox_roomNumber.SelectedItem = null;
            textBox_arrivalDate.Text = "";
            textBox_departureDate.Text = "";

        }
        private void pictureBox_refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView_registration);
            CleanFields();
        }

        private void pictureBox_eraser_Click(object sender, EventArgs e)
        {
            CleanFields();
        }
    }
}
