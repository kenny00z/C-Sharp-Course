using System;
using System.ComponentModel.Design;

namespace Ejercicio6;

internal class Ejercicio6
{
    static void Main(string[] args)
    {
        Mamafunction();
    }

    //intentar funcion que EJECUTE TODO PARA SER LLAMADA EN EL MAIN(implementacion a futuro)
    public static void Mamafunction()
    {
        Console.WriteLine("Enter numbers until you press 0\n");
        int num;
        var numsStorage = new List<int>();
        num = Convert.ToInt32(Console.ReadLine());

        while (num != 0)
        {
            StorageNums(num, numsStorage);
            num = Convert.ToInt32(Console.ReadLine());
        }
        if (num == 0)
        {
            SubstractLowerToHigher(GetHigherAndLower(numsStorage));
            CounterNums(numsStorage);
        }
    }
    //funcion storager 
    public static List<int> StorageNums(int num , List<int> numsStorage)
    {   
        numsStorage.Add(num); 
        return numsStorage;
    }
    //funcion que checkea el num mas alto y el mas bbajo
    public static int[] GetHigherAndLower(List<int> numsStorage) 
    {  
        var sortedList = numsStorage.OrderByDescending(x => x).ToList();
        int[]arrayNums =  sortedList.ToArray();
        int higher = (arrayNums[0]); 
        int lower = (arrayNums[arrayNums.Length - 1]);
       
        Console.WriteLine($"\n{higher}  is the higher num u entered\n");
        Console.WriteLine($"\n{lower}  is the lower num u entered\n");

        return arrayNums;

    }
    //funcion resta entre el alto y el bajo
    public static void SubstractLowerToHigher(int[] arrayNums)
    {
        int higher = arrayNums[0];
        int lower = arrayNums[arrayNums.Length - 1];
        int result = higher - lower;

        Console.WriteLine($"\nThe Substract of lower to higher number is = {result}\n");
    }
    //funcion que cuenta la cantidad de nums introducidos
    public static void CounterNums(List<int> numsStorage)
    {
        int result = numsStorage.Count();
        Console.WriteLine($"\n{result} is how much numbers you entered");
    }
   
   
}


// GEPETITO STYLAH ARREGLANDO COSITAS Y REFACTORIZANDO OTRAS

/*
using System;
using System.Collections.Generic;
using System.Linq;

internal class Ejercicio6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers until you press 0\n");
        int num;
        var numsStorage = new List<int>();

        do
        {
            if (int.TryParse(Console.ReadLine(), out num))
            {
                StorageNums(num, numsStorage);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        } while (num != 0);

        if (numsStorage.Count > 0)
        {
            int[] minMax = GetHigherAndLower(numsStorage);
            SubstractLowerToHigher(minMax);
            CounterNums(numsStorage);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }

    /// <summary>
    /// Adds a number to the list.
    /// </summary>
    public static void StorageNums(int num, List<int> numsStorage)
    {
        numsStorage.Add(num);
    }

    /// <summary>
    /// Returns an array with the highest and lowest numbers in the list.
    /// </summary>
    public static int[] GetHigherAndLower(List<int> numsStorage)
    {
        int[] arrayNums = numsStorage.ToArray();
        int higher = arrayNums.Max();
        int lower = arrayNums.Min();

        Console.WriteLine($"\n{higher} is the highest number you entered\n");
        Console.WriteLine($"\n{lower} is the lowest number you entered\n");

        return new int[] { higher, lower };
    }

    /// <summary>
    /// Calculates and prints the difference between the highest and lowest numbers.
    /// </summary>
    public static void SubstractLowerToHigher(int[] minMax)
    {
        int result = minMax[0] - minMax[1];
        Console.WriteLine($"\nThe difference between the highest and lowest number is = {result}\n");
    }

    /// <summary>
    /// Prints the number of numbers entered.
    /// </summary>
    public static void CounterNums(List<int> numsStorage)
    {
        int result = numsStorage.Count;
        Console.WriteLine($"\nYou entered {result} numbers.");
    }
}

*/

