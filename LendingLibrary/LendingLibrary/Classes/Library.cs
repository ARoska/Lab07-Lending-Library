using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Library<T> : IEnumerable
    {
        T[] books = new T[20];
        int count = 0;

        public void Add(T number)
        {
            if (count == books.Length)
            {
                Array.Resize(ref books, 5);
            }
            books[count++] = number;
        }

        public void Remove(T book)
        {
            if (Array.IndexOf(books, book) != -1)
            {
                T[] temp = new T[books.Length];
                int index = Array.IndexOf(books, book);

                for (int i = 0; i < books.Length; i++)
                {
                    if (i < index)
                    {
                        temp[i] = books[i];
                    }
                    if (i == index)
                    {
                        i++;
                    }
                    else if (i > index)
                    {
                        temp[i - 1] = books[i - 1];
                    }
                }
                books = temp;

                count--;
                if (count == (books.Length - 5))
                {
                    Array.Resize(ref books, 5);
                }
            }
        }

        public bool IsAvailable(T book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null && books[i].Equals(book))
                {
                    return true;
                }
            }
            return false;
        }

        public int Count()
        {
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
