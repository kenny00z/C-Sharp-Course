namespace Ejercicio4;

internal class Ejercicio4
{
    static void Main(string[] args)
    {
       List<int> myList = new List<int>();
        EnterNums(myList);
        PrintHighNum(myList);


    }
    //listado que pida 10 numeros y almacene estos
    public static void EnterNums(List<int> myList) 
    {
        Console.WriteLine("Plz introduce ten numbers :3\n\n");
        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine($"Choosing number {i + 1} of ten\n");
            myList.Add(Convert.ToInt32(Console.ReadLine()));
        }
        
    }
    //funcion que encuentre haga un sorter 
    public static void PrintHighNum(List<int> myList)
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
        Console.WriteLine("\n");
        Console.WriteLine("LIST:");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
    //funcion pinta el numero mas bajo y mas alto 




    //REPLICA MODO "FACIL"

}

/*4- Crear un programa nos pida introducir 10 números enteros. 
 * esos valores los introduciremos en un Listado y  mostraremos 
 * el numero mayor y menor, consultando los valores en el Listado.
 */