using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZST.WPF.Bookshelf.Domain
{
    public abstract class Base 
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        
    }

    public class Person : Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public override string ToString()
        {
            return FullName;
        }
    }

    public class Book : Base
    {
        public string Title { get; set; }
        public Person Author { get; set; }
        public Person Translator { get; set; }
        public string Description { get; set; }
        public int PublishedYear { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }

        public string FullName
        {
            get
            {
                return $"\"{Title}\" {Author} {Description}";
            }
        }

        public override string ToString()
        {
            return FullName;
        }


        public Book()
        {

        }

        public Book(string title, Person author, string description, int publishedYear, decimal price, string iSBN)
        {
            Title = title;
            Author = author;
            Description = description;
            PublishedYear = publishedYear;
            Price = price;
            ISBN = iSBN;
        }
    }
}
