using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice_c_
{
    class Book
    {
        public int bookId;
        public string title;
        public string author;
        public bool isAvailable = true;

        Book(int bookId, string title, string author, bool isAvailable)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.isAvailable = isAvailable;
        }
        public void BorrowBook()
        {
            Console.WriteLine("Borrow Book method call");
            if (isAvailable == true)
            {
                isAvailable = false;
            }
            else
            {
                Console.WriteLine("Book is not available");
            }
        }
        public void ReturnBook()
        {
            Console.WriteLine("Return Book method call");
            if (isAvailable == false)
            {
                isAvailable = true;
                Console.WriteLine("Book has been returned");
            }
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine("Book Id " +bookId +" Title "+title+" Author "+author+" Available Status "+isAvailable);
        }

        //public static void Main(string[] args)
        //{
        //    Book b1 = new Book(1, "B1", "A1", true);
        //    b1.DisplayBookInfo();
        //    b1.BorrowBook();
        //    b1.DisplayBookInfo();
        //    b1.ReturnBook();
        //    b1.DisplayBookInfo();

        //    Console.WriteLine("\n\n\n");

        //    Book b2 = new Book(2, "B2", "A2", false);
        //    b2.DisplayBookInfo();
        //    b2.ReturnBook();
        //    b2.DisplayBookInfo();
        //    b2.BorrowBook();
        //    b2.DisplayBookInfo();
        //}

    }
}
