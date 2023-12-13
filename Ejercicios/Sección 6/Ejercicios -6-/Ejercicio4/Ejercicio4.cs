namespace Ejercicio4;
using System;
using System.Text;

internal class Ejercicio4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi! enter 4 numbers plz!");
        Numbers();
    }

    public static void Numbers()
    {
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = Convert.ToInt32(Console.ReadLine());
        int number4 = Convert.ToInt32(Console.ReadLine());

        StringBuilder sb = new StringBuilder($"\nEl primer numero introducido es el {number1} , despues han introducido el {number2} y {number3} y por ultimo el {number4}");
        Console.WriteLine(sb);
    }
}

//VERSION GEPETO

/*
  internal class Ejercicio4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi! Enter 4 numbers, separated by spaces:");
        Numbers();
    }

    public static void Numbers()
    {
        string input = Console.ReadLine();
        string[] numberStrings = input.Split(' ');

        if (numberStrings.Length != 4)
        {
            Console.WriteLine("Please enter exactly 4 numbers separated by spaces.");
            return;
        }

        int number1 = Convert.ToInt32(numberStrings[0]);
        int number2 = Convert.ToInt32(numberStrings[1]);
        int number3 = Convert.ToInt32(numberStrings[2]);
        int number4 = Convert.ToInt32(numberStrings[3]);

        StringBuilder sb = new StringBuilder($"El primer numero introducido es el {number1}, después han introducido el {number2} y {number3} y por último el {number4}");
        Console.WriteLine(sb);
    }
}
*/