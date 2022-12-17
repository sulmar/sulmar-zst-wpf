﻿using System;
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
using ZST.WPF.Bookshelf.ViewModels;

namespace ZST.WPF.Bookshelf.Views
{
    /// <summary>
    /// Interaction logic for BooksView.xaml
    /// </summary>
    public partial class BooksView : Page
    {
        private BooksViewModel viewModel;

        public BooksView()
        {
            InitializeComponent();

            viewModel = new BooksViewModel();

            this.DataContext = viewModel;
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            viewModel.AddBook();
        }
    }
}
