using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    
    class Building : AbstractBuilding
    {
        const int MAX_CAPACITY = 300;
        int numberOfElevators;
        private readonly Floor[] floors;

        public int NumberOfElevators { get => numberOfElevators; set => numberOfElevators = value; }

        public Building(Floor[] floors, int numberOfElevators)
        {
            this.NumberOfElevators = numberOfElevators;
            this.floors = floors;
            if (this.TotalCapacity() > MAX_CAPACITY)
            {
                throw new BldException("The maximum capacity of the building is exceded!!!");
            }
        }
        public override double ComputingArea()
        {
            double area = 0;
            foreach (Floor floor in floors)
            {
                area += floor.ComputingArea();
            }
            return area;
        }

        public override int GetNumberOfFloors()
        {
            int totalNumberOfFloors = 0;
            foreach (Floor floor in floors)
            {
                totalNumberOfFloors += floor.GetNumberOfFloors();
            }
            return totalNumberOfFloors;
        }

        public override int GetTotalNumberOfRooms()
        {
            int totalNumberOfRooms = 0;
            foreach (Floor floor in floors)
            {
                totalNumberOfRooms += floor.GetTotalNumberOfRooms();
            }
            return totalNumberOfRooms;
        }

        public override int TotalCapacity()
        {
            int capacity = 0;
            foreach (Floor floor in floors)
            {
                capacity += floor.TotalCapacity();
            }
            return capacity;
        }


        public static void PrintBuilding(Building b)
        {
            Console.WriteLine("Building has {0} floors, {1} mp total area, a total capacity of {3} persons, a total of {4} floors and a number of {5} elevators", b.GetNumberOfFloors(), b.ComputingArea(), b.TotalCapacity(), b.GetNumberOfFloors(), b.numberOfElevators);
            foreach (Floor floor in b.floors)
            {
                floor.PrintFloor();
            }
        }

    }
}
