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
                (obj as ListBox).Items.Add(e.Author);
            });
        }

        Book GetBook()
        {
            if (textIsbn.Text.Length == 0) return null;
            if (textAuthor.Text.Length == 0) return null;
            if (textName.Text.Length == 0) return null;
            if (textEdition.Text.Length == 0) return null;
            if (textYear.Text.Length == 0) return null;
            if (textPages.Text.Length == 0) return null;
            if (textPrice.Text.Length == 0) return null;

            string isbn = textIsbn.Text;
            string author = textAuthor.Text;
            string name = textName.Text;
            string edition = textEdition.Text;
            int year = Int32.Parse(textYear.Text);
            int pages = Int32.Parse(textPages.Text);


            int sel = course.SelectedIndex;
            double coeff = sel == 0 ? 2.7 : sel == 1 ? 3.2 : 1;
            int price = (int)(Double.Parse(textPrice.Text) * coeff * 100); // Храним в белорусских копейках

            return new Book(isbn, author, name, edition, year, pages, price);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book book = GetBook();
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
            Book book = GetBook();
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
            Book book = GetBook();
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
    }
}
