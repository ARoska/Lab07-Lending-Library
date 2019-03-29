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
                new Book("Ender's Game", "Orson Scott Card", "SciFi", 1985, false),
                new Book("Speaker for the Dead", "Orson Scott Card", "SciFi", 1986, false),
                new Book("Xenocide", "Orson Scott Card", "SciFi", 1991,  false),
                new Book("Children of the Mind", "Orson Scott Card", "SciFi", 1996, false),
                new Book("Ender's Shadow", "Orson Scott Card", "SciFi", 1999, false),
                new Book("Shadow of the Hegemon", "Orson Scott Card", "SciFi", 2001, false),
                new Book("Shadow Puppets", "Orson Scott Card", "SciFi", 2002, false),
                new Book("Shadow of the Giant", "Orson Scott Card", "SciFi", 2005, false),
                new Book("A War of Gifts: An Ender Story", "Orson Scott Card", "SciFi", 2007, false),
                new Book("Ender in Exile", "Orson Scott Card", "SciFi", 2008, false),
                new Book("Shadows in Flight", "Orson Scott Card", "SciFi", 2012, false),
                new Book("Earth Unaware", "Orson Scott Card & Aaron Johnston", "SciFi", 2012, false),
                new Book("Earth Afire", "Orson Scott Card & Aaron Johnston", "SciFi", 2013, false),
                new Book("Earth Awakens", "Orson Scott Card & Aaron Johnston", "SciFi", 2014, false),
                new Book("The Swarm", "Aaron Johnston", "SciFi", 2016, false),
                new Book("Children of the Fleet", "Orson Scott Card", "SciFi", 2017, false)
             };

            foreach (Book book in library)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Name}, Genre: {book.GetGenre}");

            }
        }
    }
}
