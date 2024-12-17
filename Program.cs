using System;

class Program {
    static double num1; 
    static double num2;

    static void Main() {
        
        GetUserInputs();

        
        Console.WriteLine("Select the operation from the list below:");
        Console.WriteLine("1. ADD");
        Console.WriteLine("2. SUBTRACT");
        Console.WriteLine("3. MULTIPLY");
        Console.WriteLine("4. DIVIDE");

       
        if (int.TryParse(Console.ReadLine(), out int choice)) {
            double result;

           
            switch (choice) {
                case 1:
                    result = Add();
                    Console.WriteLine($"Result: {result}");
                    break;
                case 2:
                    result = Subtract();
                    Console.WriteLine($"Result: {result}");
                    break;
                case 3:
                    result = Multiply();
                    Console.WriteLine($"Result: {result}");
                    break;
                case 4:
                    result = Divide();
                    if (!double.IsNaN(result)) 
                        Console.WriteLine($"Result: {result}");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please select a valid operation.");
                    break;
            }
        } else {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 4.");
        }

        Console.ReadKey(); 
    }

    static void GetUserInputs() {
        Console.Write("Enter the first number: ");
        while (!double.TryParse(Console.ReadLine(), out num1)) {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }

        Console.Write("Enter the second number: ");
        while (!double.TryParse(Console.ReadLine(), out num2)) {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }
    }

    static double Add() => num1 + num2;

    static double Subtract() => num1 - num2;

    static double Multiply() => num1 * num2;

    static double Divide() {
        if (num2 == 0) {
            Console.WriteLine("Error: Cannot divide by zero!");
            return double.NaN; 
        }
        return num1 / num2;
    }
}
