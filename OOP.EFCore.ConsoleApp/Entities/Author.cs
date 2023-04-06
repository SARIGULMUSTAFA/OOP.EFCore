namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => string.Concat(FirstName, " ", LastName);

        public DateTime Tarih { get; set; }

        public List<BookAuthor> BookAuthors { get; set; }
    }
}
