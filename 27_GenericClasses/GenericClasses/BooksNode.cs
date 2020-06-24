using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasses
{
    class BooksNode<T> where T : Book
    {
        private class Node<V>
        {
            public V value;
            public Node<V> next;

            public Node(V value)
            {
                this.value = value;
                this.next = null;
            }

            public override string ToString()
            {
                return value.ToString();
            }

        }

        private Node<T> first;
        public int size;

        public BooksNode()
        {
            first = null;
            size = 0;
        }
        public bool IsEmpty() { return first == null; }
        
        public void Add(T value)
        {
            var aux = new Node<T>(value);
            if (IsEmpty()) first = aux;
            else
            {
                aux.next = first;
                first = aux;
            }
            size++;
        }

        public T SearchByIndex(int index)
        {
            Node<T> aux = first;
            int i = size-1;
            while (i>=0 && i != index)
            {
                i--;
                aux = aux.next;
            }
            return aux==null?null:aux.value;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Book List: ");
            Node<T> aux = first;
            while(aux != null)
            {
                sb.Append(aux.ToString());
                aux = aux.next;
                if (aux != null) sb.Append(" -> ");
                
            }
            return sb.ToString();
        }
    }
}
