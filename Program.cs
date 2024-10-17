using System.Threading.Tasks.Dataflow;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Library library = new Library();

            Book book = new Book("Advanture", 9, 1, 231231, "Gizli Bahcenin Anahtari");
            Book book1 = new Book("Klassiks", 5.5, 1, 431241, "Hayvan Cifligi");
            Book book2 = new Book("Klassiks", 10, 1, 234231, "Icimizdeki seytan");
            Book book3 = new Book("Advanture", 14.5, 1, 331231, "127 Hours");

           
            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);


            Book[] filteredBook = library.GetFilteredBooks("Klassiks");



            foreach (var item in filteredBook)
            {
                item.ShowFullInfo();

            }
            Console.WriteLine("----------------------------------------------------------------------------");

            library.ShowAllBooks();


        }



    }
}
