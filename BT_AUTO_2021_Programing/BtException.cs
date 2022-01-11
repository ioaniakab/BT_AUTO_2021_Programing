﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class BtException : Exception
    {
        string myCustomMessage;
        public BtException(string message)
        {
            this.myCustomMessage = "BT EXCEPTION: " + message;
        }

        public BtException() : base("BT EXCEPTION: ")
        {

        }

        public override string ToString()
        {
            return myCustomMessage + base.ToString();
        }
    }
}
