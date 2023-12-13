namespace Ejercicio4;

internal class Ejercicio4
{
    static void Main(string[] args)
    {
        char digit;
        Console.WriteLine("Introduce a digit to check if it's a number, vowel or consonant :3\n");
        digit = Convert.ToChar(Console.ReadLine());
        CheckDigit(digit);
        Console.ReadKey();
    }
    public static void CheckDigit(char digit)
    {
        if (IsNum(digit))
        {
            Console.WriteLine($"\nYour digit {digit} is a Number");
        }
        else if (IsVowel(digit))
        {
            Console.WriteLine($"\nYour digit {digit} is a Vocal");
        }
        else if (IsConsonant(digit))
        {
            Console.WriteLine($"\nYour digit {digit} is a Consonant");
        }
    }
    public static bool IsNum(char digit)
    {
        if (digit >= '0' && digit <= '9'){ return true;}
        return false;
    }
    public static bool IsVowel(char digit)
    {
        char[] vocals = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I','O','U' };
        for (int i = 0; i < vocals.Length; i++)
        {
            if (digit == vocals[i])
            {
                return true;
            }
        }
        return false;
    }
    public static bool IsConsonant(char digit)
    {
        if (Char.IsLetter(digit) && !IsVowel(digit))
        {
            return true;
        }
        return (false);
    }
}



//GEPETO STYLAH
/*
internal class Ejercicio4
{
static void Main(string[] args)
{
   char digit;
   Console.WriteLine("Introduce a digit to check if it's a number, vowel, or consonant: ");
   digit = Convert.ToChar(Console.ReadLine());
   CheckDigit(digit);
   Console.ReadKey();
}

public static void CheckDigit(char digit)
{
   if (IsNum(digit))
   {
       Console.WriteLine($"\nYour digit {digit} is a Number");
   }
   else if (IsVocal(digit))
   {
       Console.WriteLine($"\nYour digit {digit} is a Vocal");
   }
   else if (IsConsonant(digit))
   {
       Console.WriteLine($"\nYour digit {digit} is a Consonant");
   }
}

public static bool IsNum(char digit)
{
   return (digit >= '0' && digit <= '9');
}

public static bool IsVocal(char digit)
{
   char[] vocals = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I','O','U' };
   return Array.IndexOf(vocals, digit) >= 0;
}

public static bool IsConsonant(char digit)
{
   return (Char.IsLetter(digit) && !IsVocal(digit));
}
}

*/


// MI PRIMER APROACH (FALLO EN LAS CONSONANTES)

/*
internal class Ejercicio4
{
static void Main(string[] args)
{
    char digit;
    Console.WriteLine("Introduce a digit to check if is number, vocal or consonant :3\n");
    digit = Convert.ToChar(Console.ReadLine());
    CheckDigit(digit);
    Console.ReadKey();
}
public static void CheckDigit(char digit)
{
    IsNum(digit);
    IsVocal(digit);
    IsConsonant(digit);
}
public static void IsNum(char digit)
{
    if (digit >= '0' && digit <= '9') 
    {
        Console.WriteLine($"\nYour digit {digit} is a Number");
    }
    return;
}
public static void IsVocal(char digit) 
{
    char[] vocals = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I','O','U' };
    for (int i = 0; i < vocals.Length ; i++)
    {
        if (digit == vocals[i]) 
        {
            Console.WriteLine($"\nYour digit {digit} is a Vocal");
            break;
        }
    }
    return;
}
public static void IsConsonant(char digit) (ERROR CON LAS MAYUSCULAS)
{
    if (digit >= 'a' && digit <= 'z' && (digit != 'a' && digit != 'e' && digit != 'i' && digit != 'o' && digit != 'u'))
    {
        Console.WriteLine($"\nYour digit {digit} is a Consonant");
    }
}
}
*/