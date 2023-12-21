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
    public partial class NewService_Form : Form
    {
        Form previousForm;
        public NewService_Form(Form prevForm)
        {
            InitializeComponent();
            previousForm = prevForm;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }
        private void CloseSelf()
        {
            this.Hide();
            previousForm.Show();
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (!Validate(out var service))
                return;

            using var connection = DB.GetOpenedConnection();

            string strQueryInsert = $"""
              INSERT INTO Service (serviceName, serviceDescription, servicePrice, isActiv) 
              VALUES (@ServiceName, @ServiceDescription, @ServicePrice, @IsActiv)
              """;

            connection.Execute(strQueryInsert, service);


            MessageBox.Show("Success", "Your service has been added successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CloseSelf();
        }
        private bool Validate(out Service service)
        {
            service = new Service();

            var areAllPropertiesSet = !string.IsNullOrWhiteSpace(textBox_serviceName.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_serviceDescription.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_servicePrice.Text) &&
                                      !string.IsNullOrWhiteSpace(textBox_isActiv.Text);

            if (!areAllPropertiesSet)
            {
                MessageBox.Show("Validation Error", "You must fill in all fields!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var servicePrice = 0;
            bool isActiv;

            if (textBox_isActiv.Text == "True")
                isActiv = true;
            else
                isActiv = false;

            var areAllPropertiesValid = int.TryParse(textBox_servicePrice.Text, out servicePrice);

            if (!areAllPropertiesValid)
            {
                MessageBoxHandler.ValidationError("Your price is incorrect");
                return false;
            }


            service = new Service
            {
                ServiceName = textBox_serviceName.Text,
                ServiceDescription = textBox_serviceDescription.Text,
                ServicePrice = servicePrice,
                IsActiv = isActiv
            };

            return true;
        }
    }
}
       