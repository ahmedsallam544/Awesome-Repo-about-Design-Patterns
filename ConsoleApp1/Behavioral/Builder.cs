using System;
using System.Collections.Generic;
using System.Text;

namespace GUID.DesignPatterns
{

    /*
     * Suppose we are getting some house built. The steps for building might look like

        Prepare the base of house
        Build the walls
        Add roof
        Add other floors
        The order of these steps could never be changed i.e. you can't build the roof before 
        building the walls etc but each of the steps could be modified for example walls can be made of wood or polyester or stone.

        In plain words
        Template method defines the skeleton of how a certain algorithm could be performed, 
        but defers the implementation of those steps to the children classes.

        Wikipedia says

        In software engineering, the template method pattern is a behavioral design pattern that defines the program skeleton 
        of an algorithm in an operation, deferring some steps to subclasses. 
        It lets one redefine certain steps of an algorithm without changing the algorithm's structure.
     */

    //Imagine we have a build tool that helps us test, lint, build, generate build reports(i.e.code coverage reports, linting report etc)
    //and deploy our app on the test server.
    //First of all we have our base class that specifies the skeleton for the build algorithm

    abstract class Builder
    {

        // Template method
        public void build()
        {
            this.test();
            this.lint();
            this.assemble();
            this.deploy();
        }

        abstract public void test();
        abstract public void lint();
        abstract public void assemble();
        abstract public void deploy();
    }


    // Then we can have our implementations

    class AndroidBuilder : Builder
    {

        public override void assemble() => Console.WriteLine("Assembling the android build");
        public override void deploy() => Console.WriteLine("Deploying android build to server");
        public override void lint() => Console.WriteLine("Linting the android code");
        public override void test() => Console.WriteLine("Running android tests");
    }

    class IosBuilder : Builder
    {
        public override void test() => Console.WriteLine("Running ios tests");
        public override void lint() => Console.WriteLine("Linting the ios code");
        public override void assemble() => Console.WriteLine("Assembling the ios build");
        public override void deploy() => Console.WriteLine("Deploying ios build to server");
    }
    class Template_Method
    {

        //static void Main(string[] args)
        //{

        //    AndroidBuilder androidBuilder = new AndroidBuilder();
        //    androidBuilder.build();

        //    // Output:
        //    // Running android tests
        //    // Linting the android code
        //    // Assembling the android build
        //    // Deploying android build to server

        //    IosBuilder iosBuilder = new IosBuilder();
        //    iosBuilder.build();

        //    // Output:
        //    // Running ios tests
        //    // Linting the ios code
        //    // Assembling the ios build
        //    // Deploying ios build to server
        //}
    }
}