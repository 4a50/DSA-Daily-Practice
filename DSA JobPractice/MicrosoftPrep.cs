using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_JobPractice
{
  static class MicrosoftPrep
  {
    //Sample: "()([){]{}}"
    
    public static bool BalancedBrackets(string str)
    {
      //are string is greater than 1 char
      if (str.Length > 1)
      {
        //create a queue
        Queue<char> q = new Queue<char>();
        //create a p1
        int p1 = 0;
        //create a p2
        int p2 = 1;
        //length
        int strLen = str.Length - 1;

        //while p1 and p2 are less than str len
        while(p1 < strLen && p2 < strLen)
        {
          // test if p1 is matched to p2
          if (BracketMatched(str[p1], str[p2]))
            {
              //  true p1 = p2+1 && p2 = p1+1
              p1 = p2 + 1;
              p2 = p1 + 1;
            }
            else
            {
              //  false enqueue p2 && p2++
              q.Enqueue(str[p2]);
              p2++;
              if (p2 > strLen) return false;
            }
        }
        // then evaluate queue
        char bOne;
        char bTwo;
        while (q.Count > 0)
        {
          if (!q.TryDequeue(out bOne)) return false;
          if (!q.TryDequeue(out bTwo)) return false;          
          if (!BracketMatched(bOne, bTwo)) return false;          //   dequeue char1, dequeue char 2 not matche return false

        }
      }
        return true;
    }
    public static bool BracketMatched(char a, char b)
    {
      switch(a)
      {
        case '[':
          if (b == ']') return true;
          break;
        case '{':
          if (b == '}') return true;
          break;
        case '(':
          if (b == ')') return true;
          break;        
      }
      return false;
    }
    public static string InputStringReverseByWord(string str){

      //Questions:
      //Are we able to disregard punctuation if added
      //Do numbers count as words (such as 1 2 3, etc)

      //Cases:
      // single word and single char are already reversed.

      //Algo

      // string: This is a string
      //  method to reverse the string
      // run a test to ensure that it is longer than one word or charater, if false return the string, already reversed.
      // create a string array that will split the string by space
      // iterate through that string array end to start adding the word and a space into the Stringbuilder
      // if the element in the array is zero we will omit the space at the end.

      //DataStructure could use.  Stack.  Make each word a node and place that in a stack, then pop each off the stack and place in new array.
      //BigO seems to be O(n) space
      StringBuilder sb = new StringBuilder();
      string[] splitString = str.Split(" ");
      for (int i = splitString.Length - 1; i >= 0; i--)
      {
        sb.Append(splitString[i]);
        if (i != 0) sb.Append(" ");
      }
      return sb.ToString();
      }
  public static List<bool> KidsWithCandies(int[] candies, int extraCandies)
  {
    //Problem Domain:  can the extraCandies be distributed such that a kid can have
    //the greatest number of candies
    int maxKidCandy = candies[0];
    List<bool> greatestCandies = new List<bool>();

    //example [2, 3, 5, 1, 3], three extra
    // [true, true, true, false, true]

    //Determine the greatest number in the array. That kid doesnt need any
    foreach (int c in candies) {  if (c > maxKidCandy) { maxKidCandy = c; } }

    //if some or all of the candies are given to the other kids can they equal greates number.
    // if they can then true, if not false.
    foreach(int c in candies)
      {
        if (c + extraCandies >= maxKidCandy) { greatestCandies.Add(true); }
        else { greatestCandies.Add(false); }
      }
      return greatestCandies;
  }
  }
}
//S: O(n), T: O(N)
