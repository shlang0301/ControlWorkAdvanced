using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWorkAdvanced
{
    class Book
    {
        public string Name;
        public int Year;
        public string Author;

        public Book (string name, int year, string author)
        {
            Name = name;
            Year = year;
            Author = author;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Book First = new Book("The Lord of the Rings LINQ", 1960, "Ivan");
            Book Second = new Book("The Alchemist", 1988, "Stepan");
            Book Third = new Book("The Little Prince LINQ", 1943, "Ivan");
            Book Fourth = new Book("Grimms' Fairy Tales", 1812, "Stepan");
            Book Fifth = new Book("Harry Potter and the Philosopher's Stone", 1997, "Ivan");

            var books = new List<Book>();

            books.Add(First);
            books.Add(Second);
            books.Add(Third);
            books.Add(Fourth);
            books.Add(Fifth);

            //№1
            Console.WriteLine
               (
               string.Join
               (
                  "\n",
                   books.OfType<Book>().
                   Where(a => a.Name.Contains("LINQ") && a.Year % 4 == 0).
                   Select(c => $"{c.Name}: {c.Year}")
               )
               );
            Console.WriteLine("_________________________________________");


            //№2
             Console.WriteLine
                (
                string.Join
                (
                    " ",
                    "abcd;abcde;abcdef".Where (a=>a!=';').Distinct().Count()
                )
                );

            Console.WriteLine("_________________________________________");


            //№3
            int[] arr ={ 14, 12, 20, 23, 32,33};

            Console.WriteLine
              (
              string.Join
              (
                 " ",
                 arr.ToString().Split(',').OrderBy(a=>a.First()).ThenByDescending(b=>b.Last()).Select(c=>c)
              )
              );

            Console.WriteLine("_________________________________________");


            //№4
            Console.WriteLine
              (
              string.Join
              (
                 "\n",
                  books.OfType<Book>().GroupBy(a => a.Author).Select(b => $"{b.Key}: {b.Count()}")
              )
              );           

            Console.ReadLine();
        }
    }
}
