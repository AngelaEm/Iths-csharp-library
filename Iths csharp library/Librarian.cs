using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Iths_csharp_library
{
    internal class Librarian : LibraryUser
    {
        // Fields
        private string _position;

        public Librarian(int id, string name, string position) : base(id, name)
        {
            _position = position;
        }


        public string Posistion
        {
            get { return _position; }
            set { _position = value; }
        }


        public void AddBook(Book book)
        {



        }

        public void RemoveBook(Book book)
        {
            

        }

        public Book? SearchBook(Library library, string request, bool isCategory)
        {
            foreach (Shelf shelf in library.ListWithShelves)
            {
                foreach (Book book in shelf.ListofBooks )
                {
                    if (book.Isbn == request || book.Title == request || book.Author == request)
                    {
                        return book;
                    }
                }         
            }
            return null;
        }

        

        public void AddBookToShelf(Book book, Shelf shelf)
        {
            shelf.ListofBooks.Add(book);
        }
        public void RemoveBookFromShelf(Book book, Shelf shelf)
        {
            shelf.ListofBooks.Remove(book);
        }

        public void IssueBook(string transactionId, Book book, Member member, DateTime issueDate, DateTime returnDate)
        {
            book.AvailebleCopies--;
            member._checkedOutBooks.Add(book);
            Transaction transaction = new Transaction(transactionId, book, member, issueDate, returnDate);


        }


        public void AcceptReturnedBook(string transactionId, Book book, Member member, DateTime issueDate, DateTime returnDate)
        {

            book.AvailebleCopies++;
            member._checkedOutBooks.Remove(book);
            Transaction transaction = new Transaction(transactionId, book, member, issueDate, returnDate);
        }

    }
}
