using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Node
    {
        private int data;
        private Node next;
        private Node previous;

        public int Data { get => data; set => data = value; }
        public Node Next { get => next; set => next = value; }
        public Node Previous { get => previous; set => previous = value; }

        public Node(int data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
