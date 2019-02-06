using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedBayo_CE02
{
    class CheckingAccount
    {
        //Declare Fields 
        public  decimal mBalance;
        public static  int mAccount;

        public CheckingAccount(int a, decimal b)
        {
            mAccount = a;
            mBalance = b;
            Console.WriteLine($"{Customer.mCustomerName}'s Account Created\r\nPress any key to return to menu");
            Console.ReadKey();
            Menu.Menus();
        }
      
    }
}
