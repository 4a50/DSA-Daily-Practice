using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_JobPractice
{
  static class MicrosoftPrep
  {
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
  }  
}
