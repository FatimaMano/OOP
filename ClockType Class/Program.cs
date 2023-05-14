using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using ClockType_Class.BL;

namespace ClockTypeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //default Constructor
            ClockType empty_time = new ClockType();
            Console.Write("Empty Time: ");
            empty_time.printTime();
            //Paraemterized Constructor
            ClockType hour_time = new ClockType(8);
            Console.Write("Hour time: ");
            hour_time.printTime();
            // Parametrized constructor (two Parameters)
            ClockType minute_time = new ClockType(8, 10);
            Console.Write("Minute Time: ");
            minute_time.printTime();
            //Parametrized constructor (three parameters)
            ClockType full_time = new ClockType(8,10,10);
            Console.Write("Full time: ");
            full_time.printTime();
            //increment Second
            full_time.increamentSecond();
            full_time.printTime();
            //incremnt hours
            full_time.incrementhours();
            Console.Write("Full time (Increment hours: ");
            full_time.printTime();
            //Increment minutes;
            full_time.incrementminutes();
            Console.Write("Full time (Increment hours: ");
            full_time.printTime();
            // check if equal
            bool flag = full_time.isEaual(9, 11, 11);
            Console.WriteLine("Flag: " + flag);
            //check if equal with object
            ClockType cmp = new ClockType(10, 12, 1);
            flag = full_time.isEqual(cmp);
            Console.WriteLine("Object Flag: " + flag);
        }
    }
}