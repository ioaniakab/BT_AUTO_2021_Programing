using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    interface IBuilding
    {
        public double ComputingArea();
        public int GetNumberOfFloors();
        public int GetTotalNumberOfRooms();
        public int TotalCapacity();

    }
}
