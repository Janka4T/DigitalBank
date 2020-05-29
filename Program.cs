using DigitalBag;
using System;
using System.Collections.Generic;

namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<Account> accounts = new List<Account>();

            accounts.Add(new Account("Jenifer", 200));
            Console.WriteLine($"Client {accounts[0].Owner} has {accounts[0].Balance} EUR in account nr {accounts[0].Number} created on {accounts[0].Created.ToString("dd/MM/yyyy")}.\n");

            accounts.Add(new Account("MIke", 32));
            Console.WriteLine($"Client {accounts[1].Owner} has {accounts[1].Balance} EUR in account nr {accounts[1].Number} created on {accounts[1].Created.ToString("dd/MM/yyyy")}.\n");


        }
    }
}
