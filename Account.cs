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
        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach(Transaction t in transactions)
                {
                    balance += t.Amount;
                }
                return balance;
            }
        }
        public DateTime Created { get; }
          
        private static int accountNumber = 000000001;

        private List<Transaction> transactions = new List<Transaction>();

        public Account(string owner, decimal initialbalance)
        {
            this.Number = "LV " + accountNumber.ToString();
            accountNumber++;
            this.Owner = owner;
            this.MakeDeposit(initialbalance, "Initial Balance");
            this.Created = DateTime.Now;
            Console.WriteLine($"Account for {this.Owner} is created. on {this.Created.ToString("dd/MM/yyyy hh:mm:ss")}");
        }

        public void MakeDeposit(decimal amount, string notes)
        {
            Transaction deposit = new Transaction(amount, DateTime.Now, notes);
            transactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, string notes)
        {
            Transaction withdrawal = new Transaction(-amount, DateTime.Now, notes);
            transactions.Add(withdrawal);
        }

        public void PrintStatus()
        {
            Console.WriteLine($"Client {this.Owner} has {this.Balance} EUR in account nr {this.Number} created on {this.Created.ToString("dd/MM/yyyy")}.\n");
        }

        public void PrintStatement()
        {
            StringBuilder report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNotes");

            foreach(Transaction t in transactions)
            {
                balance += t.Amount;
                report.AppendLine($"{t.Date.ToShortDateString()}\t{t.Amount}\t{balance}\t{t.Notes}");
            }
            Console.WriteLine(report.ToString());
        }
    }
}
