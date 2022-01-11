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


        // Correct code!!!
        /*
        public static void LibraryExample()
        {
            Author author1 = new Author("Lev Tolstoi", "lev.tolstoi@email.com");
            Book book1 = new Book("Anna Karenina", 2007, author1, 30.35);
            Author author2 = new Author("Jules Verne", "jules.vernes@email.com");
            Book book2= new Book("Around the World in Eighty Days", 2000, author2, 22.16);
            Book book3 = new Book("20,000 Leagues Under the Sea", 2001, author2, 25.78);

            book1.PrintBook();
            book2.PrintBook();
            book3.PrintBook();
        }

        */

    }
}
