using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LibraryMidGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\rzili\source\repos\LibraryMidGroup\LibraryMidGroup\Books.txt";

            List<Book> books = new List<Book>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Book newBook = new Book();

                newBook.Title = entries[0];
                newBook.Author = entries[1];
                newBook.BookStatus = entries[2];

                books.Add(newBook);
            }

            Console.WriteLine("Welcome to our Library!");
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Display our entire Library?");
            Console.WriteLine("2) Search by Author?");
            Console.WriteLine("3) Search by Keyword?");
            Console.WriteLine();
            Console.WriteLine("Enter 1, 2, or 3 to decide");
            Console.WriteLine();

            int decision = int.Parse(Console.ReadLine());

            if (decision == 1)
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title,-40} Author:{book.Author,-20} Status:{book.BookStatus}");
            }

            Console.ReadLine();
        }

    }
}
