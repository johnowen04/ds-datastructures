using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BST
    {
        private Node root;

        public Node Root { get => root; set => root = value; }

        public BST()
        {
            Root = null;
        }

        public BST(Node root)
        {
            Root = root;
        }

        private int MinValue(Node root)
        {
            int minVal = root.Data;

            if(root.Left != null)
            {
                minVal = root.Left.Data;
                root = root.Left;
            }

            return minVal;
        }

        public void Insert(int data)
        {
            Root = InsertNode(Root, data);
        }

        private Node InsertNode(Node root, int data)
        {
            if (root == null)
                return new Node(data);

            if (data < root.Data)
                root.Left = InsertNode(root.Left, data);
            else if (data > root.Data)
                root.Right = InsertNode(root.Right, data);

            return root;
        }

        public void Delete(int data)
        {
            Root = DeleteNode(Root, data);
        }

        private Node DeleteNode(Node root, int data)
        {
            if (root == null)
                return root;

            if (data < root.Data)
                root.Left = DeleteNode(root.Left, data);
            else if (data > root.Data)
                root.Right = DeleteNode(root.Right, data);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Data = MinValue(root.Right);
                root.Right = DeleteNode(root.Right, root.Data);
            }

            return root;
        }

        public void InOrder()
        {
            InOrderRecursive(Root);
        }

        private void InOrderRecursive(Node root)
        {
            if (root != null)
            {
                InOrderRecursive(root.Left);
                Console.WriteLine(root.Data + " ");
                InOrderRecursive(root.Right);
            }
        }

        public void PreOrder()
        {
            PreOrderRecursive(Root);
        }

        private void PreOrderRecursive(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Data + " ");
                PreOrderRecursive(root.Left);
                PreOrderRecursive(root.Right);
            }    
        }

        public void PostOrder()
        {
            PostOrderRecursive(Root);
        }

        private void PostOrderRecursive(Node root)
        {
            if (root != null)
            {
                PostOrderRecursive(root.Left);
                PostOrderRecursive(root.Right);
                Console.WriteLine(root.Data + " ");
            }
        }
    }
}
