using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZST.WPF.Bookshelf.Domain;

namespace ZST.WPF.Bookshelf.ViewModels
{
    public class BooksViewModel
    {
        public ObservableCollection<Book> Books { get; set; }

        public Book SelectedBook { get; set; }

        public BooksViewModel() 
        {
            Books = new ObservableCollection<Book>();

            Books.Add(new Book("WPF dla Opornych", "Marcin", "Lorem ipsum...", 2022, 99, "ABC123"));

            Books.Add(new Book("SQL dla Opornych", "Marek", "Lorem ipsum...", 2020, 199, "XYZ123"));

            Books.Add(new Book("C dla Opornych", "Edyta", "Lorem ipsum...", 2022, 299, "AAA123"));

        }


    }
}
