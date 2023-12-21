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
    public partial class NewRegistration_Form : Form
    {
        Form previousForm;
        public NewRegistration_Form(Form prevForm, CheckUser user)
        {
            InitializeComponent();
            previousForm = prevForm;
        }
        private void NewRegistration_Form_Load(object sender, EventArgs e)
        {
            /*textBox_arrivalDate.Mask = "0000-00-00";*/ //непотрібно 
            textBox_departureDate.Mask = "0000-00-00";
            BookingInComboBox();
            /*textBox_idBooking.SelectedItem = null;*/ //подумати, як зробити, щоб можна було тут поставити налл
            ClientInComboBox();
            textBox_Client.SelectedItem = null;
            RoomInComboBox();
            textBox_roomNumber.SelectedItem = null;
            textBox_countOfPeople.Minimum = 1;
        }
        private void BookingInComboBox()
        {// потрібно виводити лише ті броні, де дата заїзду в броні співпадає з сьогоднішньою датою
            const string strQuery = """
             SELECT ID_Booking AS Id
             FROM Booking b
             WHERE b.arrived = 'FALSE' AND arrivalDate = CONVERT(varchar, GETDATE(), 23)
             """;

            using var connection = DB.GetOpenedConnection();
            var bookings = connection.Query<ComboItem>(strQuery);

            List<ComboItem> bookingList = new List<ComboItem>(bookings);
            bookingList.Insert(0, new ComboItem { Id = 0 });

            bookings = bookingList;
            textBox_idBooking.DataSource = bookings.ToList();
            textBox_idBooking.DisplayMember = "Id";
        }
        private void ClientInComboBox()
        {// потрібно відображати лише тих, які ще не проживають
            const string strQuery = """
             SELECT ID_Client AS Id, surname + ' ' + firstName + ' ' + middleName AS [Text]
             FROM Client c
             WHERE NOT EXISTS (SELECT *
             				   FROM Registration r
             				   WHERE c.ID_Client = r.ID_Client)
             """;

            using var connection = DB.GetOpenedConnection();

            var clients = connection.Query<ComboItem>(strQuery);

            textBox_Client.DataSource = clients.ToList();
            textBox_Client.DisplayMember = "FormattedText";
        }
        private void RoomInComboBox()
        {
            const string strQuery = """
             SELECT roomNumber [Text]
             FROM Room r 
             WHERE (typeName IN ('Lux', 'Half-lux', 'One-place') 
             		AND
             	   roomNumber NOT IN (SELECT roomNumber
             						  FROM Registration reg2
             						  WHERE r.roomNumber = reg2.roomNumber))
             		OR
             		(typeName IN ('Two-place', 'Multy-place') 
             		AND 
             		(SELECT COALESCE(SUM(countOfPeople), 0)
             		 FROM Registration reg2
             		 WHERE r.roomNumber = reg2.roomNumber) 
             		 < 
             		(SELECT countOfPlacesInType
             		 FROM [Type] t2
             		 WHERE r.typeName = t2.typeName))
             """;

            using var connection = DB.GetOpenedConnection();
            var rooms = connection.Query<ComboItem>(strQuery);

            textBox_roomNumber.DataSource = rooms.ToList();
            textBox_roomNumber.DisplayMember = "Text";
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (!Validate(out var registration))
                return;
            /*            DateTime arrivalDate = DateTime.Today;
                        string tmpArrivalDate = arrivalDate.ToString("yyyy-MM-dd");
                        DateTime tmpTmpArrivalDate = DateTime.Parse(tmpArrivalDate);

                        tmpTmpArrivalDate = tmpTmpArrivalDate.Date; */

            using var connection = DB.GetOpenedConnection();

            if (registration.IdBooking == 0)
            {
                string strQueryInsert = $"""
             INSERT INTO Registration (ID_Client, countOfPeople, roomNumber, arrivalDate, departureDate)
             VALUES (@IdClient, @CountOfPeople, @RoomNumber, CONVERT(varchar, GETDATE(), 23), @DepartureDate)
             """;

                connection.Execute(strQueryInsert, registration);
            }
            else
            {
                string tt = textBox_departureDate.Text;
                string strQueryInsert = $"""
             INSERT INTO Registration (ID_Booking, ID_Client, countOfPeople, roomNumber, arrivalDate, departureDate)
             VALUES (@IdBooking, @IdClient, @CountOfPeople, @RoomNumber, CONVERT(varchar, GETDATE(), 23), @DepartureDate)
             """;

                connection.Execute(strQueryInsert, registration);

                const string queryUpdateBooking = """
             UPDATE Booking SET arrived = (CASE 
             	WHEN EXISTS (SELECT * 
             				 FROM Registration r
             				 WHERE Booking.ID_Booking = r.ID_Booking) THEN 'TRUE'
             	ELSE 'FALSE'
               END)
             """;

                connection.Execute(queryUpdateBooking);
            }
            MessageBox.Show("Success", "Your registration has been added successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);





            CloseSelf();
        }
        private bool Validate(out Registration registration)
        {
            registration = new Registration();

            var areAllPropertiesSet = !string.IsNullOrWhiteSpace(textBox_idBooking.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_Client.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_countOfPeople.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_roomNumber.Text) &&
                                      /*                                      !string.IsNullOrWhiteSpace(textBox_arrivalDate.Text) &&*/
                                      !string.IsNullOrWhiteSpace(textBox_departureDate.Text);

            if (!areAllPropertiesSet)
            {
                MessageBox.Show("Validation Error", "You must fill in all fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var idBooking = 0;
            var countOfPeople = 0;
            var roomNumber = 0;
            /*            var arrivalDate = DateTime.MinValue;*/
            var departureDate = DateTime.MinValue;



            var areAllPropertiesValid = /*DateTime.TryParse(textBox_arrivalDate.Text, out arrivalDate) &&*/
                                        DateTime.TryParse(textBox_departureDate.Text, out departureDate) &&
                                        int.TryParse(textBox_countOfPeople.Text, out countOfPeople) &&
                                        int.TryParse(textBox_roomNumber.Text, out roomNumber) &&
                                        int.TryParse(textBox_idBooking.Text, out idBooking);

            if (!areAllPropertiesValid)
            {
                MessageBoxHandler.ValidationError("Some data are in incorrect format");
                return false;
            }

            if (/*arrivalDate != DateTime.Today || departureDate < arrivalDate*/departureDate < DateTime.Today)
            {
                MessageBox.Show("Validation Error", "Your dates are wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var client = textBox_Client.SelectedItem as ComboItem;

            if (client is null)
            {
                // ToDo: handle error
                MessageBox.Show("Choose correct client");
                return false;
            }
            /*if(idBooking == 0)*/
            registration = new Registration
            {
                IdClient = client.Id,
                /*                ArrivalDate = arrivalDate,*/
                DepartureDate = departureDate,
                IdBooking = idBooking,
                CountOfPeople = countOfPeople,
                RoomNumber = roomNumber
            };

            return true;
        }
        private void CloseSelf()
        {
            this.Hide();
            previousForm.Show();
        }

        private void textBox_idBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tmpBooking = textBox_idBooking.SelectedItem as ComboItem;

            if (tmpBooking.Id == 0 || tmpBooking.Id == null)
                return;

            string queryDataByIdBooking = """
             SELECT surname + ' ' + firstName + ' ' + middleName AS Client, 
                countOfPeople AS CountOfPeople, roomNumber AS RoomNumber,
                arrivalDate AS ArrivalDate, departureDate AS DepartureDate
             FROM Booking b INNER JOIN Client c ON b.ID_Client = c.ID_Client
             WHERE ID_Booking = @BookingId
             """;

            using var connection = DB.GetOpenedConnection();
            var registration = connection.QueryFirstOrDefault<Registration>(queryDataByIdBooking,new { BookingId = tmpBooking.Id });

            if (registration != null)
            {
                textBox_Client.Text = registration.Client;
                textBox_countOfPeople.Text = registration.CountOfPeople.ToString();
                textBox_roomNumber.Text = registration.RoomNumber.ToString();
                /*                    textBox_arrivalDate.Text = registration.ArrivalDate.ToString("yyyy-MM-dd");*/
                textBox_departureDate.Text = registration.DepartureDate.ToString("yyyy-MM-dd");
            }
            else
            {
                MessageBox.Show("Smth went wrong");
            }

        }

        private void textBox_roomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {// для максимальної кількості місць у комнаті (щоб не перевисити цю кількість)
            ComboItem? room = textBox_roomNumber.SelectedItem as ComboItem;

            if (room is null)
            {
                /*MessageBox.Show("You chose incorrect room! So choose correct room ");*/
                return;
            }

            string queryMaxCountOfPeopleInRoom = $"""
             SELECT countOfPlacesInType - COALESCE((SELECT SUM(countOfPeople)
             									   FROM Registration
             									   WHERE roomNumber = {room.Text})
             									   ,
             									   0) AS CountOfPlacesInType
             FROM Room r INNER JOIN [Type] t ON r.typeName = t.typeName
             WHERE roomNumber = {room.Text}
             """;

            using var connection = DB.GetOpenedConnection();
            Typee? type = connection.QueryFirstOrDefault<Typee>(queryMaxCountOfPeopleInRoom);

            textBox_countOfPeople.Maximum = type.CountOfPlacesInType;
        }


    }
}