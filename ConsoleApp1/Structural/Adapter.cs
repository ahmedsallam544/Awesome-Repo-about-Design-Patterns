using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Structural
{

    /*
        Real world example

        Consider that you have some pictures in your memory card and you need to transfer them to your computer. 
        In order to transfer them you need some kind of adapter that is 
        compatible with your computer ports so that you can attach memory card to your computer. In this case card reader is an adapter. Another example would be the famous power adapter; a three legged plug can't be connected to a two pronged outlet, it needs to use a power adapter that makes it compatible with the two pronged outlet. Yet another example would be a translator translating words spoken by one person to another

        In plain words

        Adapter pattern lets you wrap an otherwise incompatible 
        object in an adapter to make it compatible with another class.

        Wikipedia says

        In software engineering, the adapter pattern is a software design pattern that allows 
        the interface of an existing class to be used as another interface. 
        It is often used to make existing classes work with others without modifying their source code.
     */

    //Consider a game where there is a hunter and he hunts lions.
    //First we have an interface Lion that all types of lions have to implement

    interface Lion
    {
        void roar();
    }

    class AfricanLion : Lion
    {
        public void roar() => Console.WriteLine(" African Lion roarrrr"); 
    }

    class AsianLion : Lion
    {
        public void roar() => Console.WriteLine(" Asian Lion roarrrr");

    }

    // And hunter expects any implementation of Lion interface to hunt.
    class Hunter
    {
        public void hunt(Lion lion) => lion.roar(); 
    }
    // This needs to be added to the game
    class WildDog
    {
        public void bark()
        {
        }
    }

    // Adapter around wild dog to make it compatible with our game
    class WildDogAdapter : Lion
    {
        protected WildDog dog;

        public WildDogAdapter(WildDog dog) => this.dog = dog; 
        public void roar() => this.dog.bark(); 
    }
    class Adapter
    {
        //static void Main(string[] args)
        //{
        //    //And now the WildDog can be used in our game using WildDogAdapter.

        //    WildDog wildDog = new WildDog();
        //    WildDogAdapter wildDogAdapter = new WildDogAdapter(wildDog);
        //    Hunter hunter = new Hunter();
        //    hunter.hunt(wildDogAdapter);
        //}
    }
}
