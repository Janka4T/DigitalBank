using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DigitalBag
{
    class Account
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }
        public DateTime Created { get; set; }

        public Account(string owner, decimal balance)
        {
            this.Number = "242345";
            this.Owner = owner;
            this.Balance = balance;
            this.Created = DateTime.Now;
        }
    }
}
