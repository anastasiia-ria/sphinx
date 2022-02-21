using System;
using System.Collections.Generic;
using Sphinx.Riddles;

namespace Sphinx
{
  public class Program
  {
    public static void Main()
    {
      Riddle riddle1 = new Riddle("What can run, but never walks; has a mouth, but never talks; has a head, but never weeps; has a bed, but never sleeps?", "river");
      Riddle riddle2 = new Riddle("I can run but I cannot walk and thoughts follow me wherever I go.", "nose");
      Riddle riddle3 = new Riddle("If you feed me with food, I will survive. But if you make me drink water I will perish.", "fire");
      Riddle riddle4 = new Riddle("What is it that only has a sole voice and is four-footed in the morning and two-footed in the noon and three-footed in the evening?", "man");
      Riddle riddle5 = new Riddle("First think of the person who lives in disguise, Who deals in secrets and tells naught but lies. Next, tell me what's always the last thing to mend, The middle of middle and end of the end? And finally, give me the sound often heard During the search for a hard-to-find word. Now string them together, and answer me this, Which creature would you be unwilling to kiss?", "spider");

      bool correct = true;
      List<Riddle> Riddles = new List<Riddle>() { riddle1, riddle2, riddle3, riddle4, riddle5 };
      Random random = new Random();
      int count = Riddles.Count;
      for (int i = 0; i < count; i++)
      {
        if (correct)
        {
          int index = random.Next(Riddles.Count);
          Console.WriteLine("Riddle: ");
          Console.WriteLine(Riddles[index].Question);
          Console.WriteLine("Your answer: ");
          string userInput = Console.ReadLine().ToLower();
          correct = Riddles[index].Correct(userInput);
          Console.WriteLine("----------------------");
          Riddles.RemoveAt(index);
          if (correct && i == count - 1)
          {
            Console.WriteLine("Correct! You defeated a Sphinx");
          }
          else if (!correct)
          {
            Console.WriteLine("Wrong answer:( Sphinx eats you");
          }
        }
      }
      // foreach (Riddle puzzle in Riddles)
      // {
      //   if (correct)
      //   {
      //     Console.WriteLine(puzzle.Question);
      //     string userInput = Console.ReadLine().ToLower();
      //     correct = puzzle.Correct(userInput);
      //     if (correct)
      //     {
      //       Console.WriteLine("Correct! You defeated a Sphinx");
      //     }
      //     else
      //     {
      //       Console.WriteLine("Wrong answer:( Sphinx eats you");
      //     }
      //   }
      // }
    }
  }
}
