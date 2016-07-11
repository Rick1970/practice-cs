using System;

class Excited
{
  static void Main()
  {
    string[] coolThings = {"seahawks", "programming", "family", "friends", "movies"};
    foreach(var like in coolThings)
    {

      Console.WriteLine("I am super excited about " + like.ToUpper() + "!");

    }

  }
}
