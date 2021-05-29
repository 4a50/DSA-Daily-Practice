using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }
    public Node<T> Next { get; set; }
    public Node(T value) {
      Value = value;
    }
  }
}
