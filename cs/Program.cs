using System;
using System.Collections.Generic;
using SLL;
using SortAlgos;
using heaps;
using bst;

namespace algos
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] bad = { 5, 42, 3, 0, 21, 10 };
      Sorts.QuickSort(bad, 0, bad.Length - 1);
      foreach (int num in bad)
        System.Console.WriteLine(num);

      var bob = new BinarySearchTree();
      bob.Add(10);
      bob.Add(12);
      bob.Add(18);
      bob.Add(42);
      bob.Add(5);
      bob.Add(8);
      bool x = bob.Contains(42);
      System.Console.WriteLine(x);
      int size = bob.Size();
      System.Console.WriteLine(size);
      System.Console.WriteLine("----------------");
      bob.Remove(10);
      x = bob.Contains(42);
      System.Console.WriteLine(x);
      size = bob.Size();
      System.Console.WriteLine(size);



    }
  }
}
