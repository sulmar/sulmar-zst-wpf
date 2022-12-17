using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZST.WPF.Bookshelf.Domain;

namespace ZST.WPF.Bookshelf.ViewModels
{

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

        public ObservableCollection<Person> Authors {  get; set; }

        public BooksViewModel() 
        {
            Books = new ObservableCollection<Book>();
            Authors = new ObservableCollection<Person>();

            Person author1 = new Person { FirstName = "Marcin", LastName = "Smith" };
            Person author2 = new Person { FirstName = "Marek", LastName = "Smith" };

            Authors.Add(author1);
            Authors.Add(author2);

            Books.Add(new Book("WPF dla Opornych", author1, "Lorem ipsum...", 2022, 99, "ABC123"));

            Books.Add(new Book("SQL dla Opornych", author2, "Lorem ipsum...", 2020, 199, "XYZ123"));

            Books.Add(new Book("C dla Opornych", author1, "Lorem ipsum...", 2022, 299, "AAA123"));

        }

        public void AddBook()
        {
            Book book = new Book();

            Books.Add(book);

            SelectedBook = book;
        }


    }
}

