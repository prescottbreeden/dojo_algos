using System;
using SLL;

namespace algos
{
  class Program
  {
    static void Main(string[] args)
    {
      Sll<int> bob = new Sll<int>();
      bob.AddToFront(1).AddToFront(2).AddToFront(3);
      bob.PrintList();
    }
  }
}
