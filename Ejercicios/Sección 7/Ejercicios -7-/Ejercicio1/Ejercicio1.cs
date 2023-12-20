namespace Ejercicio1;

using System;
using System.Collections;

internal class Ejercicio1
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Here's your list: \n");
        Console.ReadKey();

        ArrayList myList = new ArrayList();
        FillArrayList(myList);
        SumNumsList(myList);
        Console.ReadKey();
    }

    //funcion para llenar el array con numeros de 1 a 1000
    public static void FillArrayList(ArrayList myList)
    {

        for (int i = 1; i <= 1000; i++)
        {
            myList.Add(i);
        }

    }

    //funcion para sumar cada numero al siguiente hasta el final
    public static void SumNumsList(ArrayList myList)
    {
        int totalSum = 0;

        for (int i = 0; i < myList.Count; i++)
        {
            totalSum = totalSum + Convert.ToInt32(myList[i]);
            Console.WriteLine($"{totalSum} , ");
        }
    }
}
