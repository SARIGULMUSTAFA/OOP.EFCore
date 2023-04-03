namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Category,  Book Tablosunda  çok kez tekrar edebilir.
        public ICollection<Book> Books { get; set; }

    }
}
