using BookList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookList.View
{
    /// <summary>
    /// Логика взаимодействия для BookInfoEdit.xaml
    /// </summary>
    public partial class BookInfoEdit : Window
    {
        public Book Book { get; private set; }

        public BookInfoEdit(Book book = null)
        {
            InitializeComponent();
            
           

            if (book != null)
            {
                Book = book;
                TitleTextBox.Text = book.title;
                AuthorTextBox.Text = book.author;
                YearTextBox.Text = book.year.ToString();
                GenreTextBox.Text = book.genre;
                PagesTextBox.Text = book.pages.ToString();
            }
            else
            {
                Book = new Book();
            }
        }

        private void SaveBook(object sender, RoutedEventArgs e)
        {
            Book.title = TitleTextBox.Text;
            Book.author = AuthorTextBox.Text;
            Book.year = Int32.Parse(YearTextBox.Text);
            Book.genre = GenreTextBox.Text;
            Book.pages = Int32.Parse(PagesTextBox.Text);
            DialogResult = true;
            this.Close();
        }

        private void CancelEditing(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            this.Close();
        }
    }
}
