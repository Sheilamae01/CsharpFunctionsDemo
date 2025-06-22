
using System;

namespace CSharpFunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Function Demo ===");
            GreetUser("Sheila");
            int result = AddNumbers(10, 20);
            Console.WriteLine($"The result of addition is: {result}");
        }

        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}! Welcome to C# functions.");
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}