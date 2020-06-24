using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClasses
{
    public class Book
    {
        public int ID { get; set; }
        public String Title { get; set; }

        public override string ToString()
        {
            return $"({ID}, {Title})";
        }
    }
}
