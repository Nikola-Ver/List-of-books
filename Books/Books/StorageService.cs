using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Books
{
    public class StorageService : Storage
    {

        public StorageService() { }

        private void Write(BinaryWriter bw, Book book)
        {
            bw.Write(book.Isbn);
            bw.Write(book.Author);
            bw.Write(book.Name);
            bw.Write(book.Edition);
            bw.Write(book.Year);
            bw.Write(book.Pages);
            bw.Write(book.Price);
        }

        private Book Read(BinaryReader br)
        {
            string isbn = br.ReadString();
            string author = br.ReadString();
            string name = br.ReadString();
            string edition = br.ReadString();
            int year = br.ReadInt32();
            int pages = br.ReadInt32();
            int price = br.ReadInt32();
            return new Book(isbn, author, name, edition, year, pages, price);
        }

        public void Serlization()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("books.dat", FileMode.Create, FileAccess.Write, FileShare.None)))
            {
                books.ForEach(e =>
                {
                    Write(bw, e);
                }); 
            }
        }

        public void Deserialization()
        {
            using (BinaryReader br = new BinaryReader(File.Open("books.dat", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read)))
            {
                books.Clear();
                while(br.BaseStream.Position != br.BaseStream.Length)
                {
                    books.Add(Read(br));
                }
            }
        }

        public List<Book> GetList()
        {
            return books;
        }

        public void Add(Book book)
        {
            if (books.Find(e => e.Isbn.CompareTo(book.Isbn) == 0) == null)
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
            int index = books.FindIndex(e => e.Equals(book));
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