using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class BooksForm : Form
    {
        private Storage Storage = new Storage();
        private StorageService StorageService = new StorageService();
        public SortComparer Comparer = new SortComparer();

        public BooksForm()
        {
            InitializeComponent();
        }

        private void BooksForm_Shown(object sender, EventArgs e)
        {
            course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            course.SelectedIndex = 0;
        }

        void ShowList(Object obj, List<Book> books)
        {
            (obj as ListBox).Items.Clear();
            books.ForEach(e =>
            {
                (obj as ListBox).Items.Add(e.ToString());
            });
        }

        Book GetBook(bool flag)
        {
            if (!flag)
            {
                if (
                    textIsbn.Text.Length == 0 ||
                    textAuthor.Text.Length == 0 ||
                    textName.Text.Length == 0 ||
                    textEdition.Text.Length == 0 ||
                    textYear.Text.Length == 0 ||
                    textPages.Text.Length == 0 ||
                    textPrice.Text.Length == 0
                    )
                    return null;
            }

            string isbn = textIsbn.Text;
            string author = textAuthor.Text;
            string name = textName.Text;
            string edition = textEdition.Text;
            int year = -1;
            int pages = -1;
            Int32.TryParse(textYear.Text, out year);
            Int32.TryParse(textPages.Text, out pages);

            int sel = course.SelectedIndex;
            double coeff = sel == 0 ? 2.7 : sel == 1 ? 3.2 : 1;
            double tempPrice = -1;
            Double.TryParse(textPrice.Text, out tempPrice);
            int price = (int)(tempPrice * coeff * 100); // Храним в белорусских копейках

            if (year <= 0 || pages <= 0 || price <= 0) return null;

            return new Book(isbn, author, name, edition, year, pages, price);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book book = GetBook(false);
            if (book != null)
            {
                StorageService.Add(book);
                ShowList(listOfCurrentBooks, StorageService.GetList());
            }
            else
                MessageBox.Show("Введены неверные параметры", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Book book = GetBook(false);
            if (book != null)
            {
                if (!StorageService.Remove(book))
                    MessageBox.Show("Такой книги не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    ShowList(listOfCurrentBooks, StorageService.GetList());
            }
            else
                MessageBox.Show("Введены неверные параметры", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            Book book = GetBook(true);
            if (book != null)
            {
                bool[] variants =
                {
                    checkIsbn.Checked,
                    checkAuthor.Checked,
                    checkName.Checked,
                    checkEdition.Checked,
                    checkYear.Checked,
                    checkPages.Checked,
                    checkPrice.Checked
                };
                List<Book> books = StorageService.Find(variants, book);
                if (books.Count == 0)
                    MessageBox.Show("Такой книги не существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    ShowList(listOfFoundBooks, books);
            }
            else
                MessageBox.Show("Введены неверные параметры", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        int getVariant()
        {
            if (checkIsbn.Checked) return 0;
            if (checkAuthor.Checked) return 1;
            if (checkName.Checked) return 2;
            if (checkEdition.Checked) return 3;
            if (checkYear.Checked) return 4;
            if (checkPages.Checked) return 5;
            if (checkPrice.Checked) return 6;
            return 0;
        }
        private void sortGrowButton_Click(object sender, EventArgs e)
        {
            Comparer.SetCompare(1, getVariant());
            StorageService.Sort(Comparer);
            ShowList(listOfCurrentBooks, StorageService.GetList());
        }

        private void sortWaneButton_Click(object sender, EventArgs e)
        {
            Comparer.SetCompare(-1, getVariant());
            StorageService.Sort(Comparer);
            ShowList(listOfCurrentBooks, StorageService.GetList());
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            StorageService.Deserialization();
            ShowList(listOfCurrentBooks, StorageService.GetList());
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            StorageService.Serlization();
            ShowList(listOfCurrentBooks, StorageService.GetList());
        }
    }
}
