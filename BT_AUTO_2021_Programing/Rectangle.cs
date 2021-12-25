using System;
using System.Collections.Generic;
using System.Text;
namespace BT_AUTO_2021_Programing
{
    class Rectangle : Shape
    {
        double length; // private is by default
        double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle()
        {

        }

        public double GetLength()
        {
            return length;
        }

        public void SetLenght(double length)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                Console.WriteLine("You cannot set a length to a negative number !!!");
            }
        }

        public void SetSize(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public virtual double GetArea()
        {
            return length * width;
        }

        public virtual double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public virtual double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));
        }

        public void PrintRectangle()
        {
            Console.WriteLine("The rectangle with length {0} and width {1} has area {2}", length, width, GetArea());
            Console.WriteLine("Area is {0} Perimeter is {1} Diagonal is {2}", GetArea(), GetPerimeter(), GetDiagonal());
        }

        public override string ToString()
        {
            return "This is a rectangle with " + width + " width and " + length + " length !!";
        }
    }
}
