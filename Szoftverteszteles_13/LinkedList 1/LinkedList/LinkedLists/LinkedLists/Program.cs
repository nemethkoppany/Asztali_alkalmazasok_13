using System.Collections.Generic;

namespace TestProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.add(10);
            list.add(20);
            list.add(30);

            list.print();
            Console.WriteLine();
            list.PrintReversedWithRecursion();
        }
    }
}
