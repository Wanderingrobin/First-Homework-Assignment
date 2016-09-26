using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_One_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello World";
            Console.WriteLine(myString);

            string newString = "Columbus Sailed the world in";
            int newInterger = 1492;
            string newerString = newInterger.ToString();
            Console.WriteLine(newString + " " + newerString);


            bool dogBool = false;
            string dogString = "It is " + dogBool + " that I have a dog at home.";
            Console.WriteLine(dogString);

            DateTime myDate = DateTime.Now;
            string dateString = "Today is" + " ";
            Console.WriteLine(dateString + myDate);

            decimal burgervalue = 5.45m;
            Console.WriteLine("I spent {0:C2} on a cheeseburger.", burgervalue);

            var treasurevariable = "X";
            string pirateString = treasurevariable + " marks the spot";
            Console.WriteLine(pirateString);

            dynamic myBookArray = new[]
            {
                new { bookTitle = "To Kill A Mockingbird", bookAuthor = "Harper Lee", bookGenre = "Coming of Age", bookYear = "1960" },
                new { bookTitle = "The Silence of Six", bookAuthor = "E.C. Myers", bookGenre = "Triller", bookYear = "2014" },
                new { bookTitle = "Dark Matter", bookAuthor = "Blake Crouch", bookGenre = "Speculative fiction", bookYear = "2016" },
                new { bookTitle = "Feed", bookAuthor = "Mira Grant", bookGenre = "Politcal Science Fiction Thriller", bookYear = "2010" }
            };


            Console.WriteLine(myBookArray[2].bookTitle + ", " + myBookArray[2].bookAuthor + ", " + myBookArray[2].bookGenre + ", " + myBookArray[2].bookYear);

            Console.ReadLine();


        }
    }
}

