using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMidGroup
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string BookStatus { get; set; }
        public DateTime? DueDate { get; set; } //? makes DateTime nullable for when it has no due date

        //default constructor
        public Book() { }

        public Book(string title, string author, string bookstatus, DateTime? duedate)
        {
            Title = title;
            Author = author;
            BookStatus = bookstatus;
            DueDate = duedate;
        }
    }
}
