using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
      string greeting = "Hello";
      greeting = greeting + "World";
      Console.WriteLine("greeting" + greeting); 
      Console.WriteLine($"greeting: {greeting}"); 
      Console.WriteLine("greeting: {0}", greeting);

      float side = 3.14F;
      float square = side * side;
      Console.WriteLine(square);

      Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
      { "firstInning", 10 },
      { "secondInning", 20},
      { "thirdInning", 30},
      { "fourthInning", 40},
      { "fifthInning", 50}
      };
      Console.WriteLine("----------------");
      Console.WriteLine("  Scoreboard");
      Console.WriteLine("----------------");
      Console.WriteLine("Inning |  Score");
      Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
      Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
      Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
      Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
      Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);

      string[] favFoods = new string[3]{ "pizza", "doughnuts", "icecream" };
      string firstFood = favFoods[0];
      string secondFood = favFoods[1];
      string thirdFood = favFoods[2];
      Console.WriteLine("I like {0}, {1}, and {2}", firstFood, secondFood, thirdFood);

      List<string> employees = new List<string>() { "Adam", "Amy" };
      employees.Add("Barbara");
      employees.Add("Billy");
      Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
      for (int i = 0; i < employees.Count; i++) 
        {
          Console.WriteLine(employees[i]);
        }
    }
  }
}