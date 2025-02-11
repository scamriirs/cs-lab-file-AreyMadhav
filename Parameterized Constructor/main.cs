using System;

public class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("PUBG", 10);

        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}