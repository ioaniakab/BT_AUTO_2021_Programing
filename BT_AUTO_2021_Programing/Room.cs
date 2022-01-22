using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class Room : AbstractBuilding
    {
        double lenght, width;
        int capacity;

        public double Lenght { get => lenght; set => lenght = value; }
        public double Width { get => width; set => width = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public Room(double width, double lenght, int capacity)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Capacity = capacity;
        }



        public override double ComputingArea()
        {
            return Lenght * Width;
        }

        public virtual void PrintRoom()
        {
            Console.WriteLine("The room has an area of {0} and a capacity of {1} peope", ComputingArea(), Capacity);
        }
    }
}
