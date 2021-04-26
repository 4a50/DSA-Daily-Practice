using System;
using System.Collections.Generic;

namespace MockInterviews
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      //OddNumber
      int[] arr = new int[] { 5, 1, 5, 1, 6, 5, 5 };
      int oddNumber = OddNumber(arr);
      Console.WriteLine("Integer Repeated Odd Number of Times: " + oddNumber);
    }    
      //# array of integers and one appears an odd number of times

      //# ex. 4,6,4 = 6
      //# ex. 1,2,3,4,1,3,4 = 2
      //# ex. 3,3,3,4,4,4,3,4,5,5,5 = 5
      //# ex. 5,1,5,1,6,5,5
  static int OddNumber(int[] arr)
    {
      Dictionary<int, int> hashTable = new Dictionary<int, int>();
      int dictValue = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        if (!hashTable.ContainsKey(arr[i])){ hashTable.Add(arr[i], 1); }
        else { 
            hashTable.TryGetValue(arr[i], out dictValue);
          dictValue++;
          hashTable[arr[i]] = dictValue;
        }
      }
        foreach (KeyValuePair<int, int> val in hashTable)
        {
          if (val.Value % 2 != 0) return val.Key;
        }
      return 0;
    }


  }
}
