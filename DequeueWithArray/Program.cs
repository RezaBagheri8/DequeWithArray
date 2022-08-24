using DequeueWithArray;

var queue = new Deque(10);

queue.StartDequeue();
queue.StartEnqueue(2);
queue.StartEnqueue(4);
queue.StartDequeue();
queue.StartDequeue();

queue.EndEnqueue(5);
queue.EndEnqueue(9);
queue.EndDequeue();
queue.EndDequeue();

queue.Print();

//queue.Print();