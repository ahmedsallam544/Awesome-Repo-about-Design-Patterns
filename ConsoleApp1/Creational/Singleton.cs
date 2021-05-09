using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternsCSharp.Creational;

namespace DesignPatternsCSharp.Creational
{

    /*
         Real world example
        There can only be one president of a country at a time. .
        The same president has to be brought to action, whenever duty calls. President here is singleton.

        In plain words
        Ensures that only one object of a particular class is ever created.
     */

    //To create a singleton, make the constructor private, disable cloning,
    //disable extension and create a static variable to house the instance

    public class President
    {
        private static President instance;

        static President()
        {
            // Hide the constructor
        }
        public static President getInstance()
        {
            return instance ?? new President();
        }

    }


    class Singleton
    {
        //static void Main(string[] args)
        //{
        //    President president1 = President.getInstance();
        //    President president2 = President.getInstance();
        //    Console.WriteLine(president1 = president2); // true
        //}
    }
}


