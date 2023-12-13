using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace Ejercicio3;

internal class Ejercicio3
{
    static void Main(string[] args)
    {
        string sentence;
        Console.WriteLine("Hellouda write a sentence wich contains at least 20 characters and 4 words or suffer!!\n");
        sentence = Console.ReadLine();
        MamaFunction(sentence);
        

    }
    //funcion que pase a array la frase , y compruebe que su longitud es mayor a 20 caracteres
    public static bool CheckChars(string sentence)
    {
        var arrayS = sentence.ToCharArray();
        Console.Write("\nTime to check if your're not dumb plz press Enter\n");
        Console.ReadKey();
        if (arrayS.Length < 20) 
        {
            Console.WriteLine("Your sentence is to short ff!\n");
            return false;
        }
        else 
        { 
            Console.Write("It's fine 20 chars or more you can continue ¬¬\n"); 
            return true; 
        }
    }
    //funcion que haga un split y calcule que hay mas de 4 palabras
    public static bool CheckWords(string sentence)
    {
        var arrayS = sentence.Split(' ');
        Console.Write("\nTime to check if your're not dumb again... press Enter\n");
        Console.ReadKey();
        if (arrayS.Length < 4) 
        {
            Console.WriteLine("Your sentence does not reach 4 words... ff!\n");
            return false;
        }
        else 
        {
            Console.Write("It's fine 4 words or more you can continue again... ¬¬\n");
            return true;
        }
    }
    //funcion logitud cadena
    public static void CheckLength(string sentence)
    {   
        int sLength = sentence.Length;

        Console.WriteLine($"\nThe length of your sentence is {sLength}\n");
    }
    //*pinta la cadena, remplazando la letra "a" por "x",
    //la "A" podrá ser mayúscula o minúscula en cuyo caso si es "a" se cambiara por una "x"
    //y si es "A" se cambiara por una "X"
    public static void Replacing(string sentence)
    {
        var arrayS = sentence.ToCharArray();
        Console.Write("\nReplacing all the a's and A's to x's or X's... press Enter\n");
        Console.ReadKey();
        for (int i = 0; i < arrayS.Length; i++) 
        {
            if (arrayS[i] == 'a')
            {
                arrayS[i] = 'x';
            }
            if (arrayS[i] == 'A')
            {
                arrayS[i] = 'X';
            }
        }
        string newSentence = new string(arrayS);
        Console.WriteLine($"\nThat's your setence replacing all the a's and A's:\n{newSentence}\n");
    }
    //pinta en mayus
    public static void PrintMayusMinus(string sentence)
    {
        Console.Write("\nYour setence to minus and mayus... press Enter\n");
        Console.ReadKey();
        Console.WriteLine(sentence.ToUpper()+"\n");
        Console.WriteLine(sentence.ToLower() +"\n");
    }
    //pinta quitando las 3 primeras letras
    public static void PrintCut3(string sentence)
    {
        var arrayS = sentence.ToCharArray();
        Console.Write("\nCutting the first three characters... press Enter\n");
        Console.ReadKey();
        char[] arrayC = new char[arrayS.Length]; 
        Array.ConstrainedCopy(arrayS, 3, arrayC, 0, arrayS.Length - 3);
        string sentenceC = new string(arrayC);
        Console.WriteLine($"\nHere is your new setence:\n{sentenceC}\n");
    }
    //pinta quitando la 5 posicion y la 10 
    public static void ErasePosition(string sentence)
    {   
        var arrayS = sentence.ToCharArray();
        var listS = arrayS.ToList();
        Console.Write("\nErasing position 5 and 10... press Enter\n");
        Console.ReadKey();
        for (int i = 0; i < listS.Count; i++) 
        {
            if (i == 5)
            {
                listS.Remove(listS[5]);
            }
            if (i == 10)
            {
                listS.Remove(listS[9]);//removemos la 9 porque al remover la 5 , la posicion 10 pasa a ser la 9
            }
        }
        string newSentence = new string (listS.ToArray());
        Console.WriteLine($"\nHere is your new setence without 5th and 10th position:\n{newSentence}\n");
    }
    //invertir cadena
    public static void Reverse(string sentence)
    {
        Console.Write("\nReversing your sentence... press Enter\n");
        Console.ReadKey();
        var arrayS = sentence.ToCharArray();
        Array.Reverse(arrayS);

        string newSentence = new string(arrayS);
        Console.WriteLine($"\nHere is your reversed sentence:\n{newSentence}\n");

    }
    //escribir el numero exacto de palabras que tenga la frase
    public static void WordsCounter(string sentence)
    {
        Console.Write("\nCounting words... press Enter\n");
        Console.ReadKey();
        var arrayS = sentence.Split(' ');
        var listS = arrayS.ToList();
        int counter = listS.Count;
        Console.WriteLine(listS[listS.Count - 1]);
        if (listS[0] == "")
        {
            counter = counter - 1;
        }
        if (listS[listS.Count - 1] == "")
        {
            counter = counter - 1;
        }
        Console.WriteLine($"\nThere are your number of words {counter}");
    }
    //escribir unicamente la 3 palabra 
    public static void ThirdWord(string sentence)
    {
        Console.Write("\nPrinting the third word... press Enter\n");
        Console.ReadKey();
        var arrayS = sentence.Split(' ');
        var listS = arrayS.ToList();
        if (listS[0] == "")
        {
            Console.WriteLine($"\nThere is the third word: {listS[3]}");
        }
        else
        {
            Console.WriteLine($"\nThere is the third word: {listS[2]}");
        } 
    }
    //FUNCION MAMA
    public static void MamaFunction(string sentence)
    {
        if (CheckChars(sentence) == false || CheckWords(sentence) == false)
        {
            Console.WriteLine("\n As I predcited you're dumb as fu.. :3");
        }
        else
        {
            CheckLength(sentence);
            Replacing(sentence);
            PrintMayusMinus(sentence);
            PrintCut3(sentence);
            ErasePosition(sentence);
            Reverse(sentence);
            WordsCounter(sentence);
            ThirdWord(sentence);
            Console.WriteLine("\nCongratz you're not really dumb :3");
        }
    }
}