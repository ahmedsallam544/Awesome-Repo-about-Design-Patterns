using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Behavioral
{


    /*
     *Take the example of calculator (i.e. originator), where whenever you perform some calculation the last calculation
     * is saved in memory (i.e. memento) so that you can get back to it and maybe get it restored using some action buttons (i.e. caretaker).
     *
     * In plain words
     Memento pattern is about capturing and storing the current state of an object in a manner that it can be restored later on in a smooth manner.
     The memento pattern is a software design pattern that provides the ability to restore an object to its previous state (undo via rollback).
    
    */
    //Lets take an example of text editor which keeps saving the state from time to time and that you can restore if you want
    //memento
    class EditorMemento
    {
        protected string content;

        public EditorMemento(string content) => this.content = content;
        public string getContent() => this.content;
    }
    //Then we have our editor i.e. originator that is going to use memento object
    class Editor
    {
        protected string content = "";

        public void type(string words) => this.content = this.content + words;
        public string getContent() => this.content;
        public EditorMemento save() => new EditorMemento(this.content);
        public void restore(EditorMemento memento) => this.content = memento.getContent();

    }
    class Memento
    {
        //static void Main(string[] args)
        //{

        //    Editor editor = new Editor();

        //   // Type some stuff
        //     editor.type("This is the first sentence. \r\n");
        //     editor.type("This is second.\r\n");

        //    // Save the state to restore to : This is the first sentence. This is second.
        //    var saved =  editor.save();
        //     // Type some more
        //     editor.type("And this is third.\r\n");

        //    // Output: Content before Saving
        //    Console.WriteLine(editor.getContent()); // This is the first sentence. This is second. And this is third.
        //    // Restoring to last saved state
        //    editor.restore(saved);
        //    Console.WriteLine(editor.getContent()); // This is the first sentence. This is second.
        //}
    }
}