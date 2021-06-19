using System;
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
        if (i % 3 == 0 || i % 5 == 0) counter++;
      }
      //determine if divisiable by 3 or 5
      //if true: add to summ


        return counter;
    }
  }
}
