namespace ZST.WPF.Bookshelf.Domain
{
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

        public Person(int id, string firstName, string lastName)
            : base(id)
        {            
            FirstName = firstName;
            LastName = lastName;
        }



        //public override string ToString()
        //{
        //    return FullName;
        //}
    }
}
