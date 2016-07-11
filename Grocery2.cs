using System;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = {"eggs", "milk", "bread", "beer", "peachtea", "wine", "batteries"};
    int[] groceryListPrices = {2, 2, 1, 10, 2, 10, 5};

    Console.WriteLine("My grocery list");
    for(int index = 0; index < myGroceryList.Length; index ++)
    {
      Console.WriteLine(myGroceryList[index]);
    }

  }
}
