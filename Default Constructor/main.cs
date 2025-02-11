using System;

public class Person
{
    public string Name;
    public int Age;
    public Person()
    {
        Name = "PlayerUnknownBattleGround";
        Age = 0;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person();
        
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}
