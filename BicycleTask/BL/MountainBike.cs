using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleTask.BL
{
    class MountainBike : Bicycle
    {
        private int seatHeight;
        public MountainBike(int seatHeight,int cadence,int speed,int gear)
        {

        }
        public void setSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }


    }
}
