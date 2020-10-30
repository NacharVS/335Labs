using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Shagaviev_Barygin
abstract class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public abstract void Display();
}

class Client : Person
{
    public int Sum { get; set; }    // сумма на счету

    public Client(string name, int sum)
        : base(name)
    {
        Sum = sum;
    }
    public override void Display()
    {
        Console.WriteLine($"{Name} имеет счет на сумму {Sum}");
    }
}

class Employee : Person
{
    public string Position { get; set; } // должность

    public Employee(string name, string position)
        : base(name)
    {
        Position = position;
    }

    public override void Display()
    {
        Console.WriteLine($"{Position} {Name}");
    }