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

        public Book(string title, bool hardcover, Genre genreInfo, Author authorInfo)
        {
            Title = title;
            Hardcover = hardcover;
            Genre genre = genreInfo;
            Author author = authorInfo;
        }
    }
}
