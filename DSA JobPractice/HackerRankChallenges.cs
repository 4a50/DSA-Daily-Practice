using System;
using System.Collections.Generic;

namespace DSA_JobPractice
{
  public static class HackerRankChallenges
  {
    //TODO: Optimize the code
    public static string[] weightedUniformStrings(string s, int[] queries)
    {
      string[] result = new string[queries.Length];
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
          sum = charWeight - charWeightBase;
          possibleCombinations.Add(sum);
        }
      }
      for (int i = 0; i < queries.Length; i++)
      {
        if (possibleCombinations.Contains(queries[i]))
        {
          result[i] = "Yes";
        }
        else { result[i] = "No"; }
      }
      return result;

    }
    public static int SumArray(int[] ar)
    {
      int sum = 0;
      for (int i = 0; i < ar.Length; i++)
      {
        sum += ar[i];
      }
      return sum;
    }
    public static int[] CompareTheTriplets(int[] a, int[] b)
    {
      int[] results = new int[2];
      for (int i = 0; i < a.Length; i++)
      {
        if (a[i] > b[i]) results[0]++;
        else if (a[i] < b[i]) results[1]++;
      }
      return results;
    }
    public static int[] IceCream(int m, int[] arr)
    {
      int sumTest = 0;
      int[] results = new int[2];
      for (int i = 0; i < arr.Length; i++)
      {
        for (int j = 1; j < arr.Length; j++)
        {
          sumTest = arr[i] + arr[j];
          if (sumTest == m && j != i)
          {
            results[0] = i + 1;
            results[1] = j + 1;
            return results;
          }
        }
      }
      return results;
    }
    public static string DayOfTheProgrammer(int year)
    {
      int[] daysMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
      int countDays = 0;
      int month = 0;
      if (year == 1918) daysMonth[1] -= 13;
      else if (year <= 1917 && year % 4 == 0) daysMonth[1] += 1;
      else if ((year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))) daysMonth[1] += 1;
      for (int i = 0; i < daysMonth.Length; i++)
      {
        if (countDays < 256 && (countDays + daysMonth[i] > 256))
        {
          countDays = 256 - countDays;
          month = i + 1;
          break;
        }
        countDays += daysMonth[i];
        Console.WriteLine($"CountDays: {countDays}");
      }
      return $"{countDays}.{month.ToString("00")}.{year}";
    }
    public static void InsertionSortPartOne(int n, int[] arr)
    {
      int maxIndex = arr.Length - 1;
      int tracker = 0;
      for (int i = 0; i <= maxIndex; i++)
      {
        if (arr[maxIndex] != arr[i])
        {
          if (arr[i] > arr[maxIndex])
          {
            tracker = arr[i];
            arr[i] = arr[maxIndex];
            arr[maxIndex] = tracker;
          }
      Console.Write($"Array Iteration {i}: ");
      for (int j = 0; j < arr.Length; j++) { Console.Write($"[{arr[j]}] "); }
      Console.WriteLine();
        }
      }
    }

    public static List<int> rotLeft(List<int> a, int d)
    {
      //Brute Force:
      //rotate each int d number of times
      //while counter < d do the following
      //make a temp int to store the [0] element value
      //iterate through the array, starting at index 1.
      //array[i-1] = array[i];
      //if i == array.length - 1 then array[i] = tempInt;
      // WHILE to count FOR to interate
      //Passed All Tests, but not optimized, so missed the last tests.
      //Take 2:
      //Recursion?      
      //Did not pass time requirement!
      //Take 3:
      //split the elements up from 0:d and d+1:a.length
      //swap places.
      ///Recursive Solution
      //int firstArrayIndexValue = 0;
      //if (d == 0) { return a; }
      //firstArrayIndexValue = a[0];
      //for (int i = 1; i < a.Count; i++)
      //{
      //  a[i - 1] = a[i];
      //  if (i == a.Count - 1) { a[i] = firstArrayIndexValue; }
      //}
      //d--;
      //return rotLeft(a, d);
      ///
    //  int[] splitOne = new int[d - 1];
    //  int[] splitTwo = new int[a.Count - d];
    //  if (d < a.Count)
    //  {
    //    int[] arr = a.ToArray();
    //    for (int i = 0; i < arr.Length; i++)
    //    {
    //      Console.WriteLine(arr[i]);
    //      if (i < d - 1)
    //      {
    //        Console.WriteLine("First Half");
    //        splitOne[i] = a[i];
    //      }
    //      else
    //      {
    //        splitTwo[i - d] = a[i];
    //      }
    //    }
    //  }
      return new List<int>();
    }

  }
}
