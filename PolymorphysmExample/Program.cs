using System;


namespace Polymorphysm_Example
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            Triangle triangle = new Triangle();
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            canvas.AddNewShape(triangle);
            canvas.AddNewShape(circle);
            canvas.AddNewShape(rectangle);

            canvas.DrawAllShapes();

            Console.ReadKey();
        }
    }
}
