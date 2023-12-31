﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddRentalRecord : Form
    {
        private readonly CarRentalEntities2 _db;
        public AddRentalRecord()
        {
            InitializeComponent();
            _db = new CarRentalEntities2();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = tbCustomerName.Text;
                DateTime dateRented = dtDateRented.Value;
                DateTime dateReturn = dtDateReturn.Value;
                string typeOfCar = cbTypeOfCar.Text;
                double cost = 0;
                cost = Convert.ToDouble(tbCost.Text);
                bool isValid = true;
                string errorMessage = "";

                if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(typeOfCar))
                {
                    isValid = false;
                    errorMessage += "Please provide Missing data.\n";
                }

                if (dateRented > dateReturn)
                {
                    isValid = false;
                    errorMessage += "Illegal date selection\n";
                }

                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = customerName;
                    rentalRecord.DateRented = dateRented;
                    rentalRecord.DateReturn = dateReturn;
                    rentalRecord.Cost = (decimal)cost;
                    rentalRecord.TypeOfCardId = (int)cbTypeOfCar.SelectedValue;
                    _db.CarRentalRecords.Add(rentalRecord);
                    _db.SaveChanges();

                    MessageBox.Show($"Thank you for renting {customerName}.\nYour Rented date is {dateRented}\nReturn date is {dateReturn}\nCar Type is {typeOfCar}\nCost : {cost}");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cars = _db.TypesOfCars.ToList();
            cbTypeOfCar.DisplayMember = "Name";
            cbTypeOfCar.ValueMember= "id";
            cbTypeOfCar.DataSource = cars;
        }

       
    }
}
