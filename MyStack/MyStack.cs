using System;
using System.Collections;

namespace LinkedList;

public class MyStack<T>
{
    private MyLinkedList<T> _items = new MyLinkedList<T>();

    public int Count
    {
        get { return _items.Count; }
    }

    public void Push(T item)
    {
        _items.AddFirst(item);
    }

    public T Pop()
    {
        if (_items.Count == 0) throw new InvalidOperationException();

        T topValue = Peek();
        _items.RemoveFirst();
        return topValue;

    }

    public T Peek()
    {
        return _items.First();
    }
}