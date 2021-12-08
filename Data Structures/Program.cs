using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoublyLinkedList;
using BinarySearchTree;


namespace Data_Structures
{
    class Program
    {
        static void LinkedList()
        {
            LinkedList linkedList = new LinkedList();

            linkedList.InsertFront(50);
            linkedList.InsertFront(20);
            linkedList.InsertFront(30);
            linkedList.InsertBack(150);
            linkedList.InsertBack(24);

            foreach (DoublyLinkedList.Node item in linkedList)
            {
                Console.WriteLine(item.ToString() + " ");
            }

            linkedList.DeleteFront();
            linkedList.DeleteBack();

            Console.WriteLine("");

            foreach (DoublyLinkedList.Node item in linkedList)
            {
                Console.WriteLine(item.ToString() + " ");
            }

            linkedList.InsertBack(44);
            linkedList.InsertBack(47);

            Console.WriteLine("");

            foreach (DoublyLinkedList.Node item in linkedList)
            {
                Console.WriteLine(item.ToString() + " ");
            }

            linkedList.FreeDelete(150);

            Console.WriteLine("");

            foreach (DoublyLinkedList.Node item in linkedList)
            {
                Console.WriteLine(item.ToString() + " ");
            }
        }

        static void BinarySearch()
        {
            BST bst = new BST();

            bst.Insert(46);
            bst.Insert(30);
            bst.Insert(5);
            bst.Insert(36);
            bst.Insert(32);
            bst.Insert(83);
            bst.Insert(50);
            bst.Insert(87);

            Console.WriteLine("The BST Created with input data PreOrder(Root-Left-Right):");
            bst.PreOrder();

            Console.WriteLine("");

            Console.WriteLine("The BST Created with input data InOrder(Left-Root-Right):");
            bst.InOrder();

            Console.WriteLine("");

            Console.WriteLine("The BST Created with input data PostOrder(Left-Right-Root):");
            bst.PostOrder();
        }

        static class LatihanUTS
        {
            static int MyMethod12(int a, int b)
            {
                if (b == 0) return a;

                return MyMethod12(b, (a % b));
            }

            static int MyMethod15(int a, int b)
            {
                if (b == 1) return a;

                return a * MyMethod(a, b - 1);
            }

            static int MyMethod(int a, int b)
            {
                if (b == 0) return a;

                return MyMethod(b, (a % b));
            }
        }
        static void Main(string[] args)
        {
            try
            {
                BinarySearch();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
