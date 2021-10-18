using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_JobPractice
{
  public static class SeedData
  {
    public static List<List<int>> GetSquareMatrix()
    {
      List<List<int>> rows = new List<List<int>> {

        new List<int> { 1, 2, 3 },
        new List<int> { 3, 4, 5 },
        new List<int> { 9, 8, 9 }
        };
      Console.WriteLine("SquareMatrix:");
      for (int i = 0; i < rows.Count; i++)
      {
        for (int j = 0; j < rows[i].Count; j++)
        {
          Console.Write($"{rows[i][j] }");
        }
        Console.WriteLine();
      }
      return rows;
    }
  }
}
