namespace Ejercicio5;

internal class Ejercicio5
{
    static void Main(string[] args)
    {
        int num;
        do
        {
            Console.WriteLine("Enter a positive number to check your multiplication table\n");
            num = Convert.ToInt32(Console.ReadLine());

            if (NumValidCheck(num))
            {
                Console.WriteLine($"\nHere is your table :3\n");
                MultTable(num);
                Console.ReadKey();
                break; 
            }
            else
            {
                Console.WriteLine("\nEnter a positive number, please try again.\n");
            }

        } while (true); // Bucle infinito hasta que se ingrese un número válido
    }
    public static bool NumValidCheck(int num)
    {
        if (num <= 0)
        {
            return false;
        }
        return true;
    }
    public static void MultTable(int num)
    {
        int result;
        for (int i = 1; i <= 10; i++) 
        {

            result = num * i;
            Console.WriteLine($"{num} * {i} = {result}");
        } 
    }
}