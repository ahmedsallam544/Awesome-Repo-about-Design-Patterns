using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Structural
{
    /*
     * Real world example

        Consider you have a website with different pages and you are supposed to 
        allow the user to change the theme. What would you do? Create multiple copies of each of the pages 
        for each of the themes or would you just create separate theme and load them based on the user's preferences?
        Bridge pattern allows you to do the second i.e.

        In Plain Words

        Bridge pattern is about preferring composition over inheritance. 
        Implementation details are pushed from a hierarchy to another object with a separate hierarchy.

        Wikipedia says

        The bridge pattern is a design pattern used in software engineering 
        that is meant to "decouple an abstraction from its implementation so that the two can vary independently"
     */

    interface WebPage
    {
        string getContent();
    }

    class About : WebPage
    {
        protected Theme theme;

        public About(Theme theme) => this.theme = theme; 
        public string getContent() => " About page in " + this.theme.getColor();
    }
    class Careers : WebPage
    {
        protected Theme theme;

        public Careers(Theme theme) => this.theme = theme;
        public string getContent() => "Careers page in " + this.theme.getColor();
    }
    
    //And the separate theme hierarchy
    interface Theme
    {
        string getColor();
    }

    class DarkTheme : Theme
    {
        public string getColor() => "Dark Black";
    }
    class LightTheme : Theme
    {
        public string getColor() => "Off white";

    }
    class AquaTheme : Theme
    {
        public string getColor() => "Light blue";
    }
    class Bridge
    {

        //static void Main(string[] args)
        //{
        //    DarkTheme darkTheme = new DarkTheme();
        //    About about = new About(darkTheme);
        //    Careers careers = new Careers(darkTheme);

        //    Console.WriteLine(about.getContent());// "About page in Dark Black";
        //    Console.WriteLine(careers.getContent()); // "Careers page in Dark Black";
        //}
    }
}
