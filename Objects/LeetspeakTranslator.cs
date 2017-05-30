using System;
using System.Collections.Generic;

namespace LeetSpeakTranslator
{
  public class LeetSpeakTranslator
  {
    private static List<string> _letters = new List<string>{};

    public static void DeleteAll()
    {
      _letters.Clear();
    }
    public string Translate(string test)
    {
      char [] testArray = test.ToCharArray();
      for (int i = 0; i < testArray.Length; i++)
      {
        string newLetter = testArray[i].ToString();
        if (newLetter == "e")
        {
          newLetter = "3";
        }
        if (newLetter == "o")
        {
          newLetter = "0";
        }
        Console.WriteLine(newLetter);
        _letters.Add(newLetter);
      }

      string result = String.Join("", _letters.ToArray());
      return result;
    }
  }
}
