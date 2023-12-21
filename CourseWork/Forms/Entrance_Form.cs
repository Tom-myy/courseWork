using CourseWork.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class Entering_Form : Form
    {
        public Entering_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_log_in_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;
            string strQuery = $"""
             SELECT idUser AS IdUser, loginUser AS LoginUser, 
              	    passwordUser AS PasswordUser, isAdmin AS IsAdmin
             FROM UsersTable 
             WHERE loginUser = @l AND passwordUser = @p
             """;

            using var connection = DB.GetOpenedConnection();
            var user = connection.QueryFirstOrDefault<CheckUser>(strQuery, new { l = login, p = password });

            if (user != null)
            {
                Main_Form mainForm = new Main_Form(user);
                this.Hide();
                mainForm.Show();
            }
            else
                MessageBox.Show("You entered incorrect data");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            pictureBox_passwordUnlock.Visible = true;
            pictureBox_passwordLock.Visible = false;
        }

        private void pictureBox_passwordUnlock_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            pictureBox_passwordUnlock.Visible = false;
            pictureBox_passwordLock.Visible = true;
        }
    }
}
