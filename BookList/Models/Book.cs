using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Models
{
    public class Book : INotifyPropertyChanged
    {
        private string _title;
        public string title
        {
            get => _title;
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged(nameof(title));
                }
            }
        }
        private string _author;
        public string author
        {
            get => _author;
            set
            {
                if (_author != value)
                {
                    _author = value;
                    OnPropertyChanged(nameof(author));
                }
            }
        }
        private int _year;
        public int year
        {
            get => _year;
            set
            {
                if (_year != value)
                {
                    _year = value;
                    OnPropertyChanged(nameof(year));
                }
            }
        }
        private string _genre;
        public string genre
        {
            get => _genre;
            set
            {
                if (_genre != value)
                {
                    _genre = value;
                    OnPropertyChanged(nameof(genre));
                }
            }
        }
        private int _pages;
        public int pages
        {
            get => _pages;
            set
            {
                if (_pages != value)
                {
                    _pages = value;
                    OnPropertyChanged(nameof(pages));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    
}
