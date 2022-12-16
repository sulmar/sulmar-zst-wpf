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

    public class Book : Base
    {
        public string Title { get; set; }
        public string Author { get; set; }
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

        public Book(string title, string author, string description, int publishedYear, decimal price, string iSBN)
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
