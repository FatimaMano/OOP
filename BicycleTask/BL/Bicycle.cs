using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleTask.BL
{
    class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;
        public Bicycle(int cadence,int gear,int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }
        public void setCadence(int cardence)
        {
            this.cardence = cardence;
        }
        public void setGear(int gear)
        {
            this.gear = gear;
        }
        public void applyBrake(int decrement)
        {

        }
        public void speedUp(int increment)
        {

        }
    }
}
