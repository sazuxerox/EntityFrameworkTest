using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkTest
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string PublicationName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
