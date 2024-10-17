using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Product
    {
        private double _price;
        private int _count;
        public int no;
        public string name;

        public Product(double price, int count, int no, string name)
        {
            _price = price;
            _count = count;
            this.no = no;
            this.name = name;
        }

        public double Price
        {
            get 
            {
                return _price;
            }
            set
            {
                if (_price<0)
                {
                    Console.WriteLine("Bankrot olmaq fikrimiz yoxdur deye menfi qiymete kitab yoxdur.");
                }
            }
        }
        public int Count
        {
            get 
            { 
                return _count; 
            }
            set
            {
                if (_count<0)
                {
                    Console.WriteLine("Menfi sayda kitab olmur");                 }
            }
        }
    }
}
