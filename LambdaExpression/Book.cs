using System;

namespace LambdaExpression
{
    class Book
    {
        public string Title { get; }
        public int Price { get; }
        public Book(string title, int price)
        {
            this.Price = price;
            this.Title = title;
        }

        public void Print()
        {
            Console.WriteLine("Title: " + Title +", price: " + Price);
        }
    }
}