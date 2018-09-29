using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ArrayClasses
{
    class Library
    {
        Book[] books;
        bool[] deletedBooks;

        uint totalBooksQuantity = 0;
        uint currentBooksQuantity = 0;

        public Library(uint totalBooksQuantity)
        {
            this.totalBooksQuantity = totalBooksQuantity;
            books = new Book[totalBooksQuantity];
            deletedBooks = new bool[totalBooksQuantity];

            // по-умолчанию все книги удалены
            for (int i = 0; i < deletedBooks.Length; i++)
                deletedBooks[i] = true;            
        }

        public bool AddBook(Book book)
        {
            bool result = false;

            if (currentBooksQuantity < totalBooksQuantity)
            {
                deletedBooks[currentBooksQuantity] = false;
                books[currentBooksQuantity++] = book;
                result = true;
            }

            return result;
        }

        public bool RemoveBook(uint bookNumber)
        {
            bool result = false;

            if ((bookNumber < currentBooksQuantity) && (bookNumber > 0))
            {
                deletedBooks[bookNumber - 1] = true;
                result = true;
            }

            return result;
        }

        public override string ToString()
        {
            string books = "";
            for (int i = 0; i < currentBooksQuantity; i++)
                if (this.deletedBooks[i] == false)
                    books += (i+1) + " " + this.books[i].ToString() + "\n----\n";

            return books;
        }

        internal Book[] Books { get => books; set => books = value; }
        public uint TotalBooksQuantity { get => totalBooksQuantity; }
        public uint CurrentBooksQuantity { get => currentBooksQuantity; }
    }
}
