using System;

class Potluck
{
  static void Main()
  {
    string[] guest = {"Lisa", "Ashley", "Cole", "Ryker"};
    string[] food = {"Chips", "Dip", "Soda", "Ice cream"};
    foreach(string people in guest)
    {
      Console.WriteLine(people + ", you are invited to the party!");
    }
    foreach(string items in food)
    {
      Console.WriteLine("We need " + items);
    }
  
  }
}
