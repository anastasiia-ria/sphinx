using System;

namespace Sphinx.Riddles
{
  public class Riddle
  {
    public string Question { get; set; }
    public string Answer { get; set; }
    public Riddle(string question, string answer)
    {
      Question = question;
      Answer = answer;
    }
    public bool Correct(string userAnswer)
    {
      return (userAnswer == Answer);
    }
  }
}