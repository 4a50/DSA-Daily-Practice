using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
  public class LinkedList<T>
  {
    public Node<T> Head { get; set; }
    public Node<T> Tail { get; set; }
    public LinkedList() { }
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
  }
}
