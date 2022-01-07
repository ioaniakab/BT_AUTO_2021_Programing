﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class Shape : AbstractShape
    {

        ConsoleColor color;

        public override void Color()
        {
            Console.WriteLine("Drawing a shape");
        }


        public   override void Draw()
        {
            Console.WriteLine("We are drawing a shape!");
        }

       

        public virtual void Erase()
        {
            Console.WriteLine("You are erasing the shape!");
        }


        public ConsoleColor GetColor()
        {
            return color;
        }

        public void SetColor(ConsoleColor color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return "This is a generic shpae !!";
        }

    }
}
