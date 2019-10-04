using System;

namespace titler
{
  class Program
  {
    static void Main(string[] args)
    {
      int nameAmount = int.Parse(args[0]);
      LogNames(nameAmount);
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

    private static void LogNames(int amount = 10)
    {
      for (int i = 1; i <= amount; i++)
      {
        Console.WriteLine($"{RandName()}");
      }
    }
  }
}