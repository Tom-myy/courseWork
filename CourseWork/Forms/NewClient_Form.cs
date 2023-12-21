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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{
    public partial class NewClient_Form : Form
    {
        private readonly CheckUser _user;
        
    
        Form previousForm;

        bool tmpBoolForInform = false;
        public NewClient_Form(Form prevForm, CheckUser user)
        {
            previousForm = prevForm;
            _user = user;
            InitializeComponent();
            textBox_bithday.Mask = "0000-00-00";
        }
        private void clearFields()
        {
            textBox_surname.Text = "";
            textBox_firstName.Text = "";
            textBox_middleName.Text = "";
            textBox_bithday.Text = "";
            textBox_gender.SelectedItem = null;
            textBox_clientAddress.Text = "";
            textBox_clientPhoneNumber.Text = "";
            textBox_clientPassportNumber.Text = "";
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_surname.Text != "" &&
            textBox_firstName.Text != "" &&
            textBox_middleName.Text != "" &&
            textBox_bithday.Text != "" &&
            textBox_gender.Text != "" &&
            textBox_clientAddress.Text != "" &&
            textBox_clientPhoneNumber.Text != "" &&
            textBox_clientPassportNumber.Text != "")
            {
                string surname = textBox_surname.Text;
                string firstName = textBox_firstName.Text;
                string middleName = textBox_middleName.Text;
                DateTime birthday;
                string gender = textBox_gender.Text;
                string clientAddress = textBox_clientAddress.Text;
                string clientPhoneNumber = textBox_clientPhoneNumber.Text;
                string clientPassportNumber = textBox_clientPassportNumber.Text;

                if (DateTime.TryParse(textBox_bithday.Text, out birthday))
                {
                    DateTime minAllowedDate = DateTime.Today.AddYears(-16);
                    if (birthday.Date <= minAllowedDate)
                    {
                        string tmpBirthday = birthday.Date.ToString("yyyy-MM-dd");
                        string strQueryInsert = $"""
                        INSERT INTO Client (surname, firstName, middleName, birthday, gender, 
                        					clientAddress, clientPhoneNumber, clientPassportNumber)
                        VALUES ('{surname}', '{firstName}', '{middleName}', '{tmpBirthday}',
                                '{gender}', '{clientAddress}', '{clientPhoneNumber}', '{clientPassportNumber}')
                        """;

                        using var connection = DB.GetOpenedConnection();
                        int sss = connection.Execute(strQueryInsert);

                        clearFields();
                    }
                    else
                        MessageBox.Show("The person must be over 16 years old");
                }
                else
                    MessageBox.Show("You must fill in birthday field in format 'yyyy-MM-dd' like '2000-01-01'!");
            }
            else
                MessageBox.Show("You must fill in all fields!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ToolStripMenuItem_mainPage_Click(object sender, EventArgs e)
        {
            Main_Form mainForm = new Main_Form(_user);
            mainForm.Show();
            this.Hide();
        }
        private void pictureBox_info_Click(object sender, EventArgs e)
        {
            if (tmpBoolForInform == false)
            {
                textBox_surname.Text = "Іванов";
                textBox_firstName.Text = "Іван";
                textBox_middleName.Text = "Іванович";
                textBox_bithday.Text = "2000-12-31";
                textBox_gender.Text = "Чол";
                textBox_clientAddress.Text = "Харків, вул. Чайковська 1, кв. 1";
                textBox_clientPhoneNumber.Text = "+380938048272";
                textBox_clientPassportNumber.Text = "AA112200";

                textBox_surname.ForeColor = Color.Gray;
                textBox_firstName.ForeColor = Color.Gray;
                textBox_middleName.ForeColor = Color.Gray;
                textBox_bithday.ForeColor = Color.Gray;
                textBox_gender.ForeColor = Color.Gray;
                textBox_clientAddress.ForeColor = Color.Gray;
                textBox_clientPhoneNumber.ForeColor = Color.Gray;
                textBox_clientPassportNumber.ForeColor = Color.Gray;

                tmpBoolForInform = true;
                button_save.Enabled = false;
            }
            else
            {
                clearFields();

                textBox_surname.ForeColor = Color.Black;
                textBox_firstName.ForeColor = Color.Black;
                textBox_middleName.ForeColor = Color.Black;
                textBox_bithday.ForeColor = Color.Black;
                textBox_gender.ForeColor = Color.Black;
                textBox_clientAddress.ForeColor = Color.Black;
                textBox_clientPhoneNumber.ForeColor = Color.Black;
                textBox_clientPassportNumber.ForeColor = Color.Black;

                tmpBoolForInform = false;
                button_save.Enabled = true;
            }
        }

        private void pictureBox_eraser_Click(object sender, EventArgs e)
        {
            if (!tmpBoolForInform)
            {
                clearFields();
            }
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }
    }
}
