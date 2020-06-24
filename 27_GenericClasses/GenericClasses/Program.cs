using System;

namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            var book = new Books<String>();
            book.Book = "Celestina";
            Console.WriteLine($"Book1: {book.Book}, Type: {book.Book.GetType()}");
            var book2 = new Books<int>();
            book2.Book = 52;
            Console.WriteLine($"Book2: {book2.Book}, Type: {book2.Book.GetType()}");

            Console.WriteLine("\nPart 2");
            //var book3 = new Books2<String>();
            //var book3 = new Books2<int>(); because it is defined the T type, it is not possible to use another type
            var book3 = new BooksClass<Book>();// Only can be used by Book type 
            var book4 = new BooksClass<Class1>();//and its childs
            book3.Book = new Book
            {
                ID = 1,
                Title = "Quijote"
            };
            Console.WriteLine($"Book3\nID: {book3.Book.ID}, Title: {book3.Book.Title}");

            Console.WriteLine("\nPart 3");
            var listBook = new BooksNode<Book>();
            listBook.Add(new Book
            {
                ID = 1,
                Title = "El Quijote"
            });
            listBook.Add(new Book
            {
                ID = 2,
                Title = "Los girasoles muertos"
            });
            listBook.Add(new Book
            {
                ID = 10,
                Title = "Luces de Bohemia"
            });
            listBook.Add(new Book
            {
                ID = 3,
                Title = "El arbol de la ciencia"
            });
            listBook.Add(new Book
            {
                ID = 4,
                Title = "Celestina"
            });
            Console.WriteLine(listBook);

            Console.WriteLine("\nPart 4");
            for(int index=0; index<listBook.size; index++)
            {
                Console.WriteLine("Title by index {0}: {1}", index, listBook.SearchByIndex(index));

            }





        }
    }
}
