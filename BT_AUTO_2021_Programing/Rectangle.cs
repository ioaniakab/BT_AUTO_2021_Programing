using System;
using System.Collections.Generic;
using System.Text;
namespace BT_AUTO_2021_Programing
{
    class Rectangle : Shape
    {
        double lenght;
        double width;

        public void SetSize(double lenght, double width)
        {
            this.lenght = lenght;
            this.width = width;
        }
        
        public double GetArea()
        {
            return lenght * width;
        }

        /* public void PrintRectangle()
         {
             Console.WriteLine("Rectangles area is {0}", GetArea);
         }
        */

        public override string ToString()
        {
            return "This is a rectangle with " + width + "widht and " + lenght + " lenght !!";
        }

    }
}
