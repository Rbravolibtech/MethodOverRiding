using System;
using System.Collections.Generic;

namespace MethodOverRiding
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes) //method that recives types of shapes
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
 