using System.Collections.Generic;

namespace LambdaExpression
{
    class BookStore
    {
        public readonly List<Book> Books = new List<Book>();
        public string Name { get; }
        public BookStore(string name)
        {
            this.Name = name;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddBook(List<Book> booksToAdd)
        {
            foreach (var book in booksToAdd)
            {
                AddBook(book);
            }
        }
    }
}