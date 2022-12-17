using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

        public bool IsSelectedBook
        {
            get
            {
                return selectedBook != null;
            }
        }

        public ObservableCollection<Person> Authors {  get; set; }

        public BooksViewModel() 
        {
            Books = new ObservableCollection<Book>();
            Authors = new ObservableCollection<Person>();

            //Person author1 = new Person(1, "Marcin", "Smith" );
            //Person author2 = new Person (2, "Marek", "Smith" );

            //Authors.Add(author1);
            //Authors.Add(author2);

            GetAuthors();

            Person author1 = Authors.FirstOrDefault();
            Person author2 = Authors.FirstOrDefault();

            Books.Add(new Book(1, "WPF dla Opornych", author1, "Lorem ipsum...", 2022, 99, "ABC123"));

            Books.Add(new Book(2, "SQL dla Opornych", author2, "Lorem ipsum...", 2020, 199, "XYZ123"));

            Books.Add(new Book(3, "C dla Opornych", author1, "Lorem ipsum...", 2022, 299, "AAA123"));

        }

        public void GetAuthors()
        {
            string connectionString = @"Data Source=bookshelf.db";

            SqliteConnection connection = new SqliteConnection(connectionString);

            connection.Open();

            var command = connection.CreateCommand();

            string sql = "SELECT AuthorId, FirstName, LastName FROM Authors";
            command.CommandText = sql;

            var reader = command.ExecuteReader();

            while(reader.Read())
            {
                int id = reader.GetInt32(reader.GetOrdinal("AuthorId"));
                string firstname = reader.GetString(reader.GetOrdinal("FirstName"));
                string lastname = reader.GetString(reader.GetOrdinal("LastName"));

                Person author = new Person(id, firstname, lastname);

                Authors.Add(author);
            }

            connection.Close();
            connection.Dispose();
        }

        public void AddBook()
        {
            Book book = new Book(0);

            Books.Add(book);

            SelectedBook = book;
        }

        public void RemoveBook()
        {
            Books.Remove(SelectedBook);
        }

        /*
        public void SaveBooks()
        {
            string filename = "books.csv";

            StreamWriter streamWriter = new StreamWriter(filename);
            
            foreach (Book book in Books)
            {
                string line = $"{book.Title};{book.Author.FirstName};{book.Author.LastName};{book.Description};{book.Price};{book.ISBN}";

                streamWriter.WriteLine(line);
            }

            streamWriter.Close();
            streamWriter.Dispose();
        }

        */

        public void SaveBooks()
        {
            string connectionString = @"Data Source=bookshelf.db";

            SqliteConnection connection = new SqliteConnection(connectionString);

            connection.Open();

          

            foreach (var author in Authors)
            {
                SqliteCommand command = connection.CreateCommand();

                string sql = "INSERT INTO [Authors] ([FirstName],[LastName]) VALUES ($FirstName, $LastName)";
                command.CommandText = sql;
                
                command.Parameters.AddWithValue("$FirstName", author.FirstName);
                command.Parameters.AddWithValue("$LastName", author.LastName);               

                int rowsAffected = command.ExecuteNonQuery();
            }


            connection.Close();
            connection.Dispose();


        }


    }
}

