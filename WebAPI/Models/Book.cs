namespace WebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; } = null!;
        public string Title { get; set; } = null!;
        public int YearPublished { get; set; }

    }
}
