using System;

namespace Polymorphysm_Example
{
    class Triangle : Shapes
    {
        public Triangle()
        {
            _type = Type.Triangle;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle");
            base.Draw();
        }
    }
}
