using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject
{
    public class CarModel
    {
        private string? Manufacturer { get; set; }
        private string? Model { get; set; }
        private int Speed { get; set; }
        private int MaxSpeed { get; set; }

        public void SetManufacturer(string brand)
        {
            Manufacturer = brand;
        }

        public void SetModel(string model)
        {
            Model = model;
        }

        public string GetInfo()
        {
            return $"{Manufacturer} {Model} heeft een max snelheid van {MaxSpeed} en rijdt nu {Speed}";
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }

        public void SpeedUp()
        {
            if (Speed <= (MaxSpeed - 7))
            {
                Speed += 7;
            }
            else
            {
                Speed = MaxSpeed;
            }
        }

        public void SlowDown()
        {
            if (Speed >= 10)
            {
                Speed -= 10;
            }
            else
            {
                Speed = 0;
            }
        }

        public string GetCarManufacturerAndModel()
        {
            return $"{Manufacturer} – {Model}";
        }
    }
}