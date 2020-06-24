using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasses
{
    public class BooksClass<T> where T : Book
    {
        private T book;
        public T Book
        {
            get => book;
            set => book = value;
        }
    }
}
