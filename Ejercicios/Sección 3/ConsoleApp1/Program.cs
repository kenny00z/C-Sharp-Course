namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce tu Nombre! :3 -> ");
            String name;
            name = Console.ReadLine();
            Console.Write("Y el nombre de tu ciudad! :3 -> ");          
            String city;
            city = Console.ReadLine();   
            
            Console.WriteLine("Hola, " + name +" Bienvenuti a " + city);
        }
    }
}