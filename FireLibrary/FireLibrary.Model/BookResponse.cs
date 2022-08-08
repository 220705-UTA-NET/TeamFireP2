using System;
namespace FireLibrary.Model
{
    public class BookResponse
    {
        public Book Book { get; set; }
        public int TotalCopies { get; set; }
        public int CopiesAvailable { get; set; }
        public BookResponse()
        {
        }
        public BookResponse(Book book, int totalcopies, int copiesavailable)
        {
            this.Book = book;
            this.TotalCopies = totalcopies;
            this.TotalCopies = copiesavailable;
        }
    }
}

