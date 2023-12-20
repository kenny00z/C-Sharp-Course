using System.Collections;

namespace Ejercicio5;

internal class Ejercicio5
{
    
    static void Main(string[] args)
    {
        ArrayList myArray = new ArrayList();
        int arraySize;
        if(ArraySize(out arraySize))
        {
            ElementsRequest(arraySize, myArray);
            PutElementOnPosition(arraySize, myArray);
            PrintArray(myArray);
        }
       
    }
    //funcion que pedira cuantos elementos tendra un array
    public static bool ArraySize(out int arraySize) // el out es para devolver un valor mediante el parametro , el parametro que se le pasa a la funcion cuando termine esta, devolvera un valor)
    {
        Console.Write("What number of values do u want on the array ?\n");
        arraySize = Convert.ToInt32(Console.ReadLine());
        if(arraySize == 0)
        {
            return false;
        }
        return true;
    }
    //funcion que pedirá elementos para ese array en funcion de la capacidad
    public static void ElementsRequest(int arraySize, ArrayList myArray)
    {
        Console.Write("Enter your values, whatever you want\n");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"Insert the {i} element: \n");
            myArray.Add(Console.ReadLine());
        }
        foreach (var item in myArray)
        {
            Console.Write($"{item}, ");
        }
        Console.Write("\n");
    }
    //pide un valor extra y la posicion en la cual queremos insertarlo.
    public static void PutElementOnPosition(int arraySize, ArrayList myArray)
    {
        Console.Write("Insert a new item\n");
        Console.Write("Choose the item: \n");
        var myItem = Console.ReadLine();
        Console.Write($"what position you choose between 0 and ${arraySize} to inster your new item");
        int myPosition = Convert.ToInt32(Console.ReadLine());
        while (myPosition > arraySize)//CONTROLAR EL ERROR
        {
            Console.Write($"Stupid enter a number between 0 and {arraySize}");
            myPosition = Convert.ToInt32(Console.ReadLine());
        }
        myArray.Insert(myPosition, myItem);
    }
    //pintar el array final
    public static void PrintArray(ArrayList myArray)
    {
       foreach (var item in myArray) 
        {
            Console.Write(item);
        }
    }
}

/*
 5- Usando Arrays, crea un programa que nos pida cuantos elementos tendrá el array,
 dependiendo de ese numero de elementos, nos ira pidiendo valores, que introduciremos
 en el array. una vez introducidos, nos pedirá un nuevo valor a insertar y la posición
 donde queremos insertarla en el array.
*/
