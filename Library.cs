using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Encapsulation
{
    public class Library
    {
        private Book[] Books = new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1 );
            Books[Books.Length - 1] = book;

        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] filteredBook = new Book[0];

            foreach (Book book in Books)
            {
                if (genre == book.Genre)
                {
                    Array.Resize(ref filteredBook, filteredBook.Length + 1);
                    filteredBook[filteredBook.Length - 1] = (Book)book;
                }
            }

            return filteredBook;
        }


        public Book GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book filteredBook = null;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Price > minPrice && Books[i].Price < maxPrice)
                {
                    filteredBook = Books[i];
                    return filteredBook;
                }
            }
            return filteredBook;
        }


        public void ShowAllBooks()
        {
            foreach (var book in Books)
            {
                book.ShowFullInfo();
                Console.WriteLine("----------------");

            }
           
        }

      

       
    }   
}
