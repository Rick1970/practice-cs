using System;

class EvenOdd
{
  static void Main()
  {
    Console.WriteLine("Enter any number.");
    string stringEnteredNumber = Console.ReadLine();
    int enteredNumber = int.Parse(stringEnteredNumber);
    for(int number = enteredNumber; number > 0; number--)
    {
      if (number % 2 == 0)
      {
        Console.WriteLine("Even");
      }
      else
      {
        Console.WriteLine("Odd");
      }
    }
  }
}
