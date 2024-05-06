using System;

 internal class Program
{
    static double Addition(double NUM1, double NUM2)
    {
        return NUM1 + NUM2;
    }

    static double Subtraction(double NUM1, double NUM2)
    {
        return NUM1 - NUM2;
    }

    static double Multiplication(double NUM1, double NUM2)
    {
        return NUM1 * NUM2;
    }

    static double Division(double NUM1, double NUM2)
    {
        if (NUM2 == 0)
        {
            Console.WriteLine("Error! Division by zero.");
            return 0;
        }
        else
        {
            return NUM1 / NUM2;
        }
    }

    static void Main(string[] args)
    {  //Inputing the First two numbers
        Console.Write("Enter the first number: ");
        double NUM1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double NUM2 = Convert.ToDouble(Console.ReadLine());

        while (true)
        {    //Operations to be selected
            Console.WriteLine("\nSELECT DESIRE OPERATION:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter choice (+ , - , * , /): "); //Symbols
            string choice = Console.ReadLine();

            if (choice == "+")
            {
                Console.WriteLine("Result: " + Addition(NUM1, NUM2));
                break;
            }
            else if (choice == "-")
            {
                Console.WriteLine("Result: " + Subtraction(NUM1, NUM2));
                break;
            }
            else if (choice == "*")
            {
                Console.WriteLine("Result: " + Multiplication(NUM1, NUM2));
                break;
            }
            else if (choice == "/")
            {
                Console.WriteLine("Result: " + Division(NUM1, NUM2));
                break;
            }
            else
            {
                Console.WriteLine("Invalid input! Please try again.");
            }
        }
    }
}
