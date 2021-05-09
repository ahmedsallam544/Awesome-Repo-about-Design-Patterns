﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Structural
{

    /*
     *Real world example
       
       Did you ever have fresh tea from some stall? They often make more than one cup 
       that you demanded and save the rest for any other customer so to save the resources e.g. gas etc. 
       Flyweight pattern is all about that i.e. sharing.
       
       In plain words
       
       It is used to minimize memory usage or computational expenses by sharing 
       as much as possible with similar objects.
       
       Wikipedia says
       
       In computer programming, flyweight is a software design pattern. 
       A flyweight is an object that minimizes memory use by sharing as much data as possible 
       with other similar objects; it is a way to use objects in large numbers when a simple repeated 
       representation would use an unacceptable amount of memory.
     */

    //Translating our tea example from above. First of all we have tea types and tea maker

    // Anything that will be cached is flyweight.
    // Types of tea here will be flyweights.
    class KarakTea
    {

    }

    // Acts as a factory and saves the tea
    class TeaMaker
    {
        protected List<string> availableTea = new List<string>();

        public string make(string preference)
        {
            if (!this.availableTea.Contains(preference))
                this.availableTea.Add(preference);

            return preference;
        }
    }
    //Then we have the TeaShop which takes orders and serves them
    class TeaShop
    {
        protected List<string> Orders = new List<string>();
        protected TeaMaker TeaMaker = new TeaMaker();

        public TeaShop(TeaMaker teaMaker) => this.TeaMaker = teaMaker;

        public void takeOrder(string teaType, int table) =>
             this.Orders.Add(TeaMaker.make(teaType) + table.ToString());

        public void serve()
        {
            foreach (var order in Orders)
                Console.WriteLine("Serving tea to table# " + order);
        }
    }
    class Flyweight
    {
        //public static void Main(string[] args)
        //{
        //    TeaMaker teaMaker = new TeaMaker();
        //    TeaShop shop = new TeaShop(teaMaker);
        //    shop.takeOrder("less sugar", 1);
        //    shop.takeOrder("more milk", 2);
        //    shop.takeOrder("without sugar", 5);
        //    shop.serve();
        //    // Serving tea to table# 1
        //    // Serving tea to table# 2
        //    // Serving tea to table# 5
        //}


    }
}
