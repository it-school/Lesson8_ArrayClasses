using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ArrayClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book ("Alphabet", new string[] { "Alphabeter1", "Alphabeter2" }, "Printer", 200);
            //Console.WriteLine(book);

            Library library = new Library(10);
            library.AddBook(book);
            //Console.WriteLine(library.Books[0]);

            library.AddBook(book);
            library.AddBook(book);
            Console.WriteLine(library);

            Console.WriteLine("/n--------- Remove 1 book --------/n");

            if (!library.RemoveBook(10))
                Console.WriteLine("\nError while deleting book from library\n\n");
            Console.WriteLine(library);

        }
    }
}
