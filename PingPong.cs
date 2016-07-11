using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter a number.");
    string stringInputNumber = Console.ReadLine();
    int inputNumber = int.Parse(stringInputNumber);
    for( var index = 0; index <= inputNumber; index++)
    {
      if (index % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else if (index % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else
      {
        Console.WriteLine(index);
      }
    }
  }
}
