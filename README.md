# queue

Queue data structure implementation using c#

We call the INSERT operation on a queue ENQUEUE, and we call the DELETE operation DEQUEUE; like the stack operation POP, DEQUEUE takes no element argument. The FIFO property of a queue causes it to operate like a line of customers
waiting to pay a cashier. The queue has a head and a tail. When an element is enqueued, it takes its place at the tail of the queue, just as a newly arriving customer takes a place at the end of the line. The element dequeued is always the one at
the head of the queue, like the customer at the head of the line who has waited the
longest.

1) Array based queue (not interesting case)

Easy but wrong way to implement queue, because each time number was pushed into queue, it must resize it's array size.

2) Linked queue

The right way to implement queue :)
The Enqueue and Dequeue operations takes O(1) time to execute.