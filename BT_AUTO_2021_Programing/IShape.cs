﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    interface IShape
    {
        void Draw();
        void Color();


        //This is valid only for C# >= v. 8.0
        void State()
        {
            Console.WriteLine("State of the Shape");
        }


    }
}
