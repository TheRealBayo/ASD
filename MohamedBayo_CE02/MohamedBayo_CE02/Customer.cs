using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedBayo_CE02
{
    class Customer
    {

        public static string mCustomerName;
        public static CheckingAccount mCustomerAccount = null;
         
        public Customer(string n)
        {
            mCustomerName = n;
            Console.WriteLine($"{mCustomerName}'s account Created\r\nPress any key to return to menu.");
            Console.ReadKey();
            Menu.Menus();
            
        }
      

    }
}
