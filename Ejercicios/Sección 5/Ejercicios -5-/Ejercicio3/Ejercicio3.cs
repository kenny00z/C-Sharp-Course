using System.Runtime.CompilerServices;

namespace Ejercicio3;

internal class Ejercicio3
{
    static void Main(string[] args)
    {
        
        CalculatorC(CalculatorB(Money()));

    }

    //funcion introduce importe

    public static double Money()
    {
        double money;
        Console.WriteLine("\nIntroduce the quantity of money u wanna drill down to: \n");
        money = Convert.ToDouble(Console.ReadLine());
        return money;
    }
    public static double CalculatorB(double money)
    {
        double counterB = 0;
        double rest;
        Console.WriteLine("\n--The Amount of MoneyBills--\n ");
        while (money >= 500) 
        {
            money -= 500;
            counterB++;
        }
        Console.WriteLine($"Amount of 500's = {counterB}");
        counterB = 0;
        while (money >= 200)
        {
            money -= 200;
            counterB++;
        }
        Console.WriteLine($"Amount of 200's = {counterB}");
        counterB = 0;
        while (money >= 100)
        {
            money -= 100;
            counterB++;
        }
        Console.WriteLine($"Amount of 100's = {counterB}");
        counterB = 0;
        while(money >= 50)
        {
            money -= 50;
            counterB++;
        }
        Console.WriteLine($"Amount of 50's = {counterB}");
        counterB = 0;
        while (money >= 20)
        {
            money -= 20;
            counterB++;
        }
        Console.WriteLine($"Amount of 20's = {counterB}");
        counterB = 0;
        while (money >= 10)
        {
            money -= 10;
            counterB++;
        }
        Console.WriteLine($"Amount of 10's = {counterB}");
        counterB = 0; 
        while (money >= 5)
        {
            money -= 5;
            counterB++;
        }
        Console.WriteLine($"Amount of 5's = {counterB}");

        rest = money;
        return rest;
    }

    public static void CalculatorC(double money) 
    {
        double counterC = 0;
        Console.WriteLine("\n--The Amount of MoneyCoins--\n ");
        while (money >= 2)
        {
            money -= 2;
            counterC++;
        }
        Console.WriteLine($"Amount of 2's = {counterC}");
        counterC = 0;
        while (money >= 1)
        {
            money -= 1;
            counterC++;
        }
        Console.WriteLine($"Amount of 1's = {counterC}");
        counterC = 0;
        while (money >= 0.50)
        {
            money -= 0.50;
            counterC++;
        }
        Console.WriteLine($"Amount of 0.50's = {counterC}");
        counterC = 0;
        while (money >= 0.20)
        {
            money -= 0.20;
            counterC++;
        }
        Console.WriteLine($"Amount of 0.20's = {counterC}");
        counterC = 0;
        while (money >= 0.10)
        {
            money -= 0.10;
            counterC++;
        }
        Console.WriteLine($"Amount of 0.10's = {counterC}");
        counterC = 0;
        while (money >= 0.05)
        {
            money -= 0.05;
            counterC++;
        }
        Console.WriteLine($"Amount of 0.05's = {counterC}");
        counterC = 0;
        while (money >= 0.02)
        {
            money -= 0.02;
            counterC++;
        }
        Console.WriteLine($"Amount of 0.02's = {counterC}");
        counterC = 0;
        while(money >= 0.01)
        {
            money -= 0.01;
            counterC++;
        }
        Console.WriteLine($"Amount of 0.01's = {counterC}");
    }
   
}


// CAHT GEPETO SOLUCION REFACTORIZANDO CODIGO



/*
internal class Ejercicio3
{
    static void Main(string[] args)
    {
        double amount = Money();
        CalculateBillsAndCoins(amount);
    }

    public static double Money()
    {
        Console.WriteLine("\nIntroduce the quantity of money you want to drill down to: \n");
        return Convert.ToDouble(Console.ReadLine());
    }

    public static void CalculateBillsAndCoins(double amount)
    {
        double[] billsAndCoins = { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };

        string[] names = {
            "500's", "200's", "100's", "50's", "20's", "10's", "5's",
            "2's", "1's", "0.50's", "0.20's", "0.10's", "0.05's", "0.02's", "0.01's"
        };

        Console.WriteLine("\n-- The Amount of Money Bills and Coins --\n");

        for (int i = 0; i < billsAndCoins.Length; i++)
        {
            double billOrCoin = billsAndCoins[i];
            string name = names[i];

            if (amount >= billOrCoin)
            {
                int count = (int)(amount / billOrCoin);
                Console.WriteLine($"Amount of {name} = {count}");
                amount -= count * billOrCoin;
            }
        }
    }
}
*/