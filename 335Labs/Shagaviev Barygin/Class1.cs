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

    public void Display()
    {
        Console.WriteLine(Name);
    }
}

public class Client : Person
{
    public int Sum { get; set; }   

    public Client(string name, int sum)
        : base(name)
    {
        Sum = sum;
    }
}

class Employee : Person
{
    public string Position { get; set; } 

    public Employee(string name, string position)
        : base(name)
    {
        Position = position;
    }
}
