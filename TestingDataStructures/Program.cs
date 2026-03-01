using LinkedList;

namespace TestingDataStructures;

public class Program
{
    private static void Main()
    {
        Console.WriteLine("Hello, World!");

        MyLinkedList<int> list = new MyLinkedList<int>();

        list.Add(1);
        list.Add(-1);
        list.Add(2);
        list.AddFirst(0);
        list.AddLast(3);

        Console.WriteLine(list + "\n");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
