using System.Security;

namespace Ejercicio2;

internal class Ejercicio2
{
    static void Main(string[] args)
    {
        var option = Menu();

        while (option != "5")
        {
            SwitchOption(option);
            option = Menu();
        }
    }

    public static string Menu()
    {
        Console.WriteLine("\n\t\t\t----Menu----\n");
        Console.WriteLine("1. Sum\n");
        Console.WriteLine("2. Substract\n");
        Console.WriteLine("3. Multiplication\n");
        Console.WriteLine("4. Division\n");
        Console.WriteLine("5. Exit\n");
        return Console.ReadLine();
    }

    public static void SwitchOption(string option)
    {
        switch (option)
        {
            case "1": Sum();
                break;
            case "2": Substract();
                break;
            case "3": Mult();
                break;
            case "4": Divide();
                break;
            case "5"://EXIT
                break;
        }
    }

    
    
    public static void Sum()
    {
        double result;
        Console.WriteLine("\nChoose 2 numbers to operate\n");
        Console.WriteLine("\n1st Number:\n");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n2nd Number:\n");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nThe result of {num1} + {num2} = " + (result = num1 + num2));
    }
    public static void Substract()
    {
        double result;
        Console.WriteLine("\nChoose 2 numbers to operate\n");
        Console.WriteLine("\n1st Number:\n");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n2nd Number:\n");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nThe result of {num1} - {num2} = " + (result = num1 - num2));
    } 
    public static void Mult()
    {
        double result;
        Console.WriteLine("\nChoose 2 numbers to operate\n");
        Console.WriteLine("\n1st Number:\n");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n2nd Number:\n");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nThe result of {num1} * {num2} = " + (result = num1 * num2));
    }
    public static void Divide()
    {
        double result;
        Console.WriteLine("\nChoose 2 numbers to operate\n");
        Console.WriteLine("\n1st Number:\n");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n2nd Number:\n");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nThe result of {num1} / {num2} = " + (result = num1 / num2));
    }
}