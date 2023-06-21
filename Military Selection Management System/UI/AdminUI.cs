﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Military_Selection_Management_System.BL;
namespace Military_Selection_Management_System.DL
{
	public class AdminUI
	{
        // Admin Screen
        public static int AdminMenu()
        {

            int option = 10;
            do
            {
                UI.PersonUI.subMenu("AdminScreen");
                Console.WriteLine("0: SignIn/SignUp Screen");
                Console.WriteLine("1: To add Candidate");
                Console.WriteLine("2: to View the top candidates");
                Console.WriteLine("3: to Show a report");
                Console.WriteLine("4: to Modify the information of the candidates");
                Console.WriteLine("5: to Delete a candidate");
                Console.WriteLine("6: to Search a student");
                Console.WriteLine("7: to Update the test results of a student");
                Console.WriteLine("8: to See the complaints by the Students");
                Console.WriteLine("9: Set the test schedule");
                option = UI.PersonUI.IntegerValidation();
            } while (option > 9);
            return option;
        }
    }
}
