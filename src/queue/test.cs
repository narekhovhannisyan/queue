using System;

namespace queue_namespace
{
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
