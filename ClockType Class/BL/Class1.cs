using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockType_Class.BL
{
    class ClockType
    {
        public ClockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public ClockType(int h)
        {
            hours = h;
        }
        public ClockType(int H,int M)
        {
            hours = H;
            minutes = M;
        }
        public ClockType(int h, int m, int sec)
        {
            hours = h;
            minutes = m;
            seconds = sec;
        }

        public int hours;
        public int minutes;
        public int seconds;
        public int elapsedTime;
        public int RemainingTime;
        public int Time;
        public void increamentSecond()
        {
            seconds++;
        }
        public void incrementminutes()
        {
            minutes++;
        }
        public void incrementhours()
        {
            hours++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }
        public bool isEqual(int h, int m, int s)
        {
            if(hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(ClockType temp)
        {
            if(hours == temp.hours && minutes == temp.minutes && seconds == temp.seconds)
                    {
                return true;
            }
            else
            {
                return false;
            }
        }
        public getTime(ref int hours, ref int minutes, ref int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public void setTime(int hours, int minutes, int seconds)
        {
            if(0<=hours && hours <24)
            {
                this.hours = hours;

            }
            else
            {
                this.hours = 0;

            }
            if(0<=minutes && minutes <60)
            {
                this.minutes = minutes;
            }
            else
            {
                this.minutes = 0;
            }
            if(0<=seconds && seconds <60)
            {
                this.seconds = seconds;
            }
            else
            {
                this.seconds = 0;
            }
        }
        public int CurrentTime()
        {
            this.hours = this.hours * 60 * 60;
            this.minutes = this.minutes * 60;
            this.Time = this.hours + this.minutes + this.seconds;
            return Time;
        }
        public int ElapsedTime()
        {
            this.elapsedTime = 
            

        }

    }
}
