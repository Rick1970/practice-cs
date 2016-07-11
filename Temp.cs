using System;

class Temperature
{
  static void Main()
  {
    Console.WriteLine("What is the current temperature?");
    string stringInput = Console.ReadLine();
    int input = int.Parse(stringInput);

    if (input <= 120 && input > 95 || input <= 10)
    {
      Console.WriteLine("Probably be best if you stay inside.");
    }
    else if (input < 95 && input >= 68)
    {
      Console.WriteLine("Shorts and a tshirt are in order.");
    }
    else if (input <= 67 && input >= 50)
    {
      Console.WriteLine("Long sleeves and pants are in order.");
    }
    else if (input <= 49 && input >= 11)
    {
      Console.WriteLine("Better wear a jacket.");
    }
  }

}
