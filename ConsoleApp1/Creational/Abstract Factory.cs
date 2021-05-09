using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Creational
{


    /*
     Real world example

        Extending our door example from Simple Factory. 
        Based on your needs you might get a wooden door from a wooden door shop, 
        iron door from an iron shop or a PVC door from the relevant shop. 
        Plus you might need a guy with different kind of specialities to fit the door, 
        for example a carpenter for wooden door, welder for iron door etc. 
        As you can see there is a dependency between the doors now, wooden door needs carpenter, iron door needs a welder etc.

        In plain words

        A factory of factories; a factory that groups the individual but related/dependent factories together without 
        specifying their concrete classes.

        Wikipedia says
        The abstract factory pattern provides a way to 
        encapsulate a group of individual factories that have a common theme without specifying their concrete classes

     */

    //Translating the door example above. First of all we have our Door interface and some implementation for it

    interface Door
    {
        void GetDescription();
    }

    class WoodenDoor : Door
    {
        public void GetDescription() => Console.WriteLine("I am a wooden door");
    }

    class IronDoor : Door
    {
        public void GetDescription() => Console.WriteLine("I am an iron door");
    }
    //Then we have some fitting experts for each door type

    interface DoorFittingExpert
    {
        void GetDescription();
    }
    class Welder : DoorFittingExpert
    {
        public void GetDescription() => Console.WriteLine("I can only fit iron doors");
    }
    class Carpenter : DoorFittingExpert
    {
        public void GetDescription() => Console.WriteLine("I can only fit wooden doors");
    }


    //Now we have our abstract factory that would let us make family of related objects
    //i.e.wooden door factory would create a wooden door and wooden door fitting expert and iron door factory would
    //create an iron door and iron door fitting expert

    interface DoorFactory
    {
        Door MakeDoor();
        DoorFittingExpert MakeFittingExpert();
    }

    // Wooden factory to return carpenter and wooden door
    class WoodenDoorFactory : DoorFactory
    {
        public Door MakeDoor() => new WoodenDoor();
        public DoorFittingExpert MakeFittingExpert() => new Carpenter();
    }

    // Iron door factory to get iron door and the relevant fitting expert
    class IronDoorFactory : DoorFactory
    {
        public Door MakeDoor() => new IronDoor();
        public DoorFittingExpert MakeFittingExpert() => new Welder();
    }

    class Abstract_Factory
    {

        static void Main(string[] args)
        {
            WoodenDoorFactory woodenFactory = new WoodenDoorFactory();

            Door door = woodenFactory.MakeDoor();
            DoorFittingExpert expert = woodenFactory.MakeFittingExpert();
            door.GetDescription();  // Output: I am a wooden door
            expert.GetDescription(); // Output: I can only fit wooden doors

            // Same for Iron Factory
            IronDoorFactory ironFactory = new IronDoorFactory();

            door = ironFactory.MakeDoor();
            expert = ironFactory.MakeFittingExpert();
            door.GetDescription();  // Output: I am an iron door
            expert.GetDescription(); // Output: I can only fit iron doors
        }
    }
}
