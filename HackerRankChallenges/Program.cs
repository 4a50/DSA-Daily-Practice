﻿using System;
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
  }
}