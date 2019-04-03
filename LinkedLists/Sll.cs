namespace SLL
{
  class Sll<T>
  {
    Node<T> _head;


    /// <summary>
    /// Adds a new node to the front of the linked list.
    /// </summary>
    /// <param name="val">value of the new node</param>
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
    /// Prints the contents of the linked list.
    /// </summary>
    public void PrintList()
    {
      var runner = _head;
      while (runner != null)
      {
        System.Console.WriteLine(runner.Value);
        runner = runner.Next;
      }
    }
  }

}
