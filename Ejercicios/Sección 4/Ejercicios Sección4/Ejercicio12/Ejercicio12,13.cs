namespace Ejercicio12;

internal class Ejercicio12
{
    static void Main(string[] args)
    {
        int num;
        int result = 0;
        double average = 0;
        Console.WriteLine("Hellouda, plz introduce a number between 1 and 1000! :3\n");
        num = Convert.ToInt32(Console.ReadLine());

        while (num < 1 || num > 1000) 
        {
            Console.WriteLine("I SAID BETWEEN 1 and 1000 ¬¬¬¬¬¬¬¬\n");
            num = 0;
            num = Convert.ToInt32(Console.ReadLine());
        }

        if (num % 2 != 0)
        {
            Console.WriteLine("\nYour Number is and Odd jujuju :3");
        }

        for (int i = 0; i < num; i++)  
        {
            result = result + (i + 1);
        }
        average = result / num;
        Console.WriteLine("\nThat's the result of the sum of 1 to your number = " + result + "!!\n");
        Console.WriteLine($"And that's the average of it = {average}!! :3");
    }
}