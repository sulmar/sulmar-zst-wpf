using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZST.WPF.Bookshelf.Domain;

namespace ZST.WPF.Bookshelf.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged!=null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class BooksViewModel : BaseViewModel
    {
        public ObservableCollection<Book> Books { get; set; }

        private Book selectedBook;
        public Book SelectedBook
        {
            get
            {
                return selectedBook;
            }
            set
            {
                selectedBook = value;
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        public BooksViewModel() 
        {
            Books = new ObservableCollection<Book>();

            Books.Add(new Book("WPF dla Opornych", "Marcin", "Lorem ipsum...", 2022, 99, "ABC123"));

            Books.Add(new Book("SQL dla Opornych", "Marek", "Lorem ipsum...", 2020, 199, "XYZ123"));

            Books.Add(new Book("C dla Opornych", "Edyta", "Lorem ipsum...", 2022, 299, "AAA123"));

        }

        public void AddBook()
        {
            Book book = new Book();

            Books.Add(book);

            SelectedBook = book;
        }


    }
}
