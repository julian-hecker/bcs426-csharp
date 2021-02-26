using System;
using System.Collections.Generic;

namespace HW3
{

    public static class IntExtension
    {
        public static string ToRoman(this int i)
        {
            // https://en.wikipedia.org/wiki/Roman_numerals
            if (i < 1 || i > 3999)
            {
                throw new Exception($"Only numbers 1-3999 can be represented using Roman Numerals: Received {i}");
            }

            var keys = new Dictionary<int, string>() {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"},
            };

            string result = "";

            // https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/
            while (i > 0)
            {
                foreach (KeyValuePair<int, string> key in keys)
                {
                    if (i - key.Key >= 0)
                    {
                        i -= key.Key;
                        result += key.Value;
                        break;
                    }
                }
            }
            return result;
        }
    }

    interface ISellable
    {
        double Sell(int count);
    }

    public abstract class Product
    {
        public double Price { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class Book : Product, ISellable
    {
        public string Author { get; set; }

        public Book(double price, string code, string description, string author)
        {
            Price = price;
            Code = code;
            Description = description;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Code} {Price} {Description} {Author}";
        }
        public double Sell(int count)
        {
            return Price * count;
        }
    }

    public class Software : Product, ISellable
    {
        public string Version { get; set; }

        public Software(double price, string code, string description, string version)
        {
            Price = price;
            Code = code;
            Description = description;
            Version = version;
        }

        public override string ToString()
        {
            return $"{Code} {Price} {Description} {Version}";
        }
        public double Sell(int count)
        {
            return Price * count;
        }
    }



    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(10.ToRoman());
            Console.WriteLine(23.ToRoman());
            Console.WriteLine(99.ToRoman());
            Console.WriteLine(3999.ToRoman());
            Console.WriteLine(39.ToRoman());

            var book = new Book(10.99, "Harry Potter", "120491295", "Rowling");
            var code = new Software(250, "Astra", "https://...", "5.2.1");

            Console.WriteLine(book.Sell(10));
            Console.WriteLine(code.Sell(40));
            Console.WriteLine(book);
            Console.WriteLine(code);


        }
    }

}