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
        public GarageForm()
        {
            InitializeComponent();
        }

        private void buttonStartCar_Click(object sender, EventArgs e)
        {
            DriveForm driveForm = new DriveForm();
            driveForm.ShowDialog();
        }

        private void GarageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
