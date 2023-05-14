using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDWeek4Angle.BL;

namespace PWeek4Ship.BL
{
    public class Ship
    {
        public int Number;
        public string Latitude;
        public string Longitude;

        public Ship(int serialNumber, Angle latitude, Angle longitude)
        {
            this.serialNumber = serialNumber;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public void PrintPosition()
        {
            Console.WriteLine("Latitude: {0}, Longitude: {1}", latitude.ToFormattedString(), longitude.ToFormattedString());
        }

        public void PrintSerialNumber()
        {
            Console.WriteLine("Serial Number: {0}", serialNumber);
        }

        public void SetPosition(Angle latitude, Angle longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
        public string ToFormattedString()
        {
            return string.Format("{0}\u00b0{1:0.0}' {2}", degrees, minutes, direction);
        }

    }
}


