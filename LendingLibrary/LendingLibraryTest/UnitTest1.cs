using LendingLibrary.Classes;
using System;
using Xunit;

namespace LendingLibraryTest
{
    public class UnitTest1
    {
        [Fact]
        public void BooksCanBeAddedToTheLibrary()
        {
            Library<Book> library = new Library<Book>();

            library.Add(new Book("The Hive", "Orson Scott Card", 2, 2019, false));

            int actualTotal = library.Count();

            Assert.Equal(1, actualTotal);
        }

        [Fact]
        public void BooksCanBeRemovedFromTheLibrary()
        {
            Library<Book> library = new Library<Book>();
            Book book = new Book("The Hive", "Orson Scott Card", 2, 2019, false);

            library.Add(book);
            int actualTotalBefore = library.Count();

            Assert.Equal(1, actualTotalBefore);

            library.Remove(book);
            int actualTotalAfter = library.Count();

            Assert.Equal(0, actualTotalAfter);
        }

        [Fact]
        public void CannotBeRemovedIfTheyDontExist()
        {
            Library<Book> library = new Library<Book>();
            Book bookOne = new Book("The Hive", "Orson Scott Card", 2, 2019, false);
            Book bookTwo = new Book("Ender's Game", "Orson Scott Card", 2, 1985, true);

            library.Add(bookOne);
            int actualTotalBefore = library.Count();

            Assert.Equal(1, actualTotalBefore);

            library.Remove(bookTwo);
            int actualTotalAfter = library.Count();

            Assert.Equal(1, actualTotalAfter);
        }

        [Fact]
        public void CountInLibraryIsAccurate()
        {
            Library<Book> library = new Library<Book>();
            Book book1 = new Book("Ender's Game", "Orson Scott Card", 2, 1985, true);
            Book book2 = new Book("Speaker for the Dead", "Orson Scott Card", 2, 1986, false);
            Book book3 = new Book("Xenocide", "Orson Scott Card", 2, 1991, true);
            Book book4 = new Book("Children of the Mind", "Orson Scott Card", 2, 1996, true);
            Book book5 = new Book("Ender's Shadow", "Orson Scott Card", 2, 1999, false);

            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);
            library.Add(book5);
            library.Remove(book4);
            library.Remove(book2);

            int actualTotal = library.Count();

            Assert.Equal(3, actualTotal);
        }

        [Fact]
        public void CanGetSetBookTitle()
        {
            Book book = new Book("The Hive", "Orson Scott Card", 2, 2019, false);

            Assert.Equal("The Hive", book.Title);
        }

        [Fact]
        public void CanGetSetBookGenre()
        {
            Book book = new Book("The Hive", "Orson Scott Card", 2, 2019, false);

            int genre = (int)book.GetGenre;

            Assert.Equal(2, genre);
        }

        [Fact]
        public void CanGetSetBookReleaseDate()
        {
            Book book = new Book("The Hive", "Orson Scott Card", 2, 2019, false);

            Assert.Equal(2019, book.ReleaseDate);
        }

        [Fact]
        public void CanGetSetBookHardcoverBool()
        {
            Book book = new Book("The Hive", "Orson Scott Card", 2, 2019, false);

            Assert.False(book.Hardcover);
        }

        [Fact]
        public void CanGetSetAuthorName()
        {
            Author author = new Author("Orson Scott Card");

            Assert.Equal("Orson Scott Card", author.Name);
        }


        [Fact]
        public void CanGetSetAuthorNameInBook()
        {
            Book book = new Book("The Hive", "Orson Scott Card", 2, 2019, false);

            Assert.Equal("Orson Scott Card", book.Name);
        }

    }
}
