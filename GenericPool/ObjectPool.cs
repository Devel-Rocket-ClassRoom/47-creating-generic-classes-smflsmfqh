using System;
using System.Collections.Generic;
using System.Text;

class ObjectPool<T> where T : class, IPoolable, new()
{
    private int _maxSize;
    private List<T> _available;
    private List<T> _active;
    public int ActiveCount => _active.Count;
    public int AvailableCount => _available.Count;

    public ObjectPool(int maxSize)
    {
        _maxSize = maxSize; 
        _available = new List<T>();
        _active = new List<T>();
    }

    public T Get()
    {
        if (_available.Count != 0)
        {
            _active.Add(_available[_available.Count - 1]);
            _available.RemoveAt(_available.Count - 1);

        }
        else if (_available.Count == 0 && (_active.Count + _available.Count) < _maxSize)
        {
            T item = new T();
            _active.Add(item);
        }
        else { Console.WriteLine("풀이 가득 찼습니다!"); return null; }

        return _active[_active.Count - 1];
    }

    public void Return(T item)
    {
        item.Reset();
        _active.Remove(item);
        _available.Add(item);

        Console.WriteLine("총알 반납됨");
    }
}
