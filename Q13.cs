using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    class Bank
    {
        public static double InterestRate = 5.0; 

        public string AccountHolder;
        public double Balance;

        public Bank(string name, double balance)
        {
            AccountHolder = name;
            Balance = balance;
        }

        public static void SetInterestRate(double rate)
        {
            InterestRate = rate;
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance}, Interest Rate: {InterestRate}%");
        }
    }

}
