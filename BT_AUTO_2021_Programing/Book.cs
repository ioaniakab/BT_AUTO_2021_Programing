using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class Book : Author
    {
        string bookName;
        int year;
        double price;

        public Book(string bookName, int year, string Name, double price)
        {
            this.bookName = bookName;
            this.year = year;
            this.price = price;
            this.SetName(Name);
        }

        public Book()
        {

        }

        public string GetbookName(string bookName)
        {
            return bookName;
        }

        public void SetbookName(string bookName)
        {
            if (bookName != "" && bookName != " ")
            {
                this.bookName = bookName;
            }
            else
            {
                Console.WriteLine("Please enter book's name!!!");
            }
        }

        public int Getyear(int year)
        {
            return year;
        }

        public void SetYear(int year)
        {
            if(year > 0)
            {
                this.year = year;
            }
            else
            {
                Console.WriteLine("Please entere the year of book first publishing!!!");
            }
        }

        public double GetPrice(double price)
        {
            return price;
        }

        public void SetPrice(double price)
        {
            if(price > 0)
            {
                this.price = price;
            }
            else
            {
                Console.WriteLine("The book price cannot be negative!!!");
            }
        }

        
        public void PrintBook()
        {
            Console.WriteLine("Book's name is {0} with a price of {1} $", bookName, price);
                                  
        }

        public void PrintBook2()
        {
            Console.WriteLine("The book was published in " + year);
           
        }

    }
}
