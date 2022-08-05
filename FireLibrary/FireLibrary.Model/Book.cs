namespace FireLibrary.Model
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author{ get; set; }
        public string Publisher{ get; set; }
        public string Language{ get; set; }
        public string Synopsys{ get; set; }
        public string Excerpt{ get; set; }
        public int Pages { get; set; }
        int TotalCopies { get; set; }
        int CopiesAvailable { get; set; }
        public Book() { }
        public Book(string isbn, string title, string author, string publisher, string language, string synopsys, string excerpt, int pages, int totalcopies, int copiesavailable){
            this.Isbn = isbn;
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.Language = language;
            this.Synopsys = synopsys;
            this.Excerpt = excerpt;
            this.Pages = pages;
            this.TotalCopies = totalcopies;
            this.CopiesAvailable = copiesavailable;
        }
    }
    

    
}