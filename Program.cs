using System;

namespace titler
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 101; i++)
      {
        Console.WriteLine($"{RandName()}");
      }
    }

    private static string RandName()
    {
      var words = new Words();
      var rand = new Random();
      int adjectiveIndex = rand.Next(0, words.Adjectives.Length);
      int nounIndex = rand.Next(0, words.Nouns.Length);
      string name = $"{words.Adjectives[adjectiveIndex]} {words.Nouns[nounIndex]}";
      return name;
    }
  }
}

// make words adjective and nouns members either fields or properties