using System.Collections.Generic;
using SLL;

namespace algos.graphs
{
  public class Graph
  {
    int TotalVertices;
    public LinkedList<int>[] AdjListArray;

    public Graph(int vertices)
    {
      TotalVertices = vertices;
      AdjListArray = new LinkedList<int>[TotalVertices];
      for (int i = 0; i < TotalVertices; i++)
        AdjListArray[i] = new LinkedList<int>();
    }

    public void AddEdge(int src, int dest)
    {
      AdjListArray[src].AddLast(dest);
      AdjListArray[dest].AddLast(src);
    }

    public void AddEdgeDirected(int src, int dest)
    {
      AdjListArray[src].AddLast(dest);
    }


    public void PrintGraph(Graph graph)
    {
      for (int v = 0; v < graph.TotalVertices; v++)
      {
        System.Console.WriteLine($"Adjacency list of vertex {v}");
        System.Console.WriteLine("Head");
        foreach (int pCrawl in graph.AdjListArray[v])
        {
          System.Console.WriteLine($" --> {pCrawl}");
        }
        System.Console.WriteLine("\n");
      }
    }
  }
}