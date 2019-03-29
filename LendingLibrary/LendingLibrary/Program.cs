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
            Console.WriteLine("Hello World!");
            LibraryInit();
        }

        static void LibraryInit()
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
        }

        static void Borrow(Library<Book> library)
        {
            List<Book> checkedOut = new List<Book>();
            List<Book> available = new List<Book>();
            int counter = 1;

            foreach (Book book in library)
            {
                Console.WriteLine("Books in the Library:\n" +
                    "=======================\n" +
                    $"Title: {book.Title}, Author: {book.Name}, Genre: {book.GetGenre}, \n" +
                    $"Release Date: {book.ReleaseDate}, Is it a hardcover: {book.Hardcover}\n" +
                    "=======================");
                if ((counter % 3) == 0)
                {
                    library.Remove(book);
                    checkedOut.Add(book);
                }
                counter++;
            }

        }
    }
}
