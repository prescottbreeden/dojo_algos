namespace heaps
{
  public class Heap<T>
  {
    public Node<T> Root { get; set; }

    public Heap() { }

    public int Size()
    {
      return 0;
    }

    public Node<T> Top()
    {
      return Root;
    }

    public bool IsEmpty()
    {
      return Root is null;
    }

    public bool Contains(T val)
    {
      return false;
    }
  }
}