using System;
using System.Collections.Generic;
using SLL;
using SortAlgos;
using bst;
using algos.graphs;
using Scratch;

namespace algos
{
  class Program
  {
    static void Main(string[] args)
    {
      // Graph bob = new Graph(5);
      // bob.AddEdge(0, 1);
      // bob.AddEdge(1, 4);
      // bob.AddEdge(1, 3);
      // bob.AddEdge(1, 2);
      // bob.AddEdge(3, 4);
      // bob.AddEdge(2, 3);
      // bob.AddEdge(0, 4);
      // bob.PrintGraph(bob);

      // Graph gunicorn = new Graph(6);
      // gunicorn.AddEdgeDirected(1, 3);
      // gunicorn.AddEdgeDirected(1, 5);
      // gunicorn.AddEdgeDirected(2, 1);
      // gunicorn.AddEdge(2, 3);
      // gunicorn.AddEdgeDirected(4, 2);
      // gunicorn.AddEdge(4, 5);
      // gunicorn.PrintGraph(gunicorn);

      Person bob = new Person("Bob", 42);
      Person bugs;
      bugs = bob;
      bugs.changeDetails("Bugs", 24);
      System.Console.WriteLine(bob);
    }
  }
}
