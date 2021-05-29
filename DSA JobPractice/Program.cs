using System;
using System.Collections.Generic;
using System.Numerics;

namespace DSA_JobPractice
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
      string testString = "Do a barrel roll Fox";
      string result = MicrosoftPrep.InputStringReverseByWord(testString);
      Console.WriteLine($"[{result}]");
    }
    public static void RunAllHackerRankChallenges() { } 
    public static void RunAllOtherDSAChallenges()
    {
      TicketStackProblem ticketProb = new TicketStackProblem();
      List<string> result = ticketProb.SortTickets();
      TicketStackProblem.PrintItenerary(result);
    }
    public static void RunLeetCodeChallenges()
    {
      Console.WriteLine("False: " + LeetCodeChallenges.DailyFour(new int[] { 4,2, 1 }));
      Console.WriteLine("True: " + LeetCodeChallenges.DailyFour(new int[] { 4, 2, 3 }));
      Console.WriteLine("False: " + LeetCodeChallenges.DailyFour(new int[] { 3, 4, 2, 3 }));
      Console.WriteLine("True: " + LeetCodeChallenges.DailyFour(new int[] { 5, 7, 1, 8 }));
    }
    static public void WeightedUniformStrings()
    {
      string s = "abccddde";
      int[] queries = { 1, 3, 12, 5, 9, 10 };
      string[] result = HackerRankChallenges.weightedUniformStrings(s, queries);
      for (int i = 0; i < result.Length; i++)
      {
        Console.Write($"[ {result[i] } ] ");
        Console.WriteLine();
      }
    }
    static public void SumArray()
    {
      int[] ar = { 2, 4, 6, 8, 10 };
      int total = HackerRankChallenges.SumArray(ar);
      Console.WriteLine($"Sum Array: {total}");
    }
    static public void CompareTheTriplets()
    {
      int[] a = { 41, 2, 3 };
      int[] b = { 3, 2, 1 };
      int[] results = HackerRankChallenges.CompareTheTriplets(a, b);
      Console.WriteLine($"Triplet Comparison Score: Alice - {results[0]}  Bob - {results[1]}");
    }
    static public void IceCream()
    {
      int m = 4;
      int[] cost = new int[] { 1, 4, 5, 3, 2 };
      int[] results = HackerRankChallenges.IceCream(m, cost);
      Console.Write("IceCream Results: ");
      for (int i = 0; i < results.Length; i++)
      {
        Console.Write($"{results[i]} ");
      }
      Console.WriteLine();
    }
    static public void DayOfTheProgrammer()
    {
      int year = 1918;
      string result = HackerRankChallenges.DayOfTheProgrammer(year);
      Console.WriteLine($"Day of the Programmer for {year}: {result}");
    }
    static public void BigSort()
    {  
      //TODO: BigSort
      string[] inArray = new string[] { "8", "1", "2", "100", "12303479849857341718340192371", "3084193741082937", "3084193741082938", "111", "200" };
      BigInteger bInt = BigInteger.Parse(inArray[4]);
      Console.WriteLine(bInt.ToString());

    }
    static  public void InsertionSortPtOne()
    {
      int n = 5;
      int[] arr = new int[] { 2, 4, 6, 8, 3 };

      Console.WriteLine("Insertion Sort Part One: ");
      for (int i = 0; i < arr.Length; i++) {Console.Write($"[{arr[i]}] ");}
      Console.WriteLine();
      HackerRankChallenges.InsertionSortPartOne(n, arr);
      for (int i = 0; i < arr.Length; i++) {Console.Write($"[{arr[i]}] ");}
      Console.WriteLine();

    }
  }
}

