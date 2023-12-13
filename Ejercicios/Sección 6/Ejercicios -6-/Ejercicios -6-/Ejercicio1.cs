using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Ejercicios__6_;

internal class Ejercicio1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hellouda plz introduce ur Name:\n");
        string myname;
        myname = Console.ReadLine();
        NameCheck(myname);
    }

    public static void NameCheck(string name) 
    {
        string nameL = name.ToLower();

        if (nameL == "alejandro") 
        {
            Console.WriteLine("\nHola, Tus Muelas");
        }
        else
        {
            Console.WriteLine("\nNo te conozco");
        }
    }
}


