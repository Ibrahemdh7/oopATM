using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPFree
{
    internal class Program
        
    {
        static void Main(string[] args)
        {


            List<Cardholder> cardHolders = new List<Cardholder>();
            cardHolders.Add(new Cardholder("123123123", 1234, "ibrahem", "Dhaher", 10000));
            cardHolders.Add(new Cardholder("123412341", 4321, "ahmed", "Yafe", 320.24));
            cardHolders.Add(new Cardholder("123451234", 1342, "yousef", "Alsmirre", 150.21));
            cardHolders.Add(new Cardholder("123456123", 3124, "khalid", "Alharbi", 553.60));

            Console.Write("==========Welcom to SimpleAtm==========");
            Console.Write("Please insert your debit card:");
            string debitCadnum = "";
            Cardholder currentUser;


            while (true)
            {
                try
                {
                    debitCadnum = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.CardNum == debitCadnum);
                    if (currentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Can't recognized This card.");
                    }
                }
                catch
                {
                    Console.WriteLine("Can't recognized This card.");

                }
            }
            Console.WriteLine("Please enter your pin: ");
            int userPin = 0;

            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.getPin() == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("incorrect pin ");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("incorrect pin ");
                }
            }
            Console.WriteLine("Welcome " + currentUser.getFirstName() + " :)");
            int option = 0;
            do
            {
                printOption();
                try
                {
                    option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                        deposit(currentUser);
                    }
                    else if (option == 2)
                    {
                        withdraw(currentUser);
                    }
                    else if (option == 3)
                    {
                        balance(currentUser);
                    }
                    else if (option == 4)
                    {
                        break;
                    }
                    else option = 0;
                }
                catch
                {

                }
            }
            while (option != 4);
            Console.WriteLine("Have a nice day :)");
          
        }

        public static void balance(Cardholder currentUser)
        {
            Console.WriteLine("Current balance: " + currentUser.getBalance());
        }

        private static void withdraw(Cardholder currentUser)
        {
            Console.WriteLine("how Much $$ would you like to withdraw: ");
            double withdrwal = Double.Parse(Console.ReadLine());
            if (currentUser.getBalance() > withdrwal)
            {
                Console.WriteLine("insufficient balance :(");
            }
            else
            {

                currentUser.setBalance(currentUser.getBalance() - withdrwal);
                Console.WriteLine("U can go Now");
            }
        }

        public static void deposit(Cardholder currentUser)
        {
            Console.WriteLine("How much $$ would you like to deposit ");
            double deposit1 = Double.Parse(Console.ReadLine());
            currentUser.setBalance(currentUser.getBalance() + deposit1);
            Console.WriteLine("Thank you for your $$. Your new Balance is:" + currentUser.getBalance());

        }

        private static void printOption()
        {
            Console.WriteLine("Please choose from one of the following options.....");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }


    }
}

