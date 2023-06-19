using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;
namespace Military_Selection_Management_System.UI
{
    class CandidateUI
    {
        public static int ChooseInterface()
        {
            int option  = 4;
            do
            {
                Console.WriteLine("1. Are you a Candidate");
                Console.WriteLine("2. Are you a Staff");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your option");
                option = PersonUI.IntegerValidation();
                Console.Clear();
            } while (option>2);
            return option;
        }
        public static int LogMenuScreen()
        {
            Console.Clear();
            PersonUI.PrintHeader();
            PersonUI.subMenuBeforeMainMenu("LogScreen");
            int option = 0;
            do
            {
                Console.WriteLine(" 1. Sign in");
                Console.WriteLine(" 2. Sign up");
                Console.WriteLine(" 3. Back");
                Console.WriteLine(" 0. Exit");
                Console.WriteLine("Enter your option");
                option = PersonUI.IntegerValidation();
                Console.Clear();
            } while (option>3);
            return option;
        }

    }
}
