using LendingLibrary.Classes;
using System.Collections;
using System.Collections.Generic;
using System;

namespace LendingLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library<Book> library = LibraryInit();
            Borrow(library);
        }

        static Library<Book> LibraryInit()
        {
            Library<Book> library = new Library<Book>
            {
                new Book("Ender's Game", "Orson Scott Card", 2, 1985, true),
                new Book("Speaker for the Dead", "Orson Scott Card", 2, 1986, false),
                new Book("Xenocide", "Orson Scott Card", 2, 1991,  true),
                new Book("Children of the Mind", "Orson Scott Card", 2, 1996, true),
                new Book("Ender's Shadow", "Orson Scott Card", 2, 1999, false),
                new Book("Shadow of the Hegemon", "Orson Scott Card", 2, 2001, false),
                new Book("Shadow Puppets", "Orson Scott Card", 2, 2002, true),
                new Book("Shadow of the Giant", "Orson Scott Card", 2, 2005, false),
                new Book("A War of Gifts: An Ender Story", "Orson Scott Card", 2, 2007, false),
                new Book("Ender in Exile", "Orson Scott Card", 2, 2008, false),
                new Book("Shadows in Flight", "Orson Scott Card", 2, 2012, false),
                new Book("Earth Unaware", "Orson Scott Card & Aaron Johnston", 2, 2012, false),
                new Book("Earth Afire", "Orson Scott Card & Aaron Johnston", 2, 2013, false),
                new Book("Earth Awakens", "Orson Scott Card & Aaron Johnston", 2, 2014, false),
                new Book("The Swarm", "Aaron Johnston", 2, 2016, false),
                new Book("Children of the Fleet", "Orson Scott Card", 2, 2017, false)
             };

            return library;
        }

        static void Borrow(Library<Book> library)
        {
            List<Book> checkedOut = new List<Book>();
            List<Book> available = new List<Book>();
            int counter = 0;

            Console.WriteLine($"There are {library.Count()} books in the Library:\n" +
                "=======================");
            foreach (Book book in library)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Name}, Genre: {book.GetGenre}, \n" +
                    $"Release Date: {book.ReleaseDate}, Hardcover: {book.Hardcover}\n");
                if ((counter % 3) == 0)
                {
                    checkedOut.Add(book);
                }
                else
                {
                    available.Add(book);
                }

                counter++;
            }
            Console.WriteLine("=======================\n" +
                "\n" +
                $"{checkedOut.Count} books are checked out:\n" +
                "=======================");

            foreach (Book book in checkedOut)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Name}, Genre: {book.GetGenre}, \n" +
                    $"Release Date: {book.ReleaseDate}, Hardcover: {book.Hardcover}\n");
                if (library.IsAvailable(book))
                {
                    library.Remove(book);
                }
            }
            Console.WriteLine("=======================\n" +
                "\n" +
                $"{available.Count} books are still available for checkout out:\n" +
                "=======================");

            foreach (Book book in available)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Name}, Genre: {book.GetGenre}, \n" +
                    $"Release Date: {book.ReleaseDate}, Hardcover: {book.Hardcover}\n");
                if (library.IsAvailable(book))
                {
                    library.Remove(book);
                }
            }
            Console.WriteLine("=======================\n" +
                "\n" +
                $"{library.Count()} books remain in the Library.");
        }
    }
}
