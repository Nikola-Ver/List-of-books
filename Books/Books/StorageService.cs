using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class StorageService : Storage
    {

        public StorageService() { }

        public List<Book> GetList()
        {
            return books;
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public List<Book> Find(bool[] variant, Book value)
        {
            List<Book> tempBooks = new List<Book>();

            books.ForEach(e =>
            {
                bool flag = true;
                if (variant[0] && e.Isbn != value.Isbn) flag = false;
                if (variant[1] && e.Author != value.Author) flag = false;
                if (variant[2] && e.Name != value.Name) flag = false;
                if (variant[3] && e.Edition != value.Edition) flag = false;
                if (variant[4] && e.Year != value.Year) flag = false;
                if (variant[5] && e.Pages != value.Pages) flag = false;
                if (variant[6] && e.Price != value.Price) flag = false;
                if (flag) tempBooks.Add(e); 
            });

            return tempBooks;
        }

        public bool Remove(Book book)
        {
            int index = books.FindIndex(e => e.CompareBooks(book));
            if (index > -1)
            {
                books.RemoveAt(index);
                return true;
            }
            return false;
        }

        public void Sort(IComparer<Book> comparer)
        {
            Book[] arrayOfBooks = books.ToArray();

            if (ReferenceEquals(comparer, null))
                Array.Sort(arrayOfBooks);
            else
                Array.Sort(arrayOfBooks, comparer);

            books.Clear();
            books.AddRange(arrayOfBooks);
        }
    }
}