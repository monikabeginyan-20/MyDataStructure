using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList;

public class MyLinkedListNode<T>
{
    public T Value { get; set; }
    public MyLinkedListNode<T> Next { get; set; }

    public MyLinkedListNode(T value)
    {
        Value = value;
        Next = null;
    }
}