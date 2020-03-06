using System;
using FindAndReplace.Models;

namespace FindAndReplace
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a sentence:");
      string sentence = Console.ReadLine();
      Console.WriteLine("Enter a word you want to replace in your sentence:");
      string searchFor = Console.ReadLine();
      Console.WriteLine("Enter a replacement word to replace the word you just mentioned:");
      string replaceWith = Console.ReadLine();

      Words newWords = new Words();
      Console.WriteLine(">>> Here's your new sentence:");
      Console.WriteLine(newWords.FindAndReplace(sentence, searchFor, replaceWith)); 
    }
  }
}
