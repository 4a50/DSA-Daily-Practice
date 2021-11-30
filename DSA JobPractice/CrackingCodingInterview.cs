using System;
using System.Collections.Generic;
using DataStructures;
using System.Text;

namespace DSA_JobPractice
{
  public static class CrackingCodingInterview
  {
    //Chapter 1 Arrays and Strings
    public static bool isUniqueWithHashTable(string str)
    {
      HashMap hashMap = new HashMap();
      bool isUnique = true;
      foreach (char c in str)
      {
        if (hashMap.Contains(c))
        {
          isUnique = false;
          break;
        }
        else
        {
          hashMap.Add(c);
          isUnique = true;
        }
      }
      return isUnique;
    }


    //Chapter 2 LinkedLists
    public static DataStructures.LinkedList<int> RemoveDuplicates(DataStructures.LinkedList<int> ll)
    {
      Node<int> curNode = ll.Head;
      Node<int> trailNode = null;
      List<int> cacheList = new List<int>();

      while (curNode != null)
      {
        if (cacheList.Contains(curNode.Value))
        {
          RemoveNode(curNode, trailNode);
        }
        else {
          cacheList.Add(curNode.Value);        
        trailNode = curNode;
        }
        curNode = curNode.Next;
      }
      return ll;
    }
    private static void RemoveNode(Node<int> curNode, Node<int> trailNode)
    {
      if (curNode.Next == null) trailNode.Next = null;
      else
      {
        trailNode.Next = curNode.Next;
        curNode = curNode.Next;
      }      
    }
  }  
}
class HashMap
{
  private char[] Map { get; set; }
  private int MapLength { get; set; }
  public HashMap()
  {
    Map = new char[200];
    MapLength = 200;
  }
  public HashMap(int size)
  {
    Map = new char[size];
    MapLength = size;
  }
  public void Print()
  {
    foreach(char c in Map)
    {
      int intChar = c;
      Console.Write($"{intChar} -> ");
    }
    Console.WriteLine();
  }
  public bool Contains(char c)
  {
    int hashKey = (int)c;
    if (Map[hashKey] != 0) return true;
    return false;
  }
  public void Add(char c)
  {
    //HashKey = Ascii number = indexNumber of map
    int hashKey = (int)c;
    Map[hashKey] = c;
  }

}