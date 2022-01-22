using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    abstract class AbstractBuilding : IBuilding
    {
        public virtual double ComputingArea()
        {
            return 0;
        }

        public virtual int GetNumberOfFloors()
        {
            return 0;
        }

        public virtual int GetTotalNumberOfRooms()
        {
            return 0;
        }
        public virtual int TotalCapacity()
        {
            return 0;
        }

    }
}
