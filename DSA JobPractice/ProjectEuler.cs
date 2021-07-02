using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_JobPractice
{
  public static class ProjectEuler
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
  
  public static long SearchForLargestPrime(long num)
  {

      long k = 2;
      long kCount = k;
      while (k*k <= num)
      {
        kCount = k * k;
        if (num % k == 0)
        {
          num /= k;
        }
        else
        {
          ++k;
        }
        
      }
    return num;
  }
  
  public static int LargestPalindromeProductOfTwoNumbers(int numDigits) {

      //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.
      //Find the largest palindrome made from the product of two 3 - digit numbers.

      //ANS: 913 * 993 = 906609
      List<int> palindromInt = new List<int>();
      string stringInt = "";     
      for (int i = 0; i < numDigits; i++)
      {
        stringInt += "9";
      }
      int numOne = int.Parse(stringInt);
      int numTwo = int.Parse(stringInt);
      int largest = 0;
      int product;


      for (int i = numOne; i > 0; i--)
      {
        for (int j = numTwo; j > 0; j--)
        {
          //Console.WriteLine($"{i} * { j} = {i * j}");
          product = i * j;
          if (IsPalindrome(product))
          {
            if (largest < product) largest = product;
          }
          //906609
        }
      }  
      foreach (int i in palindromInt)
      {
        if (i > largest) largest = i;
        Console.WriteLine(i);
      }
      return largest;
    }
  public static bool IsPalindrome(int num)
  {
    num = Math.Abs(num);
    char[] numstring = num.ToString().ToCharArray();
    int indexLeft = 0;
    int indexRight = numstring.Length - 1;
    while (indexLeft < indexRight)
    {
      if (numstring[indexLeft] != numstring[indexRight]) return false;
      indexLeft++;
      indexRight--;
    }
    return true;

  }

  public static int SmallestDivisibleNumberByAllNumbers(int n)
  {
      //Count by n it is largest number must be divisible
      bool allDivisible = false;
      int counter = n;
      while (!allDivisible)
      {
        allDivisible = true;
        for (int i = 1; i <= n; i++)
        {
          if (counter % i != 0)
          {
            
            allDivisible = false;
            break;
          }
        }
          counter += n;
      }
    return counter - n;
  }
  public static double DiffSumSquaresAndSquareOfSum(int num)
  {
      double sumSquares = 0;
      double squareOfSum = 0;

      for(int i = 1; i <= num; i++)
      {
        sumSquares += Math.Pow(i, 2);
        squareOfSum += i;
      }
      squareOfSum = Math.Pow(squareOfSum, 2);      
      
      return squareOfSum - sumSquares;
  }
  public static double NthPrimeNumber(int nPrime)
    {
      int counter = 0;
      int intTracker = 0;
      bool isPrime;
      while (counter <= nPrime)
      {
        intTracker++;
        isPrime = true;
        for (int i = 2; i < intTracker; i++)
        {
          if (intTracker % i == 0) isPrime = false;
        }
        if (isPrime) counter++;
      }

      
      return intTracker;
    }

  }
}
