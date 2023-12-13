using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Sección4;
/*
internal class Ejercicio3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce the current day");
        String result;
        result = Console.ReadLine();
        String[] alldays = new string[14] { "Monday", "monday", "Tuesday", "tuesday", "Wednesday", "wednesday", "Thursday", "thursday", "Friday", "friday", "Saturday", "saturday", "Sunday", "sunday" };
        String[] week = new string[10] { "Monday", "monday", "Tuesday", "tuesday", "Wednesday", "wednesday", "Thursday", "thursday", "Friday", "friday" };
        String[] weekend = new String[4] { "Saturday", "saturday", "Sunday", "sunday" };

        for (int i = 0; i < alldays.Length; i++)
        {
            if (alldays[i] != result && i == (alldays.Length - 1))
            {
                Console.WriteLine("WRONG isn't a day!!");
            }
           // Console.WriteLine(alldays[i]);
            else 
            {
                foreach (String day in week)
                {
                    if (result == day)
                    {
                        Console.WriteLine("\nToday is a day of week cause it's " + result + "!");
                        return;
                    }
                }
                foreach (String day in weekend)
                {
                    if (result == day)
                    {
                        Console.WriteLine("\nToday is a day of weekend cause it's " + result + "!!!!!!!!!");
                        return;
                    }
                }
            }

        }
        
    }
}

*/
