using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        int firstNumber = 0, secondNumber = 1, nextNumber;

        Console.WriteLine("Fibonacci Series:");
        for (int i = 1; i <= terms; ++i)
        {
            Console.Write(firstNumber + " ");
            nextNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = nextNumber;
        }
    }
}