using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class DepositSpace : Room
    {
        public DepositSpace(double width, double lenght, int capacity) : base(width, lenght, capacity)
        {
        }

        public override void PrintRoom()
        {
            Console.WriteLine("The deposit space has {0} mp and a capacity of {1} people", ComputingArea(), Capacity);
        }
    }
}
