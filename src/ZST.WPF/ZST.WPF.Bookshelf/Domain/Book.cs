using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace ZST.WPF.Bookshelf.Domain
{

    public class Book : Base
    {
        public string Title { get; set; }
        public Person Author { get; set; }
        public Person Translator { get; set; }
        public string Description { get; set; }
        public int PublishedYear { get; set; }
        public decimal Price { get; set; }
        public string ISBN { get; set; }

        public string[] Fields {
            get
            {
                return new string[]
                {
                    Title,
                    Author.FirstName,
                    Author.LastName,
                    Description,
                    PublishedYear.ToString(),
                    Price.ToString(),
                    ISBN
                };
            }
        }


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

        public Book(int id)
            :base(id)
        {

        }

        public Book(int id, string title, Person author, string description, int publishedYear, decimal price, string iSBN)
            : base(id)
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
