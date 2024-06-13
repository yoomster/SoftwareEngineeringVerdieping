using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class GarageModel
    {
        public string Name { get; set; }
        public CarModel? ChosenCar { get; set; }

        public List<CarModel> Cars = new List<CarModel>();

        public void AddCar(CarModel car)
        {
            Cars.Add(car);
        }

        public List<CarModel> ShowCars()
        {
            return Cars;
        }

        public void SelectCar(CarModel car)
        {
            ChosenCar = car;
        }
    }
}

//show all the cars that are in garage
//select 1 car, that you choose to drive
//by clicking start drive, open new form to drive the chosen car