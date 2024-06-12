using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    internal class GarageModel
    {
        private List<CarModel> cars = new List<CarModel>();

        public void AddCar(CarModel car)
        {
            cars.Add(car);
        }

        public List<CarModel> ShowCars()
        {
            return cars;
        }

        public CarModel SelectCar(string car)
        {
            return car;
        }
    }
}
