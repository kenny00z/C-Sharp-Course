namespace Ejercicio10
{
    internal class Ejercicio10
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            var result = 0;
            Console.WriteLine("Choose ten nums the evens will be added the odds will be subtracted\n");

            for (int i = 0; i < 10; i++)
            {
                var num = Convert.ToInt32(Console.ReadLine());
                nums.Add(num);
            }
            foreach (int num in nums)
            {

                if (num % 2 == 0)
                {
                    result += num;
                }
                if (num % 2 != 0)
                {
                    result -= num;
                }
            }
            Console.WriteLine($"\nThe result is = {result}");
        }
    }
}