using BookList.Models;
using BookList.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookList.ViewModel
{
    public class MainWindowModel : INotifyPropertyChanged
    {

        private ObservableCollection<Book> _books;
        private Book _selectedBook;

        public ObservableCollection<Book> Books
        {
            get => _books;
            set 
            { 
                _books = value;
                OnPropertyChanged(nameof(Books));
            }
        }

        public Book SelectedBook
        {
            get => _selectedBook;
            set 
            { 
                _selectedBook = value; 
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        public MainWindowModel()
        {
            Books = new ObservableCollection<Book>();
        }

        public void AddBook()
        {
            var addBookWindow = new BookInfoEdit();
            if (addBookWindow.ShowDialog() == true)
            {
                var newBook = addBookWindow.Book;
                if (newBook != null)
                Books.Add(newBook);
            }
        }

        public void EditBook()
        {
            var addBookWindow = new BookInfoEdit(SelectedBook);
            if (addBookWindow.ShowDialog() == true)
             {
                 var updatedBook = addBookWindow.Book;
                 SelectedBook = updatedBook;
            }
        }

        public void DeleteBook()
        {
           Books.Remove(SelectedBook);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
