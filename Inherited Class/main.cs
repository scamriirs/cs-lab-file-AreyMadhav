using System;

public class Animal
{
    public void Character()
    {
        Console.WriteLine("Animal Spawn");
    }
}

public class Cat : Animal
{
    public void EatFood()
    {
        Console.WriteLine("A Wild Cat Appeared!!!")
        Console.WriteLine("Eats cat food");
    }
}

class Program
{
    static void Main()
    {
        Cat myCat = new Cat();
        myCat.Character();
        myCat.EatFood();
    }
}