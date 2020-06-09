using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LinkedListNode
{
    public class LinkedListN
    {
        private Node first;
        private int size;

        public LinkedListN()
        {
            first = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return first == null;
        }
        public int Size()
        {
            return size;
        }
        public void Add(int data)
        {
            Node aux = new Node(data);

            if (IsEmpty()) first = aux;
            else
            {
                if (first.data > data)
                {
                    aux.next = first;
                    first = aux;
                }
                else
                {
                    Node before = null, actual = first;
                    while (actual != null && data >= actual.data)
                    {
                        before = actual;
                        actual = actual.next;
                    }
                    before.next = aux;
                    aux.next = actual;
                }
            }
            size++;
        }

        public void Delete(int data)
        {
            if (first.data == data) first = first.next;
            else
            {
                Node before = null, actual = first;
                while (actual != null && data > actual.data)
                {
                    before = actual;
                    actual = actual.next;
                }
                if(data == actual.data)
                {
                    before.next = actual.next;
                }
            }
            size--;
        }

        public void DeleteFirst()
        {
            first = first.next;
            size--;
        }

        public void DeleteLast()
        {
            Node before = null, actual = first;
            while (actual.next != null)
            {
                before = actual;
                actual = actual.next;
            }
            before.next = null;
            size--;
        }

        public void DeleteByPosition(int position)
        {
            if (!(position == 0 || position > size))
            {
                Node before = null, actual = first;
                int actPosition = 1;
                while (actPosition!=position)
                {
                    before = actual;
                    actual = actual.next;
                    actPosition++;
                }
                before.next = actual.next;
                size--;
            }
            else Console.WriteLine("Invalid Position");
            
        }
        public Node Search(int data)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty");
                return null;
            }
            else
            {
                Node actual = first;
                while (actual != null && data > actual.data) actual = actual.next;
                if (actual != null && data == actual.data) return actual;
                else return null;

            }
        }

        public void Replace(int oldValue, int newValue)
        {
            //Node aux = Search(oldValue); if the list is not sorted
            //aux.data = newValue;
            Delete(oldValue); //In this way the list is always sorted (invariant)
            Add(newValue);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node aux = first;
            while (aux != null)
            {
                sb.Append(aux.data.ToString());
                aux = aux.next;
                if (aux != null) sb.Append(" -> ");
            }
            return sb.ToString();
        }
    }
}
