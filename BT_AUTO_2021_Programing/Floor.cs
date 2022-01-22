using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class Floor : AbstractBuilding
    {
        bool hasTerrase;
        public readonly Room[] rooms;

        public bool HasTerrase { get => hasTerrase; set => hasTerrase = value; }

        public Floor(Room[] rooms, bool hasTerrase)
        {
            this.rooms = rooms;
            this.hasTerrase = hasTerrase;
        }

        public override double ComputingArea()
        {
            double area = 0;
            foreach (Room room in rooms)
            {
                area += room.ComputingArea();
            }
            return area;
        }

        public override int TotalCapacity()
        {
            int capacity = 0;
            foreach (Room room in rooms)
            {
                capacity += room.Capacity;
            }
            return capacity;
        }

        public override int GetTotalNumberOfRooms()
        {
            int totalNumberOfRooms = 0;
            foreach (Room room in rooms)
            {
                totalNumberOfRooms += room.GetTotalNumberOfRooms();
            }
            return totalNumberOfRooms;
        }

        public void PrintFloor()
        {
            Console.WriteLine("The floor has {0} rooms, has an area of {1} mp and a capacity of {2} people", GetTotalNumberOfRooms(), ComputingArea(), TotalCapacity());
            if (hasTerrase)
            {
                Console.WriteLine("The floor has {0} rooms, has an area of {1} mp, a capacity of {2} people and has a terrase", GetTotalNumberOfRooms(), ComputingArea(), TotalCapacity());
            }
            Console.WriteLine("The rooms on this floor are: ");
            foreach (Room room in rooms)
            {
                room.PrintRoom();
            }
        }
    }
}
