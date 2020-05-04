using System;
using System.Collections.Generic;

class Clock
{
  static void Main()
  {
    Console.WriteLine("Please enter a time in hours and minutes");
    string[] timeString = Console.ReadLine().Split(":");
    float hourInt = float.Parse(timeString[0]);
    float minuteInt = float.Parse(timeString[1]);
    float hourFraction = (minuteInt / 60);
    float minAngle = minuteInt * 6;
    float hourAngle = (hourInt * 30 + hourFraction * 30);
    float angleBetween = Math.Abs(hourAngle - minAngle);
    if (angleBetween <= 180)
    {
      Console.WriteLine(angleBetween);
    }
    else if (angleBetween > 180)
    {
      Console.WriteLine(Math.Abs(360 - angleBetween));
    }
  }
}