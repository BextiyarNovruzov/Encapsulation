using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Book:Product
    {
        public string Genre;

        public Book(string genre,double price,int count, int no,string name):base(price, count, no, name)
        {
            Genre = genre;
        }

        public void ShowFullInfo()
        {
            Console.WriteLine($"Genre: {Genre} Price:{Price} Count:{Count} No:{no}  Name:{name} ");
        }

    }
}
