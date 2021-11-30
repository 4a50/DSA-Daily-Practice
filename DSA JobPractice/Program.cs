using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using DataStructures;

namespace DSA_JobPractice
{
  class Program
  {
    static void Main(string[] args)

    {
      bool isUnique = CrackingCodingInterview.isUniqueWithHashTable("asdfjkl;");
      Console.WriteLine("Is string unique: " + isUnique);
      //HackerRankChallenges.miniMaxSum(new List<int> { 1, 3, 5, 7, 9 });
    }
    public static int minimumDistance(List<List<int>> area)
    {
      //[
      // [*1, 0, 0],
      // [1, 0, 0],
      // [1, 9, 1]
      //]      
      //create a two int array to track truck distance.
      int[] truckDistance = new int[2];
      int[] truckLoc = new int[2];

      while (truckLoc[0] < area.Count && truckLoc[1] < area[0].Count)
      {
        if (area[truckLoc[0]][truckLoc[1] + 1] == 1) {
          truckLoc[1]++;
          truckDistance[1]++;
        }
        else if (area[truckLoc[0] + 1][truckLoc[1]] == 1)
        {
          truckLoc[0]++;
          truckDistance[0]++;
        }
        else if (area[truckLoc[0] + 1][truckLoc[1]] == 9 || area[truckLoc[0]][truckLoc[1] + 1] == 9)
        {
          return truckDistance[0] + truckDistance[1] + 1;
        }
        


        //look in each direction to determine if truck can move.
        //if adjacent is open add to truck distance, set truck to new cell
        //if adjacent is destination add 1 
        // return the sum of the array
        //
      }
      return -1;
    }


    /// <summary>
    /// Amazon Question 1
    /// </summary>
    /// <param name="parts"></param>
    /// <returns></returns>

    
    public static int combineParts(List<int> parts)
    {
      //PD: Estimate time it will take for a worker to create the item to be ready for a customer shipment

      //Time required to put two parts together is the sum of the parts sizes
      //the newly constructed part is equal to the sum of the part's sizes

      //process is repeated until all parts have been merged together to for the final product

      //Input: array of ints
      //Output int for min time to assemble all parts

      //test: odd number of items

      //sort the array, for least to greatest.
      //create a variable sum to track total time.

      //iterate through the array (while)
      //add to sum -> arr[idx] + arr[idx + 1]
      //exit array when idx + 1 <= arr.length -1

      //2, 5, 12, 13 = 32
      //7, 12, 13 -> 19, 13
      //19, 13 -> 32
      //recursion?      
      //func sortadd -> list, sum
      //if list length <= 1 return sum
      //sort list
      //sum += list[0], list[1]
      //remove items [0] and [1]
      //return sortAdd(list, sum)
      int[] sum = new int[] { 0 };
      SortAdd(parts);
      return parts[0];
    }
    //8, 4, 6, 12
    //8, 10, 12
    //18, 12
    //30

    public static List<int> SortAdd(List<int> list)
    {
      if (list.Count <= 1) return list;
      list.Sort();
      int sum = list[0] + list[1];
      list.RemoveRange(0, 2);
      list.Add(sum);
      return SortAdd(list);
      //todo: track the time required (array? or list?)

    }
    public static char[,] RotateBox(char[,] boxOne)
    {
      char[,] boxTwo = new char[boxOne.GetLength(1), boxOne.GetLength(0)];      
      for (int i = 0; i < boxOne.GetLength(0); i++)
      {
        for (int j = 0; j < boxOne.GetLength(1); j++)
        {
          boxTwo[j,i] = boxOne[i,j];
        }
      }      
      return boxTwo;
    }
    public static void Print2DArray(char[,] charArr)
    {
      Console.WriteLine("Called Print");
      for (int i = 0; i < charArr.GetLength(0); i++)
      {
        for (int j = 0; j < charArr.GetLength(1); j++)
        {
          Console.Write($"[{charArr[i, j]}] ");
        }
        Console.WriteLine();
      }
    }
    public static int[] CreateTestIntArray(int lowest, int highest, int numElements)
    {
      Random randGen = new Random();      
      int[] result = new int[numElements];
      for (int i = 0; i < result.Length; i++)
      {
        result[i] = randGen.Next(lowest, highest + 1);
      }
      return result;
    }
    public static void DisplayArray(int[] arr)
    {
      Console.WriteLine();
      for (int i = 0; i < arr.Length; i++){
        if (i != arr.Length - 1) Console.Write($"[{arr[i]}] ");
        else { Console.WriteLine($"[{arr[i]}]"); }
      }
    }
    
    public static DataStructures.Stack<string> CreateStack()
    {
      DataStructures.Stack<string> stack = new DataStructures.Stack<string>();      
      string[] strArr = new string[] { "Fox", "Falco", "Slippy", "Peppy" };      
      for (int i = 0; i < strArr.Length; i++)
      {
        stack.Push(new DataStructures.Node<string> (strArr[i]));
      }

      return stack;

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

