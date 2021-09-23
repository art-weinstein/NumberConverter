using System;
using System.Collections.Generic;
using NumberConverter.Models;

namespace NumberConverter.Models
{
  public class Program
  {
    public static void Main()
    {
      System.Console.WriteLine("Welcome to the world famous number translator!");
      System.Console.WriteLine("Enter a number, and we will translate it into its word equivilant.");
      string userInput = Console.ReadLine();
      int number = int.Parse(userInput);
      string output = Convert.TranslateNumber(userInput);

      System.Console.WriteLine(output);
    }
  }
}