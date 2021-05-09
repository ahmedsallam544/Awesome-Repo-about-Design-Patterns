using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Creational
{

    /*
     *Real world example
       
       Imagine you are at Hardee's and you order a specific deal, lets say, "Big Hardee" and they hand it over to you without any questions; this is the example of simple factory. But there are cases when the creation logic might involve more steps. For example you want a customized Subway deal, you have several options in how your burger is made e.g what bread do you want? what types of sauces would you like? What cheese would you want? etc. In such cases builder pattern comes to the rescue.
       
       In plain words
       
       Allows you to create different flavors of an object while avoiding constructor pollution. Useful when there could be several flavors of an object. Or when there are a lot of steps involved in creation of an object.
       
       Wikipedia says
       
       The builder pattern is an object creation software design pattern with the intentions of finding a solution to the telescoping constructor anti-pattern.
     */

    //The sane alternative is to use the builder pattern.First of all we have our burger that we want to make

    class Burger
    {
        protected int Size;
        protected bool Cheese = false;
        protected bool Pepperoni = false;
        protected bool Lettuce = false;
        protected bool Tomato = false;

        public Burger(BurgerBuilder builder)
        {
            this.Size = builder.Size;
            this.Cheese = builder.Cheese;
            this.Pepperoni = builder.Pepperoni;
            this.Lettuce = builder.Lettuce;
            this.Tomato = builder.Tomato;
        }

    }

    //And then we have the builder
    class BurgerBuilder
    {
        public int Size;
        public bool Cheese = false;
        public bool Pepperoni = false;
        public bool Lettuce = false;
        public bool Tomato = false;

        public BurgerBuilder(int _size) => Size = _size;

        public BurgerBuilder AddPepperoni()
        {
            this.Pepperoni = true;
            return this;
        }

        public BurgerBuilder AddLettuce()
        {
            this.Lettuce = true;
            return this;
        }

        public BurgerBuilder AddCheese()
        {
            this.Cheese = true;
            return this;
        }

        public BurgerBuilder AddTomato()
        {
            this.Tomato = true;
            return this;
        }

        public Burger Build() => new Burger(this);
    }

    class Builder
    {
        //static void Main(string[] args)
        //{
        //    Burger burger = (new BurgerBuilder(14)
        //         .AddPepperoni()
        //         .AddLettuce()
        //         .AddTomato()
        //         .Build());
        //}
        /*
          When to use?
           
           When there could be several flavors of an object and to avoid the constructor telescoping. 
           The key difference from the factory pattern is that; 
           factory pattern is to be used when the creation is a one step process while builder pattern is to be used 
           when the creation is a multi step process.
         */
    }
}
