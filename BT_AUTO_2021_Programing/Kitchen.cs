using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class Kitchen : Room
    {
        int numberOfChairs;
        bool hasOven;
        string wallsColour;

        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        public bool HasOven { get => hasOven; set => hasOven = value; }
        public string WallsColour { get => wallsColour; set => wallsColour = value; }

        public Kitchen(double width, double lenght, int capacity, int numberOfChairs, bool hasOven, string wallsColour) : base(width, lenght, capacity)
        {
            this.NumberOfChairs = numberOfChairs;
            this.HasOven = hasOven;
            this.WallsColour = wallsColour;
        }


        public override void PrintRoom()
        {
            Console.WriteLine("The kitchen has an area of {0} mp, a capacity of {1} people, the walls are painted in {2} and {3} number of chairs", ComputingArea(), Capacity, wallsColour, numberOfChairs);
            if (hasOven)
            {
                Console.WriteLine("The kitchen has an area of {0} mp, a capacity of {1} people, the walls are painted in {2}, {3} number of chairs and has an oven", ComputingArea(), Capacity, wallsColour, numberOfChairs);

            }
        }
    }
}
