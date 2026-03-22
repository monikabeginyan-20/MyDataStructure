using LinkedList;
using MyBinaryTreeProj;
using MyQueueProj;
using MyStackProj;
using System;

class Program
{
    public static object PostfixCalculator { get; private set; }

    static void Main(string[] args)
    {
        Console.WriteLine("=== TEST START ===");

        // ===== MyStack (LinkedList based) =====
        Console.WriteLine("\n--- MyStack ---");
        MyStack<int> stack = new MyStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        Console.WriteLine("Pop: " + stack.Pop());
        Console.WriteLine("Peek: " + stack.Peek());

        // ===== MyQueue =====
        Console.WriteLine("\n--- MyQueue ---");
        MyQueue<int> queue = new MyQueue<int>();
        queue.Enqueue(100);
        queue.Enqueue(200);
        Console.WriteLine("Dequeue: " + queue.Dequeue());

        // ===== Binary Tree =====
        Console.WriteLine("\n--- BinaryTree ---");
        BinaryTree tree = new BinaryTree();
        tree.Add(5);
        tree.Add(3);
        tree.Add(7);
        tree.Add(1);
        Console.WriteLine("Tree created successfully");

        // ===== LinkedList =====
        Console.WriteLine("\n--- MyLinkedList ---");
        MyLinkedList<int> list = new MyLinkedList<int>();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        Console.WriteLine("List Count: " + list.Count);

        Console.WriteLine("\n=== TEST END ===");
        Console.ReadLine();
    }

    internal class BinaryTree
    {
        internal void Add(int v)
        {
            
        }
    }

}