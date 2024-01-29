using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Porter", "JK RowLing", 480);

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }

            //classes are for creating complex data type, eg a book can have a title,
            //and pages which are different  data types combined

                class Book
        {
            public string title;
            public string author;
            public int pages;

            //this method below is called  a constructor, it is called by default when a book 
            public Book(String aTitle, String aAuthor, int aPages);
             
    
        }




        }
    }

