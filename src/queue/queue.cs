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

    public int? dequeue()
    {
      if (head != tail)
      {
        head = head.Prev;
        head.Next = null;
        return head.Value;
      }
      else if (head != null)
      {
        head = tail = head.Prev = head.Next = null;
        return null;
      }
      else throw new Exception("queue is empty");
    }

    public int peek()
    {
      return head.Value;
    }

    public void logFromTail()
    {
      while (tail != null)
      {
        Console.WriteLine(tail.Value);
        tail = (tail.Next != null) ? tail.Next : null;
      }
      Console.WriteLine("End of queue!");
    }
  }
}
