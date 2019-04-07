using System.Collections.Generic;
namespace SLL
{
  class Sll<T>
  {
    Node<T> _head;


    /// <summary>
    /// Adds a new node to the front of the linked list.
    /// </summary>
    /// <param name="val">value of the new node</param>
    /// <remarks>Time Complexity: O(1)</remarks>
    public Sll<T> AddToFront(T val)
    {
      if(_head == null)
        _head = new Node<T>(val);
      
      else
      {
        var newNode = new Node<T>(val);
        newNode.Next = _head;
        _head = newNode;
      }
      return this;
    }


    /// <summary>
    /// Adds a new node to the back of the linked list.
    /// </summary>
    /// <param name="val">value of the new node</param>
    /// <remarks>Time Complexity: O(n)</remarks>
    public Sll<T> AddToBack(T val)
    {
      if(_head == null)
        _head = new Node<T>(val);
      
      else
      {
        Node<T> runner = _head;
        while(runner.Next != null)
        {
          runner = runner.Next;
        }
        runner.Next = new Node<T>(val);
      }
      return this;
    }


    /// <summary>
    /// Returns the number of nodes in the Linked List.
    /// </summary>
    /// <remarks>Time Complexity: O(n)</remarks>
    public int Size()
    {
      if (_head is null)
        return 0;
      Node<T> runner = _head;
      return 1 + _size(runner.Next);
    }

    int _size(Node<T> node)
    {
      if (node is null)
        return 0; 
      return 1 + _size(node.Next);
    }


    /// <summary>
    /// Prints the contents of the linked list.
    /// </summary>
    /// <remarks>Time Complexity: O(n)</remarks>
    public void PrintList()
    {
      var runner = _head;
      while (runner != null)
      {
        System.Console.WriteLine(runner.Value);
        runner = runner.Next;
      }
    }


    /// <summary>
    /// Reverses the order of the linked list.
    /// </summary>
    /// <remarks>Time Complexity: O(n)</remarks>
    public Sll<T> Reverse()
    {
      if (_head is null || _head.Next is null)
        return this;

      Node<T> prev = null;
      Node<T> current = _head;
      Node<T> next = current.Next;

      while (next != null)
      {
        current.Next = prev;
        prev = current;
        current = next;
        next = current.Next;
      }
      current.Next = prev;
      _head = current;

      return this;
    }

    public void Clear()
    {
      _head = null;
    }


  }
}
