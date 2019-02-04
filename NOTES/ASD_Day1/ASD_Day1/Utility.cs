using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DVP1
{
    class Utility
    {
        //Validations
        //String to int method
        public static int StringToInt(string stringInput)
        {
            //Create int variable
            int intInput;
            //while loop to validate input
            while (!int.TryParse(stringInput, out intInput))
            {
                //Ask user to enter correctly
                Console.WriteLine("Please enter number values only");
                //Recapture input
                stringInput = Console.ReadLine();
            }
            //Return Value
            return intInput;
        }

        public static int CheckNum(string num)
        {
            int result;
            while (!int.TryParse(num, out result))
            {
                Console.WriteLine("Please numbers only");
            }
            return result;
        }

        public static string CheckString(string s)
        {
            //Validate string is not null or whitespace
            while (string.IsNullOrWhiteSpace(s) || Regex.IsMatch(s, @"\d"))
            {
                Console.WriteLine("String can not be empty, white space, or contain numbers. Please try again.");
                s = Console.ReadLine();
            }
            return s;
        }


    }
}
