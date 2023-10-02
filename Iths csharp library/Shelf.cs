using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iths_csharp_library
{
    internal class Shelf
    {
        public string ID { get; set; }
        public string Category { get; set; }
        public List<Book> ListofBooks { get; set; }

        public int _maxNumberOfBooksInShelf = 100;

        public Shelf(string id, string category)
        {
            ID = id;
            Category = category;
            List<Book> ListofBooks = new List<Book>();
        }


        public bool IsFull()
        {
            if (ListofBooks.Count >= _maxNumberOfBooksInShelf)
            {
                return true;
            }
           return false;

        }

    }
}
