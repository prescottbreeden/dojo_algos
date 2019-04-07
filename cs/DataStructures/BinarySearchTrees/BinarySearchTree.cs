using System;

namespace bst
{
  class BinarySearchTree
  {
    public BstNode Root { get; set; }
    public BinarySearchTree() { }

    public void Add(int val)
    {
      BstNode runner = this.Root;
      if (runner is null)
        this.Root = new BstNode(val);
      while (runner != null)
      {
        if (val < runner.Value)
        {
          if (runner.Left is null)
          {
            runner.Left = new BstNode(val);
            return;
          }
          runner = runner.Left;
        }
        else
        {
          if (runner.Right is null)
          {
            runner.Right = new BstNode(val);
            return;
          }
          runner = runner.Right;
        }
      }
    }


    public bool Contains(int val)
    {
      BstNode runner = this.Root;
      while (runner != null)
      {
        if (runner.Value == val)
          return true;
        if (val < runner.Value)
          runner = runner.Left;
        else 
          runner = runner.Right;
      }
      return false;
    }


    public int Size()
    {
      if (Root is null) return 0;
      return 1 + Size(Root.Left) + Size(Root.Right);
    }

    int Size(BstNode node)
    {
      if (node is null) return 0;
      return 1 + Size(node.Right) + Size(node.Left);
    }


    public void Remove(int val)
    {
      if (Root is null)
        throw new InvalidOperationException("Cannot remove from an empty tree.");

      if (Root.Value == val)
        throw new InvalidOperationException("Don't have this logic yet");

      BstNode runner = Root;
      while (runner != null)
      {
        if (val < runner.Value)
        {
          if (runner.Left.Value == val)
          {
            BstNode temp = runner.Left;

            if (temp.Right != null)
              runner.Left = temp.Left;

            if (temp.Left != null)
              runner.Left.Right = temp.Right;

            if (temp.Right is null && temp.Left is null)
              runner.Left = null;

            return;
          }
          runner = runner.Left;
        }
        else 
        {
          if (runner.Right.Value == val)
          {
            BstNode temp = runner.Right;
            
            if (temp.Right != null)
              runner.Right = temp.Right;
              
            if (temp.Left != null)
              runner.Right.Left = temp.Left;
              
            if (temp.Right is null && temp.Left is null)
              runner.Right = null;
              
            return;
          }
          runner = runner.Right;
        }
      }

    }
  }
}
