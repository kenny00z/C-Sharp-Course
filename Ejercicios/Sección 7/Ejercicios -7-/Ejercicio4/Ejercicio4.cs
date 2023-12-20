namespace Ejercicio4;

internal class Ejercicio4
{
    static void Main(string[] args)
    {
       List<int> myList = new List<int>();
        List<int> myList2 = new List<int>();
        EnterNums(myList, myList2);
        SortNums(myList);
        SortNums2(myList2);
        PrintLowHighNums(myList);
        PrintLowHighNums(myList2);
    }
    //listado que pida 10 numeros y almacene estos
    public static void EnterNums(List<int> myList, List<int> myList2) 
    {
        Console.WriteLine("Plz introduce ten numbers :3\n\n");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Choosing number {i + 1} of ten\n");
            myList.Add(Convert.ToInt32(Console.ReadLine()));
            myList2.Add(myList[i]);
        }

    }
    //funcion que encuentre haga un sorter (bubble sort)
    public static void SortNums(List<int> myList)
    {
        for (int i = 0; i < myList.Count - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < myList.Count - 1; j++) //-1 para que no se salga, y si añadimos menos i (ganamos en velocidad computacional) ya que restamos cada vez una iteracion dado que al acabar este for el numero mas grande ya se ha ido a la derecha del todo y no hace falta volver a comprobarlo.
            {        
                if (myList[j] > myList[j + 1])
                {
                    int temp = myList[j];
                    myList[j] = myList[j + 1];
                    myList[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
        /*
        Console.WriteLine("\n");
        Console.WriteLine("LIST:");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
        */
    }
    //funcion pinta el numero mas bajo y mas alto 
    public static void PrintLowHighNums(List<int> myList) 
    {
        Console.Write($"the lowest number is: {myList[0]}\n");
        Console.Write($"the highest number is: {myList[myList.Count - 1]}\n");      
    }
    //SORT MODO "FACIL"
    public static void SortNums2(List<int> myList) 
    {
        myList.Sort();
    }
}

/*4- Crear un programa nos pida introducir 10 números enteros. 
 * esos valores los introduciremos en un Listado y  mostraremos 
 * el numero mayor y menor, consultando los valores en el Listado.
 */