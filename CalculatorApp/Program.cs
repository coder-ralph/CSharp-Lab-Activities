using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");
            Console.WriteLine("Available Operations:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1/2/3/4/5): ");
            string choice = Console.ReadLine();

            if (choice == "5")
            {
                Console.WriteLine("Exiting the calculator.");
                break;
            }

            if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
            {
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                continue;
            }

            Console.Write("Enter the first number: ");
            double num1;
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            Console.Write("Enter the second number: ");
            double num2;
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            double result = 0;
            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    break;
                case "2":
                    result = num1 - num2;
                    break;
                case "3":
                    result = num1 * num2;
                    break;
                case "4":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        continue;
                    }
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine($"Result: {num1} {GetOperationSymbol(choice)} {num2} = {result}");
        }
    }

    static string GetOperationSymbol(string choice)
    {
        switch (choice)
        {
            case "1":
                return "+";
            case "2":
                return "-";
            case "3":
                return "*";
            case "4":
                return "/";
            default:
                return "";
        }
    }
}
