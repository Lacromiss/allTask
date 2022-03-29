using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    internal class Library
    {
        Book[] books;
        public Library(int bookLimit)
        {
            BookLimit= bookLimit;
             books=  new Book[0];
            

        }
        public int BookLimit { get; set; }
        public void AddBook(Book book)
        {
            if (books.Length>BookLimit)
            {
                Array.Resize(ref books, books.Length+1);
                books[books.Length-1] = book;
                return;

            }
            throw new Exception("Limit doldu");


        }
        public Book GetElementById(int id)
        {

            foreach (var book in books)
            {
                if (book.Id == id)
                    return book;
            }
            return null;






        }
    }
}
