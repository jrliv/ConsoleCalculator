using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Please enter the first number of the expression: ");
            double num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the operator (+, -, *, or /): ");
            string op = Console.ReadLine();

            Console.Write("Please enter the other number of the expression: ");
            double num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine();

            double result;

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine(num1.ToString() + " " + op + " " + num2.ToString() + " = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(num1.ToString() + " " + op + " " + num2.ToString() + " = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(num1.ToString() + " " + op + " " + num2.ToString() + " = " + result);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine(num1.ToString() + " " + op + " " + num2.ToString() + " = " + result);
                        break;
                    }
                default:
                    Console.WriteLine("Sorry you entered an incorrect operator.");
                    Console.WriteLine();
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine();

        Console.WriteLine("Would you like to calculate again? Enter Y for Yes and N for No.");
        string response = Console.ReadLine();

        if (response == "Y")
        {
            Main(args);
        }
        else if (response == "N")
        {
            Environment.Exit(0);
        }

        while (response != "Y" && response != "N")
        {
            Console.WriteLine();
            Console.WriteLine("Sorry you entered an incorrect response.");
            Console.WriteLine("Would you like to calculate again? Enter Y for Yes and N for No.");
            response = Console.ReadLine();
        }

        if (response == "Y")
        {
            Main(args);
        }
        else if (response == "N")
        {
            Environment.Exit(0);
        }
    }
}