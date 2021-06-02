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
      
      Sort(arrayInt, 0, arrayInt.Length - 1);      
    }
    //This is a recursive method.
    private static void Sort(int[] arr, int leftStart, int rightEnd)
    {
      //Escape clause
      if (leftStart >= rightEnd) return;

      //Work
      int middle = (leftStart + rightEnd) / 2;
      //Sort Left
      Sort(arr, leftStart, middle);
      Sort(arr, middle + 1, rightEnd);
       MergeHalves(arr, leftStart, rightEnd, middle);
    }
    private static void MergeHalves(int[] arr, int left, int right, int middle)
    {
      
      //create two temp arrays lArr and rArr
      int lengthL = middle - left + 1;        //1
      int lengthR = right - middle;  // 1

      int[] arrL = new int[lengthL]; //1
      int[] arrR = new int[lengthR];//1

      // copy data into both arrays
      for (int i = 0; i < lengthL; i++) arrL[i] = arr[left + i]; //6
      for (int i = 0; i < lengthR; i++) arrR[i] = arr[middle + i + 1]; //3

      int indexL = 0;
      int indexR = 0;

      int arrIndex = left; //0

      //merge the arrays
      while(indexL < lengthL && indexR < lengthR)
      {
        if (arrL[indexL] <= arrR[indexR])  //6 <= 3
        {
          arr[arrIndex] = arrL[indexL];
          indexL++;
        }
        else
        {
          arr[arrIndex] = arrR[indexR]; //arr[0] = arrR[0]
          indexR++; //1
        }
        arrIndex++; //1
      }
      //loop until one is done, and then copy the remaining elements in.
      while (indexL < lengthL)
      {
        arr[arrIndex] = arrL[indexL];
        arrIndex++;
        indexL++;
      }
      while (indexR < lengthR)
      {
        arr[arrIndex] = arrR[indexR];
        arrIndex++;
        indexR++;
      }

    }
  }
}
