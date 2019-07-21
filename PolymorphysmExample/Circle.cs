namespace Polymorphysm_Example
{
    partial class Program
    {
        private class Circle : Shapes 
        {
            public Circle()
            {
                _type = Type.Circle;
            }

            public override void Draw()
            {
                System.Console.WriteLine("Drawing a Circle");
                base.Draw();
            }
        }
    }
}
