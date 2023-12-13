using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Sección4;

/*
internal class Ejercicio9
{
    static void Main(string[] args)
    {
        List<int> evenNums = new List<int>(); // Creamos una lista para poder almacenar los numeros con el add. ya que sobre un array no podemos hacerlo.
       for (int i = 1; i <= 100; i++) 
        {
            if (i % 2 == 0)
            {
               evenNums.Add(i); // añadimos los pares a la lista creada
            }
        }
        int[] arrayPares = evenNums.ToArray(); // una vez fuera del bucle creamos nuestro array lo igualamos a la lista y transformamos esa Lista en un array con el metodo .Toarray();
        Console.WriteLine(string.Join(", ", arrayPares)); // por ultimo y para poder imprimir el array de una manera visible en consola, utilizaremos el metodo string.join que crea una sola caden de todo el contenido del array y le añade ", " por cada elemento.

        // OTRA MANERA DE PINTARLO SERIA CON UN BUCLE FOR EACH O FOR
        Console.WriteLine("\n");

        for (int i = 0; i < arrayPares.Length; i++)
        {
            Console.Write(arrayPares[i]);
            if (i != arrayPares.Length - 1)
            {
                Console.WriteLine(", ");
            }
        }
    }
}
*/