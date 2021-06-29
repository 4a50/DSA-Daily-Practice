using System;
using System.Collections.Generic;

namespace TestBench
{
  class Program
  {
    static void Main(string[] args)
    {
      string s = "abccddde";
      int[] queries = { 6, 1, 3, 12, 5, 9, 10 };
      string[] result = weightedUniformStrings(s, queries);
      for (int i = 0; i < result.Length; i++)
      {
        Console.Write($"[ {result[i] } ] ");
        Console.WriteLine();
      }
    }
    static string[] weightedUniformStrings(string s, int[] queries)
    {
      string[] result = new string[queries[0]];
      char prevChar = '.';
      int sum = 0;
      int charWeight = 0;
      int charWeightBase = 96;
      List<int> possibleCombinations = new List<int>();
      for (int i = 0; i < s.Length; i++)
      {
        charWeight = (int)s[i];
        if (i > 0) { prevChar = s[i - 1]; }
        if (prevChar == s[i])
        {

          possibleCombinations.Add(sum += (charWeight - charWeightBase));
        }
        else
        {
          sum = 0;
          possibleCombinations.Add(charWeight - charWeightBase);
        }
      }
      for (int i = 1; i < queries.Length; i++)
      {
        if (possibleCombinations.Contains(queries[i]))
        {
          result[i - 1] = "Yes";
        }
        else { result[i - 1] = "No"; }
      }
      return result;

    }
    public static void plusMinus(List<int> arr)
    {
      float count = (float)arr.Count;
      int pos = 0;
      int neg = 0;
      int zero = 0;
      foreach (int i in arr)
      {
        if (i < 0) neg++;
        else if (i == 0) zero++;
        else if (i > 0) pos++;
      }
      Console.WriteLine($"{pos} {neg} {zero}");
      float posRatio = pos / count;
      float negRatio = neg / count;
      float zeroRatio = zero / count;
      Console.WriteLine($"{posRatio}");

      Console.WriteLine(posRatio.ToString());
      Console.WriteLine(negRatio.ToString());
      Console.WriteLine(zeroRatio.ToString());

    }
    public static void staircase(int n)
    {
      char[] poundArray = new char[n];
      for (int i = 0; i < poundArray.Length; i++) { poundArray[i] = ' '; }
      for (int i = poundArray.Length - 1; i >= 0; i--)
      {
        poundArray[i] = '#';
        Console.WriteLine(new string(poundArray));
      }
    }
  }
}
