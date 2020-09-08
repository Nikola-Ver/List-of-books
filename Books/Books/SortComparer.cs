using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class SortComparer : IComparer<Book>
    {
        private int Ditiction = 1;
        private int Variant = 0;
        public int Compare(Book left, Book right)
        {
            switch (Variant)
            {
                case 0:
                    return this.Ditiction * left.Isbn.CompareTo(right.Isbn);
                case 1:
                    return this.Ditiction * left.Author.CompareTo(right.Author);
                case 2:
                    return this.Ditiction * left.Name.CompareTo(right.Name);
                case 3:
                    return this.Ditiction * left.Edition.CompareTo(right.Edition);
                case 4:
                    return this.Ditiction * (left.Year - right.Year);
                case 5:
                    return this.Ditiction * (left.Pages - right.Pages);
                case 6:
                    return this.Ditiction * (left.Price - right.Price);
            }
            return 0;
        }


        public void SetCompare(int diriction, int variant)
        {
            this.Ditiction = diriction;
            this.Variant = variant;
        }
    }
}
