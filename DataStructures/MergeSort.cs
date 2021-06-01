using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public static class MergeSort
  {
    //Concept of a merge sort is to half an array, continually half the left until in order, then continually half the right until in order and then merge the two halves together.
    //This is done recursively

    
    //mergesort(array)
    //  mergesort(array left half)
    //  mergesort(array right half)
    //  merge left and right halves in sorted order.
    public static void SortInt(int[] arrayInt)
    {
      Sort(arrayInt, new int[arrayInt.Length], 0, arrayInt.Length);      
    }
    //This is a recursive method.
    private static void Sort(int[] arr, int[] temp, int leftStart, int rightEnd)
    {
      //Escape clause
      if (leftStart >= rightEnd) return;

      //Work
      int middle = (leftStart + rightEnd) / 2;
      //Sort Left
      Sort(arr, temp, leftStart + 1, middle);
      Sort(arr, temp, middle + 1, rightEnd);
      MergeHalves(arr, temp, leftStart, rightEnd);
    }
    private static void MergeHalves(int[] array, int[] temp, int leftStart, int rightEnd)
    {
      //determine the bounds for the merging
      int leftEnd = (rightEnd + leftStart);
      int rightStart = (leftEnd + 1);      
      int size = rightEnd - leftStart + 1;

      int left = leftStart;
      int right = rightStart;
      int index = leftStart;
      while(left <= leftEnd && right <= rightEnd)
      {
        if (array[left] <= array[right])
        {
          temp[index] = array[left];
          left++;
        }
        else
        {
          temp[index] = array[right];
          right++;
        }
        index++;
      }
      for (int i = right; i < array.Length; i++) { temp[index] = array[i]; }
      for (int i = left; i < array.Length; i++) { temp[index] = array[i]; }
      array = temp;
    }
  }
}
