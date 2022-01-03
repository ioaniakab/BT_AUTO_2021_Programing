using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class Library:Book 
    {
        public Library(string bookName, double price, string Name, int year)
        {
            this.SetbookName(bookName);
            this.SetPrice(price);
            this.SetName(Name);
            this.SetYear(year);
        }

        public Library()
        {

        }

        public void PrintLibrary()
        {
            base.PrintBook();
            base.PrintAuthor();
            base.PrintBook2();
            
        }

    }
}
