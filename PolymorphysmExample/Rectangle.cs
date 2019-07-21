namespace Polymorphysm_Example
{
    partial class Program
    {
        class Rectangle : Shapes
        {
            public Rectangle()
            {
                _type = Type.Rectangle;
            }

            public override void Draw()
            {
                System.Console.WriteLine("Drawing a Rectangle");
                base.Draw();
            }
        }
    }
}
