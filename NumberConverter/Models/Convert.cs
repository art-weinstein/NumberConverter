using System.Collections.Generic;
using NumberConverter.Models;
using System;


namespace NumberConverter.Models
{
  public class Convert
  {
    public static Dictionary<int, string> translateToNineteen = new Dictionary<int, string>()
    {
      {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"}, {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}  
    };
      public static Dictionary<int, string> translateToNinetyNine = new Dictionary<int, string>()
    {
      {20, "twenty"}, {30, "thirty"}, {40, "fourty"}, {50, "fifty"}, {60, "sixty"}, {70, "seventy"}, {80, "eighty"}, {90, "ninety"}
    };
    public static string TranslateNumber(string userInput)
    {
      int number = int.Parse(userInput);
      if (number <= 19) {
        string result = translateToNineteen[number];
        return result;
      } else {
        string invalid = "enter a valid number";
        return invalid;
      }
      // int InputtedNumber = 0;
      // for(int i = 0; i <= number; i++){
      //   if(number <= 99){
      //     number = translateToNinetyNine[i] + translateToNineteen[i];
          
      //   }
      //   return InputtedNumber;
      // }
    }
  }
}