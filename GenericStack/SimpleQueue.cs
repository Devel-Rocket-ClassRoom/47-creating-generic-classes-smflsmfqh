using System;
using System.Collections.Generic;
using System.Text;

class SimpleQueue<T>
{
    private T[] _arr;
    private int _count;
    private int _initialIndex = 0;
    public int Count => _count;
    public bool IsFull => _count == _arr.Length;
    public bool IsEmpty => _count == 0; 
    public SimpleQueue(int capacity)
    {
        _arr = new T[capacity]; 
    }

    public void Enqueue(T item)
    {
        if (IsFull)
        {
            Console.WriteLine("큐가 가득 찼습니다.");
            return;
        }
        _arr[_count++] = item;
    }
    public T Dequeue()
    {
        if (IsEmpty) { Console.WriteLine("큐가 비어있습니다."); return default; }
        T item = _arr[_initialIndex];
        _initialIndex++;
        _count--;
        _arr[0] = default;
        return item;

    }
    public T Peek()
    {
        if (IsEmpty) { Console.WriteLine("큐가 비어있습니다."); return default; }
        return _arr[0]; 
    }

    public override string ToString()
    {
        return $"{string.Join(", ", _arr)}";
    }

}
