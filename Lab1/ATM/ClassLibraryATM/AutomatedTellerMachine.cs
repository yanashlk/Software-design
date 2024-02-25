using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryATM
{
    //Composition Over Inheritance
    public class AutomatedTellerMachine
    {
        public decimal CheckBalance(Account account)
        {
            // Повертаємо баланс картки
            return account.Balance;
        }

        //Fail Fast
        public bool Withdraw(Account account, decimal amount)
        {
            if (account.Balance >= amount )
            {
                account.Balance -= amount;
                return true;
            }
            return false;
        }

        public void Deposit(Account account, decimal amount)
        {
            account.Balance += amount;
        }

        public void Transfer(Account sourceAccount, Account destinationAccount, decimal amount)
        {
            if (Withdraw(sourceAccount, amount))
            {
                Deposit(destinationAccount, amount);
            }
        }

    }
}
