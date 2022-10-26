using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5CSharp.Task3
{
    internal class Rectangle : Figure
    {
       
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double Area()
        {
            return _width * _height;
        }

        public override double Perimeter()
        {
            return 2 * (_width + _height);
        }

        public override void Print()
        {
            Console.WriteLine("Rectangle:");
            Console.WriteLine("Width: " + _width);
            Console.WriteLine("Height: " + _height);
            Console.WriteLine("Area: " + Area());
            Console.WriteLine("Perimeter: " + Perimeter());
        }
    }
}
