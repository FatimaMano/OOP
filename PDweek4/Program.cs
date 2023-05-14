using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using System.Data;
using PWeek4Ship.BL;
using PDweek4Angle.BL;

namespace BootingCSharp
{
    class Program
    {
        static int main(string[] args)
        {
            int choice;
            Ship myShip = null;

            do
            {
                Console.WriteLine("\n--- Ship Navigation Menu ---");
                Console.WriteLine("1. Add Ship");
                Console.WriteLine("2. View Ship Position");
                Console.WriteLine("3. View Ship Serial Number");
                Console.WriteLine("4. Change Ship Position");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        if (myShip != null)
                        {
                            Console.WriteLine("A ship has already been added.");
                        }
                        else
                        {
                            myShip = AddShip();
                        }
                        break;
                    case 2:
                        ViewShipPosition(myShip);
                        break;
                    case 3:
                        ViewShipSerialNumber(myShip);
                        break;
                    case 4:
                        ChangeShipPosition(myShip);
                        break;
                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }

            } while (choice != 5);
        }

        static Ship AddShip()
        {
            Console.Write("Enter ship's serial number: ");
            int serialNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ship's latitude:");
            Angle latitude = GetAngle();

            Console.WriteLine("Enter ship's longitude:");
            Angle longitude = GetAngle();

            return new Ship(serialNumber, latitude, longitude);
        }

        static Angle GetAngle()
        {
            Console.Write("Enter degrees: ");
            int degrees = int.Parse(Console.ReadLine());

            Console.Write("Enter minutes: ");
            float minutes = float.Parse(Console.ReadLine());

            Console.Write("Enter direction (N/S/E/W): ");
            char direction = char.Parse(Console.ReadLine().ToUpper());

            return new Angle(degrees, minutes, direction);
        }

        static void ViewShipPosition(Ship ship)
        {
            if (ship == null)
            {
                Console.WriteLine("No ship has been added yet.");
            }
            else
            {
                Console.WriteLine("Ship position:");
                Console.WriteLine("Latitude: " + ship.Latitude.ToString());
                Console.WriteLine("Longitude: " + ship.Longitude.ToString());
            }
        }

        static void ViewShipSerialNumber(Ship ship)
        {
            if (ship == null)
            {
                Console.WriteLine("No ship has been added yet.");
            }
            else
            {
                Console.WriteLine("Ship serial number: " + ship.SerialNumber);
            }
        }

        static void ChangeShipPosition(Ship ship)
        {
            if (ship == null)
            {
                Console.WriteLine("No ship has been added yet.");
            }
            else
            {
                Console.WriteLine("Enter new ship position:");
                Console.WriteLine("Enter new latitude:");
                ship.Latitude = GetAngle();

                Console.WriteLine("Enter new longitude:");
                ship.Longitude = GetAngle();
            }
        }
    }
}
