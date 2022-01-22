using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class BldException : Exception
    {
        string myCustomErrorMesage;

        public BldException(string message)
        {
            this.myCustomErrorMesage += message;
        }

        public override string ToString()
        {
            return myCustomErrorMesage + base.ToString();
        }
    }
}
