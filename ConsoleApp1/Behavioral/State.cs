﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Behavioral
{

    /*
       @Real world example
        Imagine you are using some drawing application, you choose the paint brush to draw. Now the brush changes its behavior based on the selected color i.e. 
        if you have chosen red color it will draw in red, if blue then it will be in blue etc.
        @In plain words
        ### It lets you change the behavior of a class when the state changes.

       @ Wikipedia says

        The state pattern is a behavioral software design pattern that implements a state machine in an object-oriented way. 
        With the state pattern, a state machine is implemented by implementing each individual state 
        as a derived class of the state pattern interface, and implementing state transitions by invoking methods defined by the pattern's superclass. 
        The state pattern can be interpreted as a strategy pattern which is able to switch the current strategy through invocations of methods defined 
        in the pattern's interface.
    */


    //Let's take an example of text editor,
    //it lets you change the state of text that is typed i.e. if you have selected bold,
    //it starts writing in bold, if italic then in italics etc.

    interface WritingState
    {
        void write(string words);
    }

    class UpperCase : WritingState
    {
        public void write(string words) => Console.WriteLine(words.ToUpper());

    }

    class LowerCase : WritingState
    {
        public void write(string words) => Console.WriteLine(words.ToLower());

    }

    class DefaultText : WritingState
    {
        public void write(string words) => Console.WriteLine(words);

    }

    // Then we have our editor

    class TextEditor
    {
        protected WritingState state;

        public TextEditor(WritingState state) => this.state = state;
        public void setState(WritingState state) => this.state = state;
        public void type(string words) => this.state.write(words);
    }
    class State
    {
        //static void Main(string[] args)
        //{
        //    TextEditor editor = new TextEditor(new DefaultText());

        //         editor.type("First line");

        //         editor.setState(new UpperCase());

        //         editor.type("Second line");
        //         editor.type("Third line");

        //         editor.setState(new LowerCase());

        //         editor.type("Fourth line");
        //         editor.type("Fifth line");

        //    // Output:
        //    //First line
        //    //SECOND LINE
        //    //THIRD LINE
        //    //fourth line
        //    //fifth line

        //}
    }
}