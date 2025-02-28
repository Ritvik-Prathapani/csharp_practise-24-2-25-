using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    class BankAccount
    {
        private int balance { get; set; }
        public BankAccount()
        {
            balance = 0;
        }
        public BankAccount(int initialBalance)
        {
            this.balance = initialBalance;
        }
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
            Console.WriteLine("Current Balance: " + this.balance);

        }
        public void Withdraw(int amount)
        {
            if(balance >= amount)
                balance -= amount;
            else
            {
                Console.WriteLine("insufficinet funds");
            }
        }
    }
}
