using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace модуль_4_воробьёв
{
    public partial class Task4Form : Form
    {
        private List<IBook> books;  // Список книг

        public Task4Form()
        {
            InitializeComponent();

            // Инициализация списка книг
            books = new List<IBook>
        {
            new FictionBook("Мастер и Маргарита", true),
            new Textbook("Физика 10 класс", true),
            new FictionBook("Война и мир", false)
        };

            // Заполняем ListBox книгами
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetTitle());
            }
        }

        // Проверка доступности книги
        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex != -1)
            {
                IBook selectedBook = books[listBoxBooks.SelectedIndex];

                if (selectedBook.IsAvailable())
                {
                    MessageBox.Show($"Книга \"{selectedBook.GetTitle()}\" доступна.");
                }
                else
                {
                    MessageBox.Show($"Книга \"{selectedBook.GetTitle()}\" недоступна.");
                }
            }
        }

        // Выдача книги
        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex != -1)
            {
                IBook selectedBook = books[listBoxBooks.SelectedIndex];

                selectedBook.IssueBook();
                MessageBox.Show($"Книга \"{selectedBook.GetTitle()}\" выдана.");
            }
        }
    }
}
