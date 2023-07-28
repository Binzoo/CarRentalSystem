using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities2 _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities2();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            var cars = _db.TypesOfCars.Select(q => new { Make = q.Make, Model = q.Model, VIN = q.VIN, Year = q.Year, LicensePlateNumber = q.LicensePlateNumber }).ToList();
          //  var cars = _db.TypesOfCars.ToList();
           gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[0].HeaderText = "ID";
            gvVehicleList.Columns[1].HeaderText = "NAME";
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

        }
    }
}
