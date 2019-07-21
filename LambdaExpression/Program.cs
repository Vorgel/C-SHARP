using System;
using System.Collections.Generic;

namespace LambdaExpression
{
    class Program
    { 
        static void Main(string[] args)
        {
            BookStore empik = new BookStore("Empik");
            
            List<Book> books = new List<Book>
            {
                    new Book("Krzyzacy", 30),
                    new Book("Jas i Malgosia", 35),
                    new Book("Kubus Puchatek", 40)
            };

            empik.AddBook(books);
            empik.AddBook(new Book("Kaczor Dolan", 3000));

            var cheapBooks = empik.Books.FindAll(b => b.Price >= 35);

            PrintList(cheapBooks);

            Console.ReadKey();
        }

        static void PrintList(List<Book> books)
        {
            foreach (var book in books)
            {
                book.Print();
            }
        }
    }
}
