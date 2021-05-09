using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Structural
{

    /*
            Real world example

            Imagine you run a car service shop offering multiple services. 
            Now how do you calculate the bill to be charged? You pick one service and dynamically keep 
            adding to it the prices for the provided services till you get the final cost. 
            Here each type of service is a decorator.

            In plain words

            Decorator pattern lets you dynamically change the behavior of an object at run time 
            by wrapping them in an object of a decorator class.

            Wikipedia says

            In object-oriented programming, the decorator pattern is a design pattern that allows behavior to be added to 
            an individual object, either statically or dynamically, without affecting 
            the behavior of other objects from the same class. 
            The decorator pattern is often useful for adhering to the Single Responsibility Principle, 
            as it allows functionality to be divided between classes with unique areas of concern.
     */

    //Lets take coffee for example. First of all we have a simple coffee implementing the coffee interface

    interface Coffee
    {
        decimal getCost();
        string getDescription();
    }

    class SimpleCoffee : Coffee
    {
        public decimal getCost() => 10;
        public string getDescription() => "Simple coffee";
    }

    // We want to make the code extensible to allow options to modify it if required.Lets make some add-ons(decorators)

    class MilkCoffee : Coffee
    {
        protected Coffee coffee;

        public MilkCoffee(Coffee coffee) => this.coffee = coffee;

        public decimal getCost() => this.coffee.getCost() + 2;
        public string getDescription() => this.coffee.getDescription() + " milk ";
    }
    class WhipCoffee : Coffee
    {
        protected Coffee coffee;

        public WhipCoffee(Coffee coffee) => this.coffee = coffee;
        public decimal getCost() => this.coffee.getCost() + 5;
        public string getDescription() => this.coffee.getDescription() + " whip";
    }
    class VanillaCoffee : Coffee
    {
        protected Coffee coffee;

        public VanillaCoffee(Coffee coffee) => this.coffee = coffee;

        public decimal getCost() => this.coffee.getCost() + 3;
        public string getDescription() => this.coffee.getDescription() + " vanilla ";
    }
    class Decorator
    {
        //public static void Main(string[] args)
        //{
        //    // Lets make a coffee now

        //    SimpleCoffee someCoffee = new SimpleCoffee();
        //    Console.WriteLine(someCoffee.getCost()); // 10
        //    Console.WriteLine(someCoffee.getDescription()); // Simple Coffee

        //    MilkCoffee MilkCoffee = new MilkCoffee(someCoffee);
        //    Console.WriteLine(MilkCoffee.getCost()); // 12
        //    Console.WriteLine(MilkCoffee.getDescription());// Simple Coffee, milk

        //    WhipCoffee WhipCoffee = new WhipCoffee(MilkCoffee);
        //    Console.WriteLine(WhipCoffee.getCost()); // 17
        //    Console.WriteLine(WhipCoffee.getDescription()); // Simple Coffee, milk, whip

        //    VanillaCoffee VanillaCoffee = new VanillaCoffee(WhipCoffee);
        //    Console.WriteLine(VanillaCoffee.getCost());// 20
        //    Console.WriteLine(VanillaCoffee.getDescription()); // Simple Coffee, milk, whip, vanilla
        //}

    }
}
