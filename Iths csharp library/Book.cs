using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iths_csharp_library
{
    internal class Book : Document
    {
        //Fields 
        private string _isbn;
        private int _totalCopies;
        private int _availebleCopies;

        public Book(string title, string author, string isbn, int totalCpoies)
        {
            Title = title;
            Author = author;
            _isbn = isbn;
            _totalCopies = totalCpoies;
        }

        //Propertys
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public int TotalCopoies
        {
            get { return _totalCopies; }
            set { _totalCopies = value; }
        }

        public int AvailebleCopies
        {
            get { return _availebleCopies; }
            set { _availebleCopies = value; }
        }

    }
}
