using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Originator originator = new Originator();
            originator.SetState("Fridge door is open by amerina.");
            Console.WriteLine(originator.State);

            Caretaker careTaker = new Caretaker();
            careTaker.AddMemento(originator.SaveStateToMemento());

            originator.SetState("Elephant is in fridge.");
            careTaker.AddMemento(originator.SaveStateToMemento());
            Console.WriteLine(originator.State);


            originator.GetStateFromMemento(careTaker.GetMemento());
            Console.WriteLine(originator.State);

            originator.GetStateFromMemento(careTaker.GetMemento());
            Console.WriteLine(originator.State);
        }
    }
}
