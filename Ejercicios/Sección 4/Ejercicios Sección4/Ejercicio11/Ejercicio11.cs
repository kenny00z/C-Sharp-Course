namespace Ejercicio11;

internal class Ejercicio11
{
    static void Main(string[] args)
    {
        int numDay;
        Console.WriteLine("Choose the number which means the day of the week\n");
        
        do
        {

            numDay = 0;
            Console.WriteLine("-1\n");
            Console.WriteLine("-2\n");
            Console.WriteLine("-3\n");
            Console.WriteLine("-4\n");
            Console.WriteLine("-5\n");
            Console.WriteLine("-6\n");
            Console.WriteLine("-7\n");
            numDay = Convert.ToInt32(Console.ReadLine());

            switch (numDay)
            {
                case 1:Console.WriteLine("\nU choose Monday!");
                    break;
                case 2:Console.WriteLine("\nU choose Tuesday!");
                    break;
                case 3:Console.WriteLine("\nU choose Wednesday!");
                    break;
                case 4:Console.WriteLine("\nU choose Thursday!");
                    break;
                case 5:Console.WriteLine("\nU choose Friday!");
                    break;
                case 6:Console.WriteLine("\nU choose Saturday!");
                    break;
                case 7:Console.WriteLine("\nU choose Sunday!");
                    break;
                default:Console.WriteLine("\nPlz choose a number between 1-7\n");
                    break;
            }
        } while (numDay < 1 || numDay > 7) ;
        Console.ReadKey();
    }
}