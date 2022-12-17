using System;

namespace ZST.WPF.Bookshelf.Domain
{
    public abstract class Base 
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        protected Base(int id)
        {
            Id = id;
            CreatedOn = DateTime.Now;
        }
    }
}
