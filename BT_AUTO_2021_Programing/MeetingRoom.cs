using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class MeetingRoom : Room
    {
        int numberOfTables;
        bool hasTV;
        public bool HasTV { get => hasTV; set => hasTV = value; }
        public int NumberOfTables { get => numberOfTables; set => numberOfTables = value; }

        public MeetingRoom(double width, double lenght, int capacity, int numberOfTables, bool hasTV) : base(width, lenght, capacity)
        {

            this.NumberOfTables = numberOfTables;
            this.hasTV = hasTV;
        }



        public override void PrintRoom()
        {
            Console.WriteLine("This meetingroom has {0} mp, a capacity of {1} people and {2} number of tables", ComputingArea(), Capacity, numberOfTables);
            if (hasTV)
            {
                Console.WriteLine("This meetingroom has {0} mp, a capacity of {1} people, {2} number of tables and has a TV", ComputingArea(), Capacity, numberOfTables);
            }
        }
    }
}
