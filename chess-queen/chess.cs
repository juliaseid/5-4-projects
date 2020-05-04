using System;
using System.Collections.Generic;

class Chess
{
  static void Main()
  {
    Console.WriteLine("Please enter coordinates for the Queen piece.");
    string[] QueenCoord = Console.ReadLine().Split(',');
    List<int> QueenIntCoord = new List<int> { };
    foreach (string coordinate in QueenCoord)
    {
      QueenIntCoord.Add(int.Parse(coordinate));
    }
    Console.WriteLine("Please enter coordinates for the Pawn piece.");
    string[] PawnCoord = Console.ReadLine().Split(',');
    List<int> PawnIntCoord = new List<int> { };
    foreach (string coordinate in PawnCoord)
    {
      PawnIntCoord.Add(int.Parse(coordinate));
    }
    if (QueenIntCoord[0] == PawnIntCoord[0] || QueenIntCoord[1] == PawnIntCoord[1] || (Math.Abs(QueenIntCoord[0] - PawnIntCoord[0]) == Math.Abs(QueenIntCoord[1] - PawnIntCoord[1])))
    {
      Console.WriteLine("The Queen can take the Pawn");
    }
    // foreach (int coordinate in QueenIntCoord)
    // {
    //   ;
    // }
    //(Math.Abs(QueenIntCoord[0] - PawnIntCoord[0]) == Math.Abs(QueenIntCoord[1] - PawnIntCoord[1]))
  }
}