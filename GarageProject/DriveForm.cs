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
    public partial class DriveForm : Form
    {
        private CarModel car;
        public DriveForm()
        {
            InitializeComponent();
            GetSelectedCar();
        }

        private void GetSelectedCar()
        {

        }

        private void buttonBrake_Click(object sender, EventArgs e)
        {
            Car.SlowDown();
        }

        private void buttonDrive_Click(object sender, EventArgs e)
        {
            car.SpeedUp();
        }

        private void DriveForm_Load(object sender, EventArgs e)
        {
            labelCarInfo.Text = car.GetInfo();
        }
    }
}
