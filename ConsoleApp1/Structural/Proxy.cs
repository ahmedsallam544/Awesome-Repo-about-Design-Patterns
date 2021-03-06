using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Structural
{
    /*
     *Real world example

        Have you ever used an access card to go through a door? There are multiple options to open that door i.e.
        it can be opened either using access card or by pressing a button that bypasses the security. 
        The door"s main functionality is to open but there is a proxy added on top of it to add some functionality. 
        Let me better explain it using the code example below.

        In plain words

        Using the proxy pattern, a class represents the functionality of another class.

        Wikipedia says

        A proxy, in its most general form, is a class functioning as an interface to something else.
        A proxy is a wrapper or agent object that is being called by the client to access 
        the real serving object behind 
        the scenes. Use of the proxy can simply be forwarding to the real object, or can provide additional logic. 
        In the proxy extra functionality can be provided, for example caching when operations on the real object 
        are resource intensive, or checking preconditions before operations on the real object are invoked.

*/

    //Taking our security door example from above. Firstly we have the door interface and an implementation of door

    interface Door
    {
        string Open();
        string Close();
    }

    class LabDoor : Door
    {
        public string Open() => "Opening lab door";
        public string Close() => "Closing the lab door";
    }

    //Then we have a proxy to secure any doors that we want
    class SecuredDoor
    {
        protected Door Door;

        public SecuredDoor(Door door) => this.Door = door;
        public bool Authenticate(string password) => password == "ecr@t";
        public void open(string password)
        {
            if (Authenticate(password))
                Console.WriteLine(this.Door.Open());
            else
                Console.WriteLine("Big no! It ain't possible.");
        }
        public void Close() => Console.WriteLine(this.Door.Close());
    }


    public class Proxy
    {
        //static void Main(string[] args)
        //{
        //    SecuredDoor door = new SecuredDoor(new LabDoor());
        //    door.open("invalid"); // Big no! It ain"t possible.
        //    door.open("ecr@t"); // Opening lab door
        //    door.Close(); // Closing lab door
        //}
    }
}
