using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        //Mohamed Bayo
        //ASD 02-2019
        //Menu: Will allow user to choose create customer and account details
namespace MohamedBayo_CE02
{
    class Menu
    {
        //Declare Customer Variable 
         public static Customer currentCustomer = null;
        public static CheckingAccount customerAccount = null;

        public static void Menus()
        {
            Console.Clear();
            //Prompt User to choose from the Menu
            Console.WriteLine("Hello! Welcome to the Banking Program\r\nPlease choose from the following\r\n [1] Create Customer\r\n [2] Create Checking Account" +
                "\r\n [3] Set Account Balance\r\n [4] Display Account Balance\r\n [0] Close App");
            //Validate and store user's input
            int choice = Validation.StringToInt(Console.ReadLine());
            //Only allow users to choose from 0-5
            while (!(choice >=0 && choice <=6))
            {
                //tell user what is wrong
                Console.WriteLine("Please Choose from 0-5");
                //capture user's new answer
                 choice = Validation.StringToInt(Console.ReadLine());
            }

            //Switch Statements
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    //Prompt user for name
                    Console.WriteLine("Please enter customer's name");
                    //Validate
                    string name = Validation.CheckString(Console.ReadLine());
                    //Send arguements to parameters to create customer
                    currentCustomer = new Customer(name);
                    break;
                case 2:
                    //If else statement to make sure user created customer first
                    if (Customer.mCustomerName == null)
                    {
                        //Prompt user to create customer first
                        Console.Clear();
                        //tell user whats wrong
                        Console.WriteLine("Please create a new customer first");
                        Console.ReadKey();
                        //back to menu
                        Menu.Menus();
                    }
                    else
                        Console.Clear();
                    //Ask User for account #
                    Console.WriteLine("Please enter customer's account number");
                    //Validate User's input
                    int account =Validation.CheckNum(Console.ReadLine());
                    //Ask User for balance
                    Console.WriteLine("Please enter customer's available balance");
                    //validate and store user's input
                    decimal balance = Validation.StringToDecimal(Console.ReadLine());
                    //Send arguements to parameters to create customer account
                    Customer.mCustomerAccount = new CheckingAccount(account, balance);
                    break;
                case 3:
                    if (Customer.mCustomerAccount == null && Customer.mCustomerName == null)
                    {
                        Console.Clear();
                        //Tell user whats wrong
                        Console.WriteLine("Please create a new customer first and create checking account\r\nPress any key to return to menu.");
                        Console.ReadKey();
                        //Return to menu
                        Menu.Menus();
                    }
                    else
                    {
                        Console.Clear();
                        //Ask user for added funds
                        Console.WriteLine($"Please enter {Customer.mCustomerName}'s New account balance");
                        //Validate user's input
                        decimal newBal = Validation.StringToDecimal(Console.ReadLine());
                        //add funds to customers account
                        
                    }
                    break;
                case 4:
                    if (Customer.mCustomerAccount == null && Customer.mCustomerName == null)
                    {
                        //Tell user what is wrong
                        Console.WriteLine("Please create a new customer first and create checking account");
                        Console.ReadKey();
                        //return to menu
                        Menu.Menus();
                    }
                    else
                    {
                        //Output current customers account info
                        Console.WriteLine($"{Customer.mCustomerName}'s available balance is {Customer.mCustomerAccount}");
                    }
                    break;
                default:
                    //Close Program
                    Environment.Exit(0);
                    break;

            }


        }
    }
}
