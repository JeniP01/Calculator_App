using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-----------------");

        while (true)
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice (1, 2, or 3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformAddition();
                    break;
                case "2":
                    PerformSubtraction();
                    break;
                case "3":
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void PerformAddition()
    {
        Console.WriteLine("\nAddition");
        Console.Write("Enter the first number: ");
        double num1 = GetNumberFromUser();

        Console.Write("Enter the second number: ");
        double num2 = GetNumberFromUser();

        double result = num1 + num2;
        Console.WriteLine($"Result: {num1} + {num2} = {result}");
    }

    static void PerformSubtraction()
    {
        Console.WriteLine("\nSubtraction");
        Console.Write("Enter the first number: ");
        double num1 = GetNumberFromUser();

        Console.Write("Enter the second number: ");
        double num2 = GetNumberFromUser();

        double result = num1 - num2;
        Console.WriteLine($"Result: {num1} - {num2} = {result}");
    }

    static double GetNumberFromUser()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Try again: ");
        }
        return number;
    }
}