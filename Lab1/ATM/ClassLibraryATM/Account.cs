using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryATM
{
    //принцип I(Interface Segregation Principle)
    public class Account
    {
        public string CardNumber { get; set; }
        public string OwnerName { get; set; }
        public decimal Balance { get; set; }
        public Account(string cardNumber, string ownerName, decimal balance)
        {
            CardNumber = cardNumber;
            OwnerName = ownerName;
            Balance = balance;
        }
        public Account() { }
    }
}
