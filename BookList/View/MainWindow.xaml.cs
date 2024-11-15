﻿using BookList.View;
using BookList.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookList
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowModel();
        }
        private void AddBook(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainWindowModel viewModel)
            {
                viewModel.AddBook();
            }
        }

        private void EditBook(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainWindowModel viewModel)
            {
                viewModel.EditBook();
            }
        }

        private void DeleteBook(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainWindowModel viewModel)
            {
                viewModel.DeleteBook();
            }
        }
    }
}
