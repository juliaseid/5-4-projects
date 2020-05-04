using System;
using System.Collections.Generic;

class Sphinx
{

  static void Main()
  {
    bool alive = true;

    while (alive == true)
    {

      string[] riddles = { "I am not alive, but I grow; I don't have lungs, but I need air; I don't have a mouth, but water kills me. What am I?", "What kind of a goose eats snakes?", "What 4-letter word can be written forward, backward or upside down, and can still be read from left to right?" };
      string[] answers = { "Fire", "A mongoose", "NOON" };
      var random = new Random();
      int riddleIndex = random.Next(0, 2);
      Console.WriteLine(riddleIndex);
      string riddle1 = riddles[riddleIndex];
      Console.WriteLine(riddle1);
      string riddle1Ans = Console.ReadLine();
      if (riddle1Ans == answers[riddleIndex])
      {
        Console.WriteLine("That is correct! You live to die another day!");
      }
      else
      {
        Console.WriteLine("It looks like today is your day to die. The Sphinx is going to eat you.");
        alive = false;
      }
    }

  }
}