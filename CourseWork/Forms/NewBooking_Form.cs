using CourseWork.Models;
using Dapper;

namespace CourseWork
{
    public partial class NewBooking_Form : Form
    {
        Form previousForm;
        public NewBooking_Form(Form prevForm)
        {
            previousForm = prevForm;
            InitializeComponent();
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            CloseSelf();
        }
        private void ClearFields()
        {
            textBox_Client.SelectedItem = null;
            textBox_countOfPeople.Text = "";
            textBox_roomNumber.SelectedItem = null;
            textBox_arrivalDate.Text = "";
            textBox_departureDate.Text = "";
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (!Validate(out var booking))
                return;

            using var connection = DB.GetOpenedConnection();

            string strQueryInsert = $"""
                         INSERT INTO Booking (ID_Client, countOfPeople, roomNumber, arrivalDate, departureDate) 
              VALUES (@IdClient, @CountOfPeople, @RoomNumber, @ArrivalDate, @DepartureDate)
              """;

            connection.Execute(strQueryInsert, booking);

            MessageBox.Show("Success", "Your booking has been added successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CloseSelf();
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
            textBox_Client.DisplayMember = "FormattedText";
        }
        private void RoomsInComboBox()
        {
            const string strQuery = """
             SELECT roomNumber AS [Text]
             FROM Room
             """;

            using var connection = DB.GetOpenedConnection();

            var rooms = connection.Query<ComboItem>(strQuery);

            textBox_roomNumber.DataSource = rooms.ToArray();
            textBox_roomNumber.DisplayMember = "Text";
        }
        private void NewBooking_Form_Load(object sender, EventArgs e)
        {
            textBox_arrivalDate.Mask = "0000-00-00";
            textBox_departureDate.Mask = "0000-00-00";
            ClientsInComboBox();
            textBox_Client.SelectedItem = null;
            RoomsInComboBox();
            textBox_roomNumber.SelectedItem = null;
        }
        private void pictureBox_eraser_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void pictureBox_info_Click(object sender, EventArgs e)
        {

        }

        private bool Validate(out Booking booking)
        {
            booking = new Booking();

            var areAllPropertiesSet = !string.IsNullOrWhiteSpace(textBox_Client.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_countOfPeople.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_roomNumber.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_arrivalDate.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_departureDate.Text);

            if (!areAllPropertiesSet)
            {
                MessageBox.Show("Validation Error", "You must fill in all fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var countOfPeople = 0;
            var roomNumber = 0;
            var arrivalDate = DateTime.MinValue;
            var departureDate = DateTime.MinValue;

            var areAllPropertiesValid = DateTime.TryParse(textBox_arrivalDate.Text, out arrivalDate) &&
                                        DateTime.TryParse(textBox_departureDate.Text, out departureDate) &&
                                        int.TryParse(textBox_countOfPeople.Text, out countOfPeople) &&
                                        int.TryParse(textBox_roomNumber.Text, out roomNumber);

            if (!areAllPropertiesValid)
            {
                MessageBoxHandler.ValidationError("Some data are in incorrect format");
                return false;
            }

            if (arrivalDate < DateTime.Today || departureDate < arrivalDate)
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

            booking = new Booking
            {
                IdClient = client.Id,
                ArrivalDate = arrivalDate,
                DepartureDate = departureDate,
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
    }
}