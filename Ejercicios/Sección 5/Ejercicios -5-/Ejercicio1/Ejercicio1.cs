namespace Ejercicio1;


internal class Ejercicio1
{


    static void Main(string[] args)
    {
        var option = Menu();

        while (option != "3")
        {
            SwitchOption(option);
            option = Menu();
        }
    }


    public static string Menu()
    {
        Console.WriteLine("\t\t\t\t\t\tMenu\n");
        Console.WriteLine("1. Dollars to Eur\n");
        Console.WriteLine("2. Euro to Dollars\n");
        Console.WriteLine("3. Exit\n");
        return Console.ReadLine();
    }

    public static void SwitchOption(string option)
    {
        switch (option)
        {
            case "1":
                //dollars to eur
                ConvertDollarToEuro();
                break;
            case "2":
                // euros to dollar
                ConvertEuroToDollar();
                break;
            case "3":
                Console.WriteLine("Bye");
                break;
            default:
                break;
        }
    }
    public static double ExchangeRateEuro()
    {
        Console.WriteLine("\nIntroduce the value of Euros and $ to get the exchange\n");
        Console.WriteLine("Euro value :");
        double euro = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("$ Value :");
        double dollar = Convert.ToDouble(Console.ReadLine());
        double exchange = euro / dollar;
        Console.WriteLine(exchange);
        return exchange;
    }
    public static double ExchangeRateDollar()
    {
        Console.WriteLine("\nIntroduce the value of Euros and $ to get the exchange\n");
        Console.WriteLine("Euro value :");
        double euro = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("$ Value :");
        double dollar = Convert.ToDouble(Console.ReadLine());
        double exchange = dollar / euro;
        Console.WriteLine(exchange);
        return exchange;
    }

    public static void ConvertEuroToDollar()
    {
        Console.WriteLine("\nIntroduce the amount of Euros u wanna convert\n");
        double euroAmount = Convert.ToDouble(Console.ReadLine());
        double dollarAmount = EuroToDollar(euroAmount, ExchangeRateEuro());
        Console.WriteLine($"\n The amount of dollars u get is {dollarAmount}");
    }

    public static void ConvertDollarToEuro()
    {
        Console.WriteLine("\nIntroduce the amount of Dollars u wanna convert\n");
        double dollarAmount = Convert.ToDouble(Console.ReadLine());
        double euroAmount = DollarToEuro(dollarAmount, ExchangeRateDollar());
        Console.WriteLine($"The amount of euros u get is {euroAmount}");
    }

    public static double EuroToDollar(double euro, double exchange)
    {
        double conversion = euro * exchange;
        return conversion;
    }

    public static double DollarToEuro(double dollar, double exchange)
    {
        double conversion = dollar * exchange;
        return conversion;
    }

}