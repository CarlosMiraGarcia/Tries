using System;

namespace Tries {
    class Program {
        static void Main(string[] args) {
            // This will help when we have a contact list and they ask us
            // how many of the contacts start with certain characters ('c' or 'ca', for example)
            Node newTries = new Node();
            newTries.Add("Carlos");
            newTries.Add("Anna");
            newTries.Add("Hanna");
            newTries.Add("Brona");
            newTries.Add("Bruno");
            newTries.Add("Bronislava");
            newTries.Add("Baron");
            // FindCount will find how many strings start with "Br". 0 is the
            // index where to start looking for.
            Console.WriteLine(newTries.FindCount("Br", 0));
            Console.ReadLine();
        }
    }
}
