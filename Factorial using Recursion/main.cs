using System;

class Program
{
    static void Main()
    {
        int number = 5; // You can change this value to test with other numbers
        Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
    }

    static int Factorial(int n)
    {
        // Base case: if n is 0 or 1, return 1
        if (n <= 1)
        {
            return 1;
        }
        // Recursive case: n * Factorial(n - 1)
        return n * Factorial(n - 1);
    }
}