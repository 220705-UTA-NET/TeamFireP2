using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireLibrary.Model
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; }

        public Author() { }

        public Author(int authorId, string name)
        {
            AuthorId = authorId;
            Name = name;
        }
    }
}
