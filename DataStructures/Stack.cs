using System;

namespace DataStructures
{
  public class Stack<T>
  {
    public Node<T> Top { get; set; }
    public Stack() {
    }
    public Stack(Node<T> node)
    {
      Top = node;
    }
    public Node<T> Push(Node<T> node)
    {
      if (Top == null) Top = node;
      else
      {
        node.Next = Top;
        Top = node;
      }
      return Top;
    }
    public T Peek()
      {
      if (Top == null) return default(T);          
      return Top.Value;
      }
    public Node<T> Pop()
    {
      if (Top.Next == null) return null;
      Node<T> poppedNode = Top;
      Top = Top.Next;
      return poppedNode;
    }
      
      

  }
}
