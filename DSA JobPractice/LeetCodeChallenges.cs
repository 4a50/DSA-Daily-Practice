using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_JobPractice
{
  static class LeetCodeChallenges
  {
    public static bool DailyFour(int[] nums)
    {
      ///This was NOT solved in 1 Hour.  Looked up answer for education.
      ///

      //Given an array of nums with n integers, check if it could become non-decreasing by modifying at most one element.
      // Constraints: n == num.Length
      //             1 <= n <= 10^4
      //             -10^5 <= nums[i] <= 10 ^5

      //track if modification can happen. Only once.  bool -> isDecreasing = true.  If false, second time detected return false
      //if it makes it through with true or false then return true.

      //conditions: Need to make sure the counter ahead does not go out of range.
      //            for loop?
      //
      //  for loop through array
      //  make sure i + 1 is not out of range.  If it is skip the look, or quit the loop
      //  check if the current value is < the next value.
      //     if true:
      //     if (i-2 >=0) { if arr[i] < arr[i-2] return false; }
      //     
      //
      //     if false:
      //     check if bool is false: if true, return bool
      //     else set bool to false
      //
      //  return true;

      // Looked Up Algo:
      // check the last number in the array if need to mod
      // check the first number in the array if need to mod
      // iterate through the middle of the array and determine if need to mod.
      // if mods > 1 then false
      //bool isNonDecreasing = true;
      //int intTrack = 0;
      // for (int i = 0; i < nums.Length; i++)
      //{
      //  if (i + 1 < nums.Length) {
      //    if (i - 2 >= 0)
      //    {
      //      if (nums[i] < nums[i - 2]) return false;
      //    }
      //    if (nums[i] > nums[i + 1])
      //    {
      //      if (isNonDecreasing)
      //      {
      //        isNonDecreasing = false;
      //      }
      //      else { return false; }
      //    }

      //  }
      //}      
      //return true;

      int mod = 0;
      int n = nums.Length;
      //Check first
      if (nums[0] >= nums[1]) mod++;
      //Check Last
      if (nums[n - 2] > nums[n - 1]) mod++;
      for (int i = 1; i < (n-1); i++)
      {
        //TODO: Need to take a look at the iterative evaluation of values
        //Check ahead
        if (nums[i] > nums[i + 1]) mod++;
        //Check behind
        if (nums[i] < nums[i - 1]) mod++;
        
        //Check if equal
        if (nums[i] == nums[i - 1] || nums[i] == nums[i + 1]) return false;
      }
      Console.WriteLine($"Mod: {mod}");
      if (mod > 1) return false;
      else { return true; }
    }

    //TODO: Really analyze this code.  Not sure how to do with existing knowledge
    public static int MinDistance(string word1, string word2)
    {
    //Given two strings return the minimum number of steps required to make word 1 and word 2 the same.
    //In ONE step you can delete exactly ONE character in either string.
    //Constraints: 1 <= word1 length, word2 length <= 500
    //only lowercase letters
    // EXAMPLE: "leetcode"  "etco"  => 4 

      //Track the index number to identify where the match takes place.
      //Take word two first letter and look through word one until a match:
      // 
      //  when match is found compare the next letter for matches.




      return 0;
    }

    public static int SortedListToBST() { return 0; }
    
    public static int[] TwoSums(int[] nums, int target)
    {
      //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
      //You may assume that each input would have exactly one solution, and you may not use the same element twice.
      //You can return the answer in any order.
      int[] result = new int[2];
      for (int i = 0; i < nums.Length; i++)
      {
        for (int j = i + 1; j < nums.Length; j++)
        {
          if (nums[i] + nums[j] == target)
          {
            result[0] = i;
            result[1] = j;
          }
        }
      }
      return result;
    }




  }
}
