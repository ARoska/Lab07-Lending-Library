using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public bool Hardcover { get; set; }

        public enum Genre
        {
            NonFiction,
            SciFi,
            Fantasy,
            Comedy,
            Romance,
            Drama
        }

        public Genre GetGenre { get; set; }

        public Book(string title, Author authorInfo, bool hardcover, Genre genreInfo)
        {
            Title = title;
            Author author = authorInfo;
            Hardcover = hardcover;
            Genre genre = genreInfo;
        }
    }
}
