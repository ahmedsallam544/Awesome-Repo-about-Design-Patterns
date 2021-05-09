using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatternsCSharp.Behavioral
{

    /*
     * Real world example
       
       Consider someone visiting Dubai. They just need a way (i.e. visa) to enter Dubai. After arrival, 
       they can come and visit any place in Dubai on their own without having to ask for permission or to do some leg work 
       in order to visit any place here; just let them know of a place and they can visit it. Visitor pattern lets you do just that, 
       it helps you add places to visit so that they can visit as much as they can without having to do any legwork.
       
       In plain words
       
       Visitor pattern lets you add further operations to objects without having to modify them.
       
       Wikipedia says
       
       In object-oriented programming and software engineering, the visitor design pattern 
       is a way of separating an algorithm from an object structure on which it operates. 
       A practical result of this separation is the ability to add new operations to existing object structures 
       without modifying those structures. It is one way to follow the open/closed principle

     */

    //  Let's take an example of a zoo simulation where we have several different kinds of animals and we have to make them Sound.
    // Let's translate this using visitor pattern

    // Visitee
    interface Animal
    {
        void accept(AnimalOperation operation);
    }

    // Visitor
    interface AnimalOperation
    {
        void visitMonkey(Monkey monkey);
        void visitLion(Lion lion);
        void visitDolphin(Dolphin dolphin);
    }
    // Then we have our implementations for the animals
    class Monkey : Animal
    {
        public void shout() => Console.WriteLine("Ooh oo aa aa!");
        public void accept(AnimalOperation operation) => operation.visitMonkey(this);
    }

    class Lion : Animal
    {
        public void roar() => Console.WriteLine("Roaaar");
        public void accept(AnimalOperation operation) => operation.visitLion(this);
    }

    class Dolphin : Animal
    {
        public void speak() => Console.WriteLine("Tuut tuttu tuutt!");
        public void accept(AnimalOperation operation) => operation.visitDolphin(this);
    }

    //------------ Let's implement our visitor

    class Speak : AnimalOperation
    {
        public void visitMonkey(Monkey monkey) => monkey.shout();
        public void visitLion(Lion lion) => lion.roar();
        public void visitDolphin(Dolphin dolphin) => dolphin.speak();
    }

    class Jump : AnimalOperation
    {
        public void visitMonkey(Monkey monkey) => Console.WriteLine("Jumped 20 feet high! on to the tree!");
        public void visitLion(Lion lion) => Console.WriteLine("Jumped 7 feet! Back on the ground!");
        public void visitDolphin(Dolphin dolphin) => Console.WriteLine("Walked on water a little and disappeared");
    }
    class Visitor
    {
        //static void Main(string[] args)
        //{

        //    Monkey monkey = new Monkey();
        //    Lion lion = new Lion();
        //    Dolphin dolphin = new Dolphin();

        //    Speak speak = new Speak();
        //    monkey.accept(speak);    // Ooh oo aa aa!    
        //    lion.accept(speak);      // Roaaar!
        //    dolphin.accept(speak);   // Tuut tutt tuutt!


        //    Jump jump = new Jump();
        //    monkey.accept(speak);   // Ooh oo aa aa!
        //    monkey.accept(jump);    // Jumped 20 feet high! on to the tree!
        //    lion.accept(speak);     // Roaaar!
        //    lion.accept(jump);      // Jumped 7 feet! Back on the ground!
        //    dolphin.accept(speak);  // Tuut tutt tuutt!
        //    dolphin.accept(jump);   // Walked on water a little and disappeared



        //}
    }
}