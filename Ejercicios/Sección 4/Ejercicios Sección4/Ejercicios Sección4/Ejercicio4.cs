using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Sección4;

/*
internal class Ejercicio4
{
    static void Main(string[] args)
    {
        UInt32 price;
        int paymentMethod;
        Console.WriteLine("Write the price o your prodcut here, we are watching you...\n");
        price = Convert.ToUInt32(Console.ReadLine());
        
        

        do
        {
            paymentMethod = 0;
            Console.WriteLine("\nChoose ur Payment Method 1 or 2:\n");
            Console.WriteLine("\n1. CASH");
            Console.WriteLine("\n2. CARD");
            Console.WriteLine("\n3. EXIT\n");
            paymentMethod = Convert.ToInt32(Console.ReadLine());
            switch (paymentMethod)
            {
                case 1:
                    Console.WriteLine("\nU choose option 1, Cash Method");
                    break;

                case 2:
                    Console.WriteLine("\nU choose option 2, Card Method");
                    break;

                case 3:
                    Console.WriteLine("\nU choose exit\n");
                    break;

                default:
                    Console.WriteLine("\nPlz choose one of previous options");
                    break;
            }
            
        } while (paymentMethod != 1 && paymentMethod != 2); // otro aproach mucho más correcto sería } while (paymentMethod < 1 || paymentMethod > 2);
        if (paymentMethod == 2)
        {
            int cardNum;
            Console.WriteLine("\nIntroduce ur Account Num\n");
            cardNum = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\nThanks for trust on us! :D");
        Console.ReadKey();
    }
}
*/