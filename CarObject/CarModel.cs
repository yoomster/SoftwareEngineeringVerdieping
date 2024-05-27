using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    public class CarModel
    {
        private string? Manufacturer { get; set; }
        private string? Model { get; set; }
        private int Speed { get; set; }
        private int MaxSpeed { get; set; }

    
        public void SetManufacturer(string manufacturer)
        {
            Manufacturer = manufacturer;
            SetMaxSpeed();
        }
        public void SetMaxSpeed()
        {
            if (Manufacturer == "Toyota")
            {
                MaxSpeed = 170;
            }
            else if (Manufacturer == "Tesla")
            {
                MaxSpeed = 260;
            }
            else
            {
                MaxSpeed = 120;
            }
        }
        public void SetModel(string model)
        {
            Model = model;
        }

        public string GetInfo()
        {
           return $"{Manufacturer} {Model} heeft een max snelheid van {MaxSpeed} en rijdt nu {Speed}";
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
    }
}