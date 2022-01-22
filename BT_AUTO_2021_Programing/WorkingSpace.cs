using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class WorkingSpace : Room
    {

        bool hasLibrary;

        public WorkingSpace(double width, double lenght, int capacity, bool hasLibrary) : base(width, lenght, capacity)
        {
            this.hasLibrary = hasLibrary;
        }

        public bool HasLibrary { get => hasLibrary; set => hasLibrary = value; }


        public override void PrintRoom()
        {
            Console.WriteLine("The working space has {0} mp and capacity of {1} people", ComputingArea(), Capacity);
            if (hasLibrary)
            {
                Console.WriteLine("The working space has {0} mp, a capacity of {1} people and has a library full of books", ComputingArea(), Capacity);
            }
        }

    }
}
