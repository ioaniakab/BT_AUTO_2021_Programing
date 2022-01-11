using System;
using System.Collections.Generic;
using System.Text;

namespace BT_AUTO_2021_Programing
{
    class Author
    {
        string Name;
        string Email;

        public Author(string Name, string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }

        public Author()
        {

        }

        public string GetName(string Name)
        {
            return Name;
        }

        public void SetName(string Name)
        {
            if (Name != "" && Name != " ")
            {
                this.Name = Name;
            }
            else
            {
                Console.WriteLine("Please enter Author's name!!!");
            }
        }

        public string GetEmail(string Email)
        {
            return Email;
        }

        public void SetEmail(string Email)
        {
            if (Email != "" && Email != " ")
            {
                this.Email = Email;
            }
            else
            {
                Console.WriteLine("Please enter author's Email!!!");
            }
        }

        public void PrintAuthor()
        {
            Console.WriteLine("Author's name is " + Name);
        }

        // Correct code!!!!
        /*
          string name; 
        string email;

        public Author(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public string GetName()
        {
            return name;
        }

        public string GetEmail()
        {
            return email;
        }
         
         */
    }
}
