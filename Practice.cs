using System;

class Grades
{
  static void Main()
  {
    Console.WriteLine("What was your final grade in History class?");
    string input = Console.ReadLine();
    if (input == "A")
    {
      Console.WriteLine("Great Job!!");
    }
    else if (input == "B")
    {
      Console.WriteLine("Good Job");

    }
    else if (input == "C")
    {
      Console.WriteLine("Happy you passed.");
    }
    else
    {
      Console.WriteLine("You have some work to do!");
    }
  }
}
