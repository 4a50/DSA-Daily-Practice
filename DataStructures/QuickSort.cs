using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public static class QuickSort
  {
    public static void Sort(int[] arr, int start, int end)
    {
      if (start < end)
      {
        //ensure start is less than end
        //  set partition value => Partition
        int partVal = Partition(start, end, arr);
        //  sort elements before partition
        Sort(arr, start, partVal - 1);
        //  sort elements after partition
        Sort(arr, partVal + 1, end);
      }
    }

    public static int Partition(int start, int end, int[] arr)
    {
      ////Built with pivot at end of array      
      //Set pivot index and value
      int pivInd = start;
      int pivVal = arr[pivInd];
      //Loop till start pointer crosses the end pointer,
      while (start < end)
      {
        //  Increment Start until value located that is greater than pivot value
        while (start < arr.Length && arr[start] <= pivVal) { start++; }
        //  Decrement End until value located that is less than the pivot value
        while (arr[end] > pivVal) { end--; }
        //  if start and end have not crossed each other, swap start and end
        if (start < end)
        {
          Swap(start, end, arr);
        }
      }
      Swap(pivInd, end, arr);
      //swap pivot element with end element
      return end;
      //return the end pointer    
      
    }
    public static void Swap(int indOne, int indTwo, int[] arr)
    {
      int tempVal = arr[indOne];
      arr[indOne] = arr[indTwo];
      arr[indTwo] = tempVal;
    }
  }
}
