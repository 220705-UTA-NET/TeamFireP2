using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireLibrary.Model
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }

        public Author() { }

        public Author(int authorID, string name)
        {
            this.AuthorID = authorID;
            this.Name = name;
        }
    }
}
