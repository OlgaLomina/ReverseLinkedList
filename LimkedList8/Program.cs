using System;
// Reverse a linked list – iteratively and recursively
namespace LimkedList8
{
    public class Node
    {
        public Node next;
        public int data;

        public Node()
        {
            next = null;
        }

        public Node(int val)
        {
            data = val;
            next = null;
        }
    }

    public class MyLL
    {
        Node head;

        public MyLL()
        {
            head = null;
        }

        public static Node newHead;

        public Node AddHead(int val)
        {
            Node node = new Node(val);
            node.next = head;
            head = node;
            return head;
        }

        public void PrintAllNodes()
        {
            Node cur = head;
            while (cur.next != null)
            {
                Console.WriteLine(cur.data);
                cur = cur.next;
            }
            Console.WriteLine(cur.data);
            Console.WriteLine();
        }
    
        public Node ReverseIteratively()
        {
            Node cur = head;
            Node prev = null;
            while (cur != null)
            {
                head = cur.next;
                cur.next = prev;
                prev = cur;
                cur = head;
            }
            head = prev;
            return head;
        }

        public void ReverseRecurs(Node head)
        {
            if (head == null) return;
            if (head.next == null)
            {
                newHead = head;
                return;
            }

            ReverseRecurs(head.next);
            head.next.next = head;
            head.next = null;

        }

        public void PrintNodes()
        {
            Node cur = newHead;
            while (cur.next != null)
            {
                Console.WriteLine(cur.data);
                cur = cur.next;
            }
            Console.WriteLine(cur.data);
            Console.WriteLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyLL list = new MyLL();
            Node node = null;
            list.AddHead(3);
            list.AddHead(1);
            list.AddHead(4);
            list.AddHead(3);
            list.AddHead(2);
            list.AddHead(2);
            node = list.AddHead(8);
            list.PrintAllNodes();

            node = list.ReverseIteratively();
            list.PrintAllNodes();

            list.ReverseRecurs(node);
            list.PrintNodes();

        }
    }
}
