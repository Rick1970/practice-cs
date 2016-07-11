using System;
using System.Collections.Generic;

class Pet
{
public string Name;
public string Species;
public int Age;


}


public class Program
{
  public static void Main()
  {
    Pet fluffy = new Pet();
    fluffy.Name = "Fluffy";
    fluffy.Species = "Cat";
    fluffy.Age = 5;

    Pet spot = new Pet();
    spot.Name = "Spot";
    spot.Species = "Dog";
    spot.Age = 5;

    Pet ace = new Pet();
    ace.Name = "Ace";
    ace.Species = "Dog";
    ace.Age = 8;

    Pet tom = new Pet();
    tom.Name = "Tom";
    tom.Species = "Cat";
    tom.Age = 5;

    List<Pet> Pets = new List<Pet>() {fluffy, spot, ace, tom};
    foreach(Pet animal in Pets)
    {
      Console.WriteLine(animal.Name);
    }
      Console.WriteLine("Enter the maximum age pet you are looking for.");
      string stringMaxAge = Console.ReadLine();
      int maxAge = int.Parse(stringMaxAge);
      List <Pet> PetsMatchingSearch = new List<Pet>();
      foreach(Pet animal in Pets)
      {
        if (animal.Age <= maxAge)
        {
          PetsMatchingSearch.Add(animal);
        }
      }
      foreach(Pet animal in PetsMatchingSearch)
      {
        Console.WriteLine(animal.Name);
      }

  }
}
