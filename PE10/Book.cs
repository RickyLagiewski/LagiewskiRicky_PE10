using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE10
{
    class Book
    {
        private string title;
        private string author;
        private int numberOfPages;
        private string owner;
        private int numberOfTimesRead;
        

        // parameterized constructor
        public Book(string p_title, string p_author, int p_numberOfPages, string p_owner)
        {
            title = p_title;
            author = p_author;
            numberOfPages = p_numberOfPages;
            owner = p_owner;
            numberOfTimesRead = 0;
        }
        public string GetOwner()
        {
            return owner;
        }
        public int NumberOfTimes()
        {
            return numberOfTimesRead;
        }
        public void SetNumberOfTimes(int value)
        {
            if (value >= numberOfTimesRead)
            {
                numberOfTimesRead = value;
            }
        }
        public void BookTitle()
        {
            Console.WriteLine(title);
        }
        public void BookAuthor()
        {
            Console.WriteLine(author);
        }
        public void BookPages()
        {
            Console.WriteLine(numberOfPages);
        }
        public void BookOwner()
        {
            Console.WriteLine("Who is the new owner?");
            owner = Console.ReadLine();
        }
        public void ReadBook()
        {
            numberOfTimesRead++;
            Console.WriteLine(numberOfTimesRead);
        }
        public void PrintBook()
        {
            Console.WriteLine("\n Title: " + title);
            Console.WriteLine("\n Author: " + author);
            Console.WriteLine("\n Number of Pages: " + numberOfPages);
            Console.WriteLine("\n Owner: " + owner);
            Console.WriteLine("\n Number of Times Read: " + numberOfTimesRead);
        }
    }
}
