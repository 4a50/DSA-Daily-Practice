﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_JobPractice
{
  public static class EulerProject
  {
    public static int MultiplesOfThreeAndFive(int natNumToTest)
    {
      //f we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
      //Find the sum of all the multiples of 3 or 5 below 1000.
      //count up to 10. sum tracker
      int counter = 0;
      for (int i = 1; i < natNumToTest; i++)
      {
        if (i % 3 == 0 || i % 5 == 0) counter += i;
      }
      //determine if divisiable by 3 or 5
      //if true: add to summ


      return counter;
    }
  public static long EvenFibonacciNumbers(int maxValue){
      long preValue = 1;
      long curValue = 1;
      long tempValue = 0;
      long sum = 0;
      while (preValue < maxValue && curValue < maxValue)
      {
        if (curValue % 2 == 0) sum += curValue;
      tempValue = curValue;
      curValue += preValue;
      preValue = tempValue;
      }
      //find the fibonacci sequence
      //loop until == maxvaule
      //  if value is even add to sum
    
    return sum;
  }
  }
  public static int LargestPrimeFactor (long inputNum)
  {
    
  }
}
