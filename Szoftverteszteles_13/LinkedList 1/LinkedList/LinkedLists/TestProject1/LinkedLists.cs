namespace TestProject1
{
    internal class LinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
        }
        private Node firstNode = null;
        public int First
        {
            get
            {
                if (Count == 0)
                {
                    throw new InvalidOperationException("The list is empty");
                }
                return firstNode.data;
            }
        }

        public int Count { get; private set; }
        internal Node add(int data)
        {
            Node originalDirstNode = firstNode;
            firstNode = new Node();
            firstNode.data = data;
            firstNode.next = originalDirstNode;
            Count++;
            return firstNode;
        }

        public void InsertAfter(Node node, int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = node.next;
            node.next = newNode;
            Count++;
        }

        public void RemoveFirst()
        {
            if (firstNode == null)
            {
                throw new InvalidOperationException("The list is empty");
            }
            firstNode = firstNode.next;
            Count--;
        }

        public void Remove(Node previous)
        {
            if (previous == null)
            {
                throw new InvalidOperationException("Previous node is null");
            }
            if (previous.next == null)
            {
                throw new InvalidOperationException("Node has no next node");
            }
            previous.next = previous.next.next;

        }

        public void print()
        {
            Node? node = firstNode;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public void PrintReversedWithRecursion()
        {
            PrintReversedWithRecursion(firstNode);
        }

        private static void PrintReversedWithRecursion(Node node)
        {
            if (node != null)
            {
                PrintReversedWithRecursion(node.next);
                Console.WriteLine(node.data);
            }
        }


    }
}