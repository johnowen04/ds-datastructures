using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class LinkedList : IEnumerable<Node>
    {
        private Node head;

        public Node Head { get => head; set => head = value; }

        public LinkedList()
        {
            Head = null;
        }

        public IEnumerator<Node> GetEnumerator()
        {
            Node current = Head;
            while(current != null)
            {
                yield return current;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public LinkedList(int data)
        {
            Head = new Node(data);
        }

        public void InsertFront(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = head;
                Head.Previous = newNode;
                Head = newNode;
            }
        }

        public void InsertBack(int data)
        {
            Node newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;

                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
                current.Next.Previous = current;
            }
        }

        public bool DeleteFront()
        {
            Node current = Head;

            if (current == null)
            {
                return false;
            }
            else
            {
                Head = current.Next;
                Head.Previous = null;
                current = null;
                return true;
            }
        }

        public bool DeleteBack()
        {
            Node current = Head;

            if (current == null)
            {
                return false;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Previous.Next = null;
                current = null;

                return true;
            }
        }

        public bool FreeDelete(int data)
        {
            Node current = Head;

            while (current.Next != null)
            {
                if (current.Data == data)
                {
                    if (current.Previous == null)
                    {
                        current.Next.Previous = null;
                    }
                    else
                    {
                        current.Previous.Next = current.Next;
                    }

                    if (current.Next == null)
                    {
                        current.Previous.Next = null;
                    }
                    else
                    {
                        current.Next.Previous = current.Previous;
                    }

                    current = null;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }
    }
}
