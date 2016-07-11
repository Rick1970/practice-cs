using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "beer", "peachtea", "wine", "batteries"};
    int[] groceryListPrices = {2, 2, 1, 10, 2, 10, 5};

    Console.WriteLine("My grocery list");
    foreach(string groceryItem in myGroceryList)
    {
      Console.WriteLine(groceryItem);
    }
    int total = 0;
    foreach(int price in groceryListPrices)
    {
      total += price;

    }
    Console.WriteLine("Your total will be " + total);
  }
}
