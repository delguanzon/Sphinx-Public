using Sphinx.Riddle;
using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {

    Riddle riddle = new Riddle();

    Console.WriteLine("Sphinx: Welcome! Answer my Riddle to Pass");

    Console.WriteLine("Sphinx: Answer me these: " + riddle.GetRiddle());
    string answer = Console.ReadLine();

    if(riddle.checkAnswer(answer))
    {
      Console.WriteLine("Sphinx: Congrats! You pass!");
      Console.WriteLine("Sphinx: Do you want another riddle?[Y][N]");
      string ans = Console.ReadLine();
      if(ans.ToLower() == "y")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Thank you for playing!");
      }

    }
    else
    {
      Console.WriteLine("Sphinx: WRONG! *Sphinx ate you* GG");
    }
  }
}