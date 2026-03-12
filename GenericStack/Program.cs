using System;

SimpleQueue<int> IntQue = new SimpleQueue<int>(3);
SimpleQueue<string> StrQue = new SimpleQueue<string>(2);

IntQue.Enqueue(10);
IntQue.Enqueue(20);
IntQue.Enqueue(30);

StrQue.Enqueue("Hello");
StrQue.Enqueue("World");

Console.WriteLine($"=== int 큐 (용량: {IntQue.Count}) ===");
Console.Write("Enqueue: ");
Console.WriteLine(IntQue);
Console.WriteLine($"Count: {IntQue.Count}, IsFull: {IntQue.IsFull}");
IntQue.Enqueue(40);
Console.WriteLine($"Peek: {IntQue.Peek()}");
Console.WriteLine($"Dequeue: {IntQue.Dequeue()}");
Console.WriteLine($"Dequeue: {IntQue.Dequeue()}");
Console.WriteLine($"Count: {IntQue.Count}, IsFull: {IntQue.IsFull}");
Console.WriteLine();
Console.WriteLine($"=== string 큐 (용량: {StrQue.Count}) ===");
Console.Write("Enqueue: ");
Console.WriteLine(StrQue);
Console.WriteLine($"Peek: {StrQue.Peek()}");
Console.WriteLine($"Dequeue: {StrQue.Dequeue()}");
Console.WriteLine($"Dequeue: {StrQue.Dequeue()}");
Console.WriteLine($"Dequeue: {StrQue.Dequeue()}");
Console.WriteLine($"IsEmpty: {StrQue.IsEmpty}");

