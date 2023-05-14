using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDweek4Angle.BL
{
    public class Angle
    {
        public int degrees;
        public float minutes;
        public char direction;



        public Angle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public void SetAngle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public string ToFormattedString()
        {
            return string.Format("{0}\u00b0{1:0.0}' {2}", degrees, minutes, direction);
        }

    }
}
