using System;
using System.Collections.Generic;

namespace LeetSpeakTranslatorProject.Objects
{
  public class LeetSpeakTranslator
  {
    private static List<char> _letters = new List<char>{};

    public string Translate(string test)
    {
      char [] testArray = test.ToCharArray();
      for (int i = 0; i < testArray.Length; i++)
      {
        if (testArray[i] == 'e' || testArray[i] == 'E')
        {
          testArray[i] = '3';
        }
        if (testArray[i] == 'o' || testArray[i] == 'O')
        {
          testArray[i] = '0';
        }
        if (testArray[i] == 'I')
        {
          testArray[i] = '1';
        }
        if (testArray[i] == 't' || testArray[i] == 'T')
        {
          testArray[i] = '7';
        }
        if (testArray[i] == 's'  || testArray[i] == 'S'  && testArray[i - 1] != ' ')
        {
          testArray[i] = 'z';
        }
        _letters.Add(testArray[i]);
      }

      string result = String.Join("", _letters.ToArray());
      return result;
    }
    public static void DeleteAll()
    {
      _letters.Clear();
    }
  }
}
