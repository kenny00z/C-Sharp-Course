namespace Ejercicio14;

internal class Ejercicio14
{
    static void Main(string[] args)
    {
        int num;
        int digits = 0;
        Console.WriteLine("Introduce an integer number\n");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nCalculating how much digits have your number, press any key...\n");
        Console.ReadKey();

        while (num / 10 >= 1)
        {
           num = num / 10;
           digits++;
        }
        digits += 1;
        Console.WriteLine($"\nYour integer have {digits} digits :3");
    }
}