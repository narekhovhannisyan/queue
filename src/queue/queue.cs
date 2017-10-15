using System;

namespace queue_namespace
{
  class lQueue
  {
    class Node
    {
      public Node Next;
      public Node Prev;
      public int Value;
    }

    Node head, tail, current = null;

    public void enqueue(int value)
    {
      Node newNode = new Node();
      if (head == tail)
      {
        newNode.Next = head;
        newNode.Value = value;
        head = current = newNode;
      }
      else
      {
        current = (tail == null) ? head : tail;
        newNode.Next = current;
        newNode.Value = value;
        tail = newNode;
        current.Prev = tail;
      }
    }

    public void logFromTail()
    {
      while (tail != null)
      {
        Console.WriteLine(tail.Value);
        tail = (tail.Next != null) ? tail.Next : null;
      }
    }
  }
  class queue
  {
    static void Main(string[] args)
    {
      lQueue queue = new lQueue();
      queue.enqueue(5);
      queue.enqueue(6);
      queue.enqueue(7);
      queue.enqueue(87);
      queue.enqueue(23);
      queue.enqueue(2);
      queue.enqueue(0);
      queue.enqueue(1);
      queue.enqueue(2);
      queue.logFromTail();
    }
  }
}
