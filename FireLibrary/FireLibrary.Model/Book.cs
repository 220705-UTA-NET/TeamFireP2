namespace FireLibrary.Model
{
    public class Book
    {
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public string? Language { get; set; }
        public int Pages { get; set; }
        public double Msrp { get; set; }
        public int AuthorId { get; set; }
        public string? Synopsys { get; set; }
        public string? Excerpt { get; set; }
        public int TotalCopies { get; set; } = 5;
        public int AvalableCopies { get; set; } = 5;


        public Book() { }

        public Book(string? isbn, string? title, string? publisher, string? language, int pages, double msrp, int authorId, string? synopsys, string? excerpt, int totalCopies, int avalableCopies)
        {
            Isbn = isbn;
            Title = title;
            Publisher = publisher;
            Language = language;
            Pages = pages;
            Msrp = msrp;
            AuthorId = authorId;
            Synopsys = synopsys;
            Excerpt = excerpt;
            TotalCopies = totalCopies;
            AvalableCopies = avalableCopies;
        }
    }
}