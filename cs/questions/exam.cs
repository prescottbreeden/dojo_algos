using System.Collections.Generic;

namespace algo_belt_exam
{
    // Question 1 (Node and SLL classes provided):
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T val)
        {
            Value = val;
        }
    }


    public class Sll<T>
    {
        Node<T> _head;

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

    // Question 2 and 3: BSTNode and BST class provided
    class BstNode
    {
        public int Value { get; set; }
        public BstNode Left { get; set; }
        public BstNode Right { get; set; }

        public BstNode(int value)
        {
            Value = value;
        }
    }

    class BinarySearchTree
    {
        public BstNode Root { get; set; }

        /// <summary>
        /// Adds a node to a BST
        /// </summary>
        /// <remarks>Time Complexity: O(log(n))</remarks>
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

        /// <summary>
        /// Counts the number of nodes in a BST
        /// </summary>
        /// <remarks>Time Complexity: O(n)</remarks>
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

        // Question 4:
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

            /// <summary>
            /// Add an undirected edge
            /// </summary>
            public void AddEdge(int src, int dest)
            {
                AdjListArray[src].AddLast(dest);
                AdjListArray[dest].AddLast(src);
            }

            /// <summary>
            /// Add a directed edge
            /// </summary>
            public void AddEdgeDirected(int src, int dest)
            {
                AdjListArray[src].AddLast(dest);
            }

        }

    }

}

/*

Question 5: Conceptual

    What is the Oder time complexity of most BST operations and why?

        O(log(n)): because the advantage of a BST is that it does level-by-level
        analysis/logic which means that the time complexity will always be the
        same as the height of the tree which is log(n).
    
    What is the difference between a graph with directed vs undirected edges?

        Directed edges can provide more information about the relationship 
        between two nodes on a graph such as followers on social media, a 
        directed edge might represent which user is following who, whereas an
        undirected edge will be more general such as whether two users on linkedIn
        are in each other's network.

    How do weighted edges effect graph searching? (feel free to provide examples)

        Weighted edges are heavily used in maps where we need to not only know 
        how to get from point A to point B but also know how much traffic there 
        is on any given path, what the speed limit is, etc. We can then use this
        information to try and determine the most optimal path between two nodes 

    What is the difference between Breadth First and Depth First searching?

        Given the following tree:

                A
               / \
              B   C
             /   / \
            D   E   F

        Depth First traversal: A, B, D, C, E, F
        Breadth First traversal: A, B, C, D, E, F


*/