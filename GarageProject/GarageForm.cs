using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageProject
{
    public partial class GarageForm : Form
    {
        private GarageModel garage;
        public GarageForm()
        {
            InitializeComponent();
        }

        private void GarageForm_Load(object sender, EventArgs e)
        {
            InitializeGarage();
            PopulateCarListBox();
        }

        private void buttonStartCar_Click(object sender, EventArgs e)
        {
            DriveForm driveForm = new DriveForm();
            driveForm.ShowDialog();
        }

        private void SaveSelectedCar()
        {
            garage.SelectCar(listBoxCars.SelectedItem);
        }

        private void InitializeGarage()
        {
            garage = new GarageModel
            {
                Name = "Naomis Garage"
            };

            CarModel toyota = new CarModel();
            toyota.SetManufacturer("Toyota");
            toyota.SetModel("Yaris");
            toyota.SetMaxSpeed(170);

            CarModel tesla = new CarModel();
            tesla.SetManufacturer("Tesla");
            tesla.SetModel("Cross");
            toyota.SetMaxSpeed(260);

            garage.AddCar(toyota);
            garage.AddCar(tesla);
        }

        private void PopulateCarListBox()
        {
            listBoxCars.Items.Clear();

            foreach (var car in garage.Cars)
            {
                listBoxCars.Items.Add($"{car.GetCarManufacturerAndModel()}");
            }
        }
    }
}
