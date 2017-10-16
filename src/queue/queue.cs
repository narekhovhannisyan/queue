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
      queue.dequeue();
      queue.dequeue();
      queue.dequeue();
      queue.dequeue();
      queue.dequeue();
      queue.dequeue();
      queue.dequeue();
      queue.dequeue();
      queue.dequeue();
      queue.enqueue(6);
      queue.enqueue(6);
      queue.dequeue();
      queue.logFromTail();
    }
  }
}
