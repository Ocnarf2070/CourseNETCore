using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListNode
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
        public override string ToString()
        {
            return data.ToString();
        }
    }
}
