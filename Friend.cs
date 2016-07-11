using System;

class Friends
{
  static void Main()
  {
    string[] myFriends = {"Lisa", "Rudy", "Sam", "Barry"};
    foreach(var list in myFriends)
    {
      Console.WriteLine("My best friends are " + list);
    }
  }
}
