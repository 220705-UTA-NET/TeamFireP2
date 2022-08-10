namespace FireLibrary.Model
{
    public class Book
    {
        public string? Isbn { get; set; }
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public string? Language { get; set; }
        public int Pages { get; set; }
        public string? Genre { get; set; }
        public int AuthorId { get; set; }
        public string? AuthorName { get; set; }
        public string? Synopsis { get; set; }
        public string? Excerpt { get; set; }
        public int TotalCopies { get; set; } = 5;
        public int AvalableCopies { get; set; } = 5;
        


        public Book() { }

        public Book(string? isbn, string? title, string? publisher, string? language, int pages, string? genre, int authorId, string? authorname, string? synopsis, string? excerpt, int totalCopies, int avalableCopies)

        {
            Isbn = isbn;
            Title = title;
            Publisher = publisher;
            Language = language;
            Genre = genre;
            Pages = pages;
            AuthorId = authorId;
            AuthorName = authorname;    
            Synopsis = synopsis;
            Excerpt = excerpt;
            TotalCopies = totalCopies;
            AvalableCopies = avalableCopies;
        }

        public Book(string? isbn, string? title, string? publisher, string? language, int pages, string? genre, string? synopsis, string? excerpt, int totalCopies, int avalableCopies, string? authorname) 
        {
            Isbn = isbn;
            Title = title;
            Publisher = publisher;
            Language = language;
            Genre = genre;
            Pages = pages;
            AuthorName = authorname;
            Synopsis = synopsis;
            Excerpt = excerpt;
            TotalCopies = totalCopies;
            AvalableCopies = avalableCopies;
        }

    }
}
