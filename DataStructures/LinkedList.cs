using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList<T>
  {
    public Node<T> Head { get; set; }
    public Node<T> Tail { get; set; }
    public LinkedList() {
      Head = null;
    }
    public LinkedList(Node<T> node)
    {
      Head = node;
      Tail = node;
    }

    public void Add(Node<T> node)
    {
      if (Head.Next == null) {
        Head.Next = node;
        Tail = node;
      }
      else
      {
        Tail.Next = node;
        Tail = node;
      }
    }
    public void Add(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Head == null)
      {
        Head = node;
      }

      else if (Head.Next == null)
      {
        Head.Next = node;
        Tail = node;
      }
      else
      {
        Tail.Next = node;
        Tail = node;
      }
    }
    public void Print()
    {
      Console.WriteLine("Linked List:\n==============");
      Node<T> curNode = Head;
      while(curNode != null)
      {
        Console.Write($"{curNode.Value} -> ");
        curNode = curNode.Next;
      }
      Console.WriteLine("Null");
    }
  }
}
