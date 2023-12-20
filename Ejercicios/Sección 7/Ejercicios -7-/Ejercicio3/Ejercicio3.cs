namespace Ejercicio3;

internal class Ejercicio3
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int>();

        StoreNums(myList);
        SumEvenNums(myList);
        SumOddNums(myList);

        Console.ReadKey();
    }

    //funcion que pide 10 numeros y los almacena
    public static void StoreNums(List<int> myList)
    {
        Console.WriteLine("Plz introduce ten numbers\n");
        Console.ReadKey();

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Introduce the {i} number and press enter\n");
            myList.Add(Convert.ToInt32(Console.ReadLine()));
        }
    }

    //funcion que recorre la lista y suma los pares
    public static void SumEvenNums(List<int> myList)
    {
        int result = 0;

        foreach (int number in myList)
        {
            if (number % 2 == 0)
            {
                result += number;
            }
        }
        Console.WriteLine($"The Sum of Even Numbers is: {result}\n");
    }
    //funcion que recorre la lista y suma impares
    public static void SumOddNums(List<int> myList)
    {
        int result = 0;

        foreach (int number in myList)
        {
            if (number % 2 != 0)
            {
                result = result + number;
            }
        }
        Console.WriteLine($"The Sum of Odd Numbers is: {result}\n");
    }
}
}
