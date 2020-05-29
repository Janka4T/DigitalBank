using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DigitalBag
{
    class Account
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; }
        public DateTime Created { get; }

        private List<Transaction> transactions = new List<Transaction>();

        public Account(string owner, decimal balance)
        {
            this.Number = "242345";
            this.Owner = owner;
            this.Balance = balance;
            this.Created = DateTime.Now;
        }
    }
}
