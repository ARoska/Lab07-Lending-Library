using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    class Library<T> : IEnumerable
    {
        T[] books = new T[15];
        int count = 0;

        public void Add(T number)
        {
            if (count == books.Length)
            {
                Array.Resize(ref books, 5);
            }
            books[count++] = number;
            count++;
        }

        public void Remove(T book)
        {
            T[] temp = null;
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
