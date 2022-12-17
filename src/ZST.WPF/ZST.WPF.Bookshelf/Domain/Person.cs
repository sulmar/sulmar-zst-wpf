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

        //public override string ToString()
        //{
        //    return FullName;
        //}
    }
}
