using System;

namespace MethodOverRiding
{
    public class Circle : Shape


    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Tringle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Tringle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
       

        public virtual void Draw()
        {

        }
    }

} 

