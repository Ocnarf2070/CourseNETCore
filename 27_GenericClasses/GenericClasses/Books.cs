using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasses
{
    public class Books<T>
    {
        private T book;
        public T Book
        {
            get => book;
            set => book = value;
        }
    }
}
