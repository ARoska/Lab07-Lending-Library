using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Book : Author
    {
        public string Title { get; set; }
        public int ReleaseDate { get; set; }
        public bool Hardcover { get; set; }

        public Genre GetGenre { get; set; }

        public Book(string title, string name, int genreInt, int releaseDate, bool hardcover)
            :base(name)
        {
            Title = title;
            GetGenre = ((Genre)genreInt);
            ReleaseDate = releaseDate;
            Hardcover = hardcover;
        }

    }

    public enum Genre
    {
        NonFiction,
        SciFi,
        Fantasy,
        Comedy,
        Romance,
        Drama
    }
}
