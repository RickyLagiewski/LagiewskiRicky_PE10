using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myCustomBook = new Book("Memes 101", "Ricky",420, "ME");

            string choice = "";

            while (choice != "done")
            {
                Console.WriteLine("Type 'title', 'author', 'pages', 'borrow', 'read', 'print', 'done'\n");
                choice = Console.ReadLine();
                Console.WriteLine("");

                if (choice == "title")
                {
                    myCustomBook.BookTitle();
                    Console.WriteLine("");
                }
                if (choice == "author")
                {
                    myCustomBook.BookAuthor();
                    Console.WriteLine("");
                }
                if (choice == "pages")
                {
                    myCustomBook.BookPages();
                    Console.WriteLine("");
                }
                if (choice == "borrow")
                {
                    myCustomBook.BookOwner();
                    Console.WriteLine("");
                }
                if (choice == "read")
                {
                    myCustomBook.ReadBook();
                    Console.WriteLine("");
                }
                if (choice == "print")
                {
                    myCustomBook.PrintBook();
                    Console.WriteLine("");
                }
            }
        }
    }
}
