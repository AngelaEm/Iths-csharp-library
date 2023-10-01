using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iths_csharp_library
{
    internal class Transaction
    {
        //Propertys
        public string TransactionId;
        public Book Book;
        public Member Member;
        public DateTime IssueDate;
        public DateTime ReturnDate;

        //Construktor
        public Transaction(string transactionId, Book book, Member member, DateTime issueDate, DateTime returnDate)
        {
            TransactionId = transactionId;
            Book = book;
            Member = member;
            IssueDate = issueDate;
            ReturnDate = returnDate;
            Library.ListWithTransactions.Add(this);
        }

        //Metoder


        public double CalculateOverDueFees()
        {
            double overdueDays = (DateTime.Today - ReturnDate).TotalDays;
            if (overdueDays > 0)
            {
                Member.OverdueFees = overdueDays * 3;

            }
            return Member.OverdueFees;

        }

        public override string ToString()
        {
            string transaction = $"ID: {TransactionId}\nBook: {Book}\nMember: {Member}\nIssueDate: {IssueDate}\nReturnDate: {ReturnDate}";
            return transaction;
        }

    }
}
