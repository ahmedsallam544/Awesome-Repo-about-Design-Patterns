using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp
{
    /*
     A general example would be when you talk to someone on your mobile phone, 
     there is a network provider sitting between you and them and your conversation goes through it 
     instead of being directly sent. In this case network provider is mediator.
    وسيط 
    Mediator pattern adds a third party object (called mediator) 
    to control the interaction between two objects (called colleagues). 
    It helps reduce the coupling between the classes communicating with each other.
    Because now they don't need to have the knowledge of each other's implementation.
    */

    //Here is the simplest example of a chat room(i.e.mediator) with users(i.e.colleagues)
    // sending messages to each other

    interface ChatRoomMediator
    {
        void ShowMessage(User user, string message);
    }

    //Mediator
    class ChatRoom : ChatRoomMediator
    {
        public void ShowMessage(User user, string message)
        {
            var sender = user.GetName();
            Console.WriteLine(sender + DateTime.Now.Date.ToString()+ message);
        }
    }

    //Then we have our users i.e.colleagues

    class User
    {
        protected string name;
        private ChatRoomMediator chatMediator;
        protected ChatRoomMediator ChatMediator { get => chatMediator; set => chatMediator = value; }

        public User(string name, ChatRoomMediator chatMediator)
        {
            this.name = name;
            this.chatMediator = chatMediator;   
        }

        public string GetName() => this.name;
        public void Send(string message ) => ChatMediator.ShowMessage(this, message); 
    }
    class Mediator
    {

        //static void Main(string[] args)
        //{

        //    ChatRoom mediator = new ChatRoom();

        //      User john = new User("John Doe",  mediator);
        //      User jane = new User("Jane Doe",  mediator);

        //         john.Send("Hi there!");
        //         jane.Send("Hey!");

        //    // Output will be
        //    // Feb 14, 10:58 [John]: Hi there!
        //    // Feb 14, 10:58 [Jane]: Hey!
        //}
    }
}
