using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace DesignPatternsCSharp.Behavioral
{


    abstract class Account
    {
        protected Account successor;
        protected decimal Balance;

        public void setNext(Account account) => successor = account;
        public void pay(decimal amountToPay)
        {
            if (canPay(amountToPay))
                Console.WriteLine(amountToPay);
            else if (successor != null)
            {
                Console.WriteLine(amountToPay);
                successor.pay(amountToPay);
            }
            else
                throw new Exception("None of the accounts have enough balance");

        }
        public bool canPay(decimal amount) => Balance >= amount;

    }

    class Bank : Account
    {
        public Bank(decimal _balance)
        {
            Balance = _balance;
        }

    }

    class Paypal : Account
    {

        public Paypal(decimal _balance)
        {
            Balance = _balance;
        }
    }

    class Bitcoin : Account
    {
        public Bitcoin(decimal _balance)
        {
            Balance = _balance;
        }
    }

    class Chain_of_Responsibility
    {

        ///  Now let's prepare the chain using the links defined above (i.e. Bank, Paypal, Bitcoin)

        // Let's prepare a chain like below
        //      $bank->$paypal->$bitcoin
        //
        //       First priority bank
        //      If bank can't pay then paypal
        //      If paypal can't pay then bit coin



        /*
                static void Main(string[] args)
                {
                    Bank bank = new Bank(100);          // Bank with balance 100
                    Paypal paypal = new Paypal(200);      // Paypal with balance 200
                    Bitcoin bitcoin = new Bitcoin(300);    // Bitcoin with balance 300

                    bank.setNext(paypal);
                    paypal.setNext(bitcoin);

                    // Let's try to pay using the first priority i.e. bank
                   bank.pay(259);

                    // Output will be
                    // ==============
                    // Cannot pay using bank. Proceeding ..
                    // Cannot pay using paypal. Proceeding ..:
                    // Paid 259 using Bitcoin!
                }

                 */
    }
}
