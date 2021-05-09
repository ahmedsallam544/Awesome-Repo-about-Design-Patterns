using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Behavioral
{

    /*
     Allows you to encapsulate actions in objects.
     The key idea behind this pattern is to provide the means to decouple client from receiver.
     */
    //First of all we have the receiver that has the implementation of every action that could be performed
    // Receiver
    class Bulb
    {
        public void turnOn()
        {
            Console.WriteLine("Bulb has been lit");
        }
        public void turnOff()
        {
            Console.WriteLine("Darkness!");
        }

    }
    interface Command
    {
        void execute();
        void undo();
        void redo();
    }

    // Command
    class TurnOn : Command
    {
        protected Bulb Bulb;

        public TurnOn(Bulb bulb) => Bulb = bulb;
        public void execute() => this.Bulb.turnOn();
        public void undo() => this.Bulb.turnOff();
        public void redo() => this.execute();
    }
    class TurnOff : Command
    {
        protected Bulb Bulb;
        public TurnOff(Bulb bulb) => Bulb = bulb;

        public void execute() => this.Bulb.turnOff();
        public void undo() => this.Bulb.turnOn();
        public void redo() => this.execute();
    }

    // Then we have an Invoker with whom the client will interact to process any commands
    // Invoker
    class RemoteControl
    {
        public void submit(Command command) => command.execute();
    }
    class Commandd
    {
        //static void Main(string[] args)
        //{
        //    // Reciver
        //    Bulb bulb = new Bulb();
        //    // Commands
        //    TurnOn turnOn = new TurnOn(bulb);
        //    TurnOff turnOff = new TurnOff(bulb);
        //    // Invoker
        //    RemoteControl remote = new RemoteControl();
        //    remote.submit(turnOn); // Bulb has been lit!
        //    remote.submit(turnOff); // Darkness!
        //}
    }
}
