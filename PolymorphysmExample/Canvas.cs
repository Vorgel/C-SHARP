using System.Collections.Generic;

namespace Polymorphysm_Example
{
    class Canvas
    {
        private List<Shapes> _ListOfShapes = new List<Shapes>();

        public void AddNewShape(Shapes shape)
        {
            _ListOfShapes.Add(shape);
        }
        public void DrawAllShapes()
        {
            foreach (var shape in _ListOfShapes )
            {
                shape.Draw();
            }
        }
    }
}
