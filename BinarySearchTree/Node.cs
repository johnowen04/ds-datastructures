﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        private int data;
        private Node left, right;

        public int Data { get => data; set => data = value; }
        public Node Left { get => left; set => left = value; }
        public Node Right { get => right; set => right = value; }

        public Node(int data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}
