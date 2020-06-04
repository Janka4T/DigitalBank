using DigitalBag;
using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace DigitalBank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            accounts.Add(new Account("Jenifer", 200));
            accounts[0].MakeDeposit(300, "Sk8");    
            accounts[0].MakeWithdrawal(100, "Gaem");
            accounts[0].PrintStatus();
            accounts[0].PrintStatement();
            
            accounts.Add(new Account("MIke", 1232));
            accounts[1].MakeDeposit(12, "foaaere");
            accounts[1].MakeDeposit(34, "stuff");
            accounts[1].MakeWithdrawal(40, "Parads");
            accounts[1].PrintStatus();
            accounts[1].PrintStatement();

            List<Human> clients = new List<Human>();

            clients.Add(new Human("Jenifer", "Clever", "Blue", 132));            
            clients[0].SetHeight(-312);
            clients.Add(new Human("Below", "Desk", "Rainbow", 189));
            clients.Add(new Human("Novel", "Grab", "Blue", 102));

            clients[2].AddNumbersFromMemory();
            clients[2].AddNumbers(16, 2);

            foreach(Human c in clients)
            {
                c.Introduce();
            }
        }
    }
}
