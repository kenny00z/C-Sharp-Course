namespace Ejercicio5;

internal class Ejercicio5
{
    static void Main(string[] args)
    {
        PrintAbcDesc();

    }
    //5- Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo)

    public static void PrintAbcDesc()
    {
        char c = 'Z';
        while (c >= 'A') 
        {
            Console.WriteLine(c--);
        }
    }
}