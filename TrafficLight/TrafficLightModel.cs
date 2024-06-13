using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TrafficLight
{
    public class TrafficLightModel
    {

        public ColourEnum Colour { get; set; } = ColourEnum.Rood;

        public string ShowColour()
        {
            return $"{Colour}";
        }

        public void NextState()
        {
            if (Colour == ColourEnum.Oranje)
            {
                Colour = ColourEnum.Rood;
            }
            else 
            {
                Colour++;
            }
        }
    }
}
