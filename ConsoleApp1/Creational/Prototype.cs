using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Creational
{

    /*
             Real world example

        Remember dolly? The sheep that was cloned! Lets not get into the details 
        but the key point here is that it is all about cloning

        In plain words

        Create object based on an existing object through cloning.

        Wikipedia says

        The prototype pattern is a creational design pattern in software development. 
        It is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects.

        In short, it allows you to create a copy of an existing object and modify it to your needs, 
        instead of going through the trouble of creating an object from scratch and setting it up.
     */

    //When to use?
    // When an object is required that is similar to existing object or when the creation would be expensive
    // as compared to cloning.
    class Sheep : ICloneable
    {
        protected string name;
        protected string category;

        public Sheep(string name, string category = "Mountain Sheep")
        {
            this.name = name;
            this.category = category;
        }

        public void SetName(string name) => this.name = name;
        public string GetName() => this.name;
        public void SetCategory(string category) => this.category = category;
        public string getCategory() => this.category;
        public object Clone() => new Sheep(this.name, this.category);
    }
    class Prototype
    {
        //static void Main(string[] args)
        //{
        //    //Then it can be cloned like below

        //    Sheep original = new Sheep("Jolly");
        //    Console.WriteLine(original.GetName()); // Jolly
        //    Console.WriteLine(original.getCategory()); // Mountain Sheep

        //    // Clone and modify what is required
        //    Sheep cloned = (Sheep)original.Clone();
        //    cloned.SetName("Dolly");
        //    Console.WriteLine(cloned.GetName()); // Dolly
        //    Console.WriteLine(cloned.getCategory()); // Mountain sheep
        //}
        
        /*
        When to use?
        When an object is required that is similar to existing object or when the creation would be expensive
        as compared to cloning.
        */
    }
}
