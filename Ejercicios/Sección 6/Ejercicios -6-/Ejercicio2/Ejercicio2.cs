namespace Ejercicio2;

internal class Ejercicio2
{
    static void Main(string[] args)
    {
        string word;    
        Console.WriteLine("Introduce a word to reverse\n");
        word = Console.ReadLine();
        ReverseWord(word);
    }

    public static void ReverseWord(string word)
    {
        var reverseWord = word.ToCharArray();
        Array.Reverse(reverseWord);
        Console.WriteLine($"There's your reversed word: {reverseWord.ToString()}");
    }
}