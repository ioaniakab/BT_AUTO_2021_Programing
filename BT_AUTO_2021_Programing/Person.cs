﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class Person
    {
        string name;
        char sex;
        string[] nationality;
        bool isHungry;
        DateTime dob;

        public void Eat()
        {
            Console.WriteLine("The person is eating ......");
            isHungry = true;
        }

        public void Running ()
        {
            Console.WriteLine("The person is running for his health!");
            isHungry = true;
        }

        public void SetName(string personName)
        {
            name = personName;
        }

        public void SetSex(Char personSex)
        {
            sex = personSex;
        }
        public void PrintPerson()
        {
            Console.WriteLine("Name of the person is {0}", name);
            Console.WriteLine("-> Current state for hungry is {0}", isHungry);
            Console.WriteLine("-> Person sex is {0}", sex);
        }
    }
}
