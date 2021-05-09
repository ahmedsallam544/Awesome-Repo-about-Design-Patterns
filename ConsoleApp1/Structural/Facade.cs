using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Structural
{
    /*
      Real world example
       
       How do you turn on the computer? "Hit the power button" you say! 
       That is what you believe because you are using a simple interface that computer provides on the outside, 
       internally it has to do a lot of stuff to make it happen. This simple interface to 
       the complex subsystem is a facade.
       
       In plain words
       Facade pattern provides a simplified interface to a complex subsystem.
       
       Wikipedia says
       A facade is an object that provides a simplified interface to a larger body of code, such as a class library.
     */

   public class Computer
    {
        public void GetElectricShock() => Console.WriteLine("Ouch!");
        public void MakeSound() => Console.WriteLine("Beep beep!");
        public void ShowLoadingScreen() => Console.WriteLine("Loading..");
        public void Bam() => Console.WriteLine("Ready to be used!");
        public void CloseEverything() => Console.WriteLine("Bup bup bup buzzzz!");
        public void Sooth() => Console.WriteLine("Zzzzz");
        public void PullCurrent() => Console.WriteLine("Haaah!");
    }
    //Here we have ### the facade

    public class ComputerFacade
    {
        protected Computer computer;

        public ComputerFacade(Computer computer) => this.computer = computer;

        public void TurnOn()
        {
            this.computer.GetElectricShock();
            this.computer.MakeSound();
            this.computer.ShowLoadingScreen();
            this.computer.Bam();
        }

        public void TurnOff()
        {
            this.computer.CloseEverything();
            this.computer.PullCurrent();
            this.computer.Sooth();
        }
    }

    public class Facade
    {
        //public static void Main(string[] args)
        //{
        //               //Now to use the facade
        //    ComputerFacade computer = new ComputerFacade(new Computer());
        //    computer.TurnOn(); // Ouch! Beep beep! Loading.. Ready to be used!
        //    computer.TurnOff(); // Bup bup buzzz! Haah! Zzzzz
        //}
    }
}
