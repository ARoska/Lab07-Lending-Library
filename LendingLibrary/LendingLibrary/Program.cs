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
        }

        static void LibraryInit()
        {
            Library<Book> library = new Library<Book>
            {
                new Book{"Ender's Game",false, Book.Genre.SciFi, }
            }
        }
    }
}
