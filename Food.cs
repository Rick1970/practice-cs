using System;

class Food
{
  static void Main()
  {
    string[] foods = {"Pizza", "Sushi", "Hamburgers", "Steak", "Mexican Food", "Italian Food", "Sweet Beverages", "Moms Cooking", "Lisa's Cooking", "Delights Cooking"};

    for(int index = 5; index < foods.Length; index ++)
    {
        Console.WriteLine(foods[index]);

      }
        Console.WriteLine("I am full!!");
    }

  }
