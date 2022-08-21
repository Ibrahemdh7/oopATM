using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPFree
{
    internal class Cardholder
    {

        public string CardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;
        public Cardholder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            CardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string getNum()
        {
            return CardNum;
        }
        public int getPin()
        {
            return pin;
        }


        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setNum(string newCardNum)
        {
            this.CardNum = newCardNum;
        }

        public void setPin(int newPin)
        {
            this.pin = newPin;
        }

        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

     

    }
}
