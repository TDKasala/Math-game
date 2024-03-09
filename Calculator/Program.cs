using System;

class Calculator
{
    static void Main(string[] args)
    {
        double num1, num2;
        char operation;

        Console.WriteLine("Simple Calculator in C#");
        Console.WriteLine("------------------------");

        Console.Write("Enter first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operation (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Error! Division by zero is not allowed.");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operation entered.");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}
