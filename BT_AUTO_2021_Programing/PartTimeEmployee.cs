﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string firstName, string lastName, string adress, string city, string country, double salary) : base(firstName, lastName, adress, city, country, salary*0.75)
        {

        }
    }
}
