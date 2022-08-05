using System;
namespace FireLibrary.Model
{
    public class BookResponse
    {
        Book Book { get; set; }
        int TotalCopies { get; set; }
        int CopiesAvailable { get; set; }
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

