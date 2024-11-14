using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Book
    {
        int Id;
        String Title;
        String Author;
        bool IsAvailable=true;

        public Book(int Id, String Title, String Author)
        {
            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
        }
        public void DisplayValue()

        {  
            Console.WriteLine("Book ID: " + Id + " Book Name: " + Title + " Book Author: " + Author);
        }
        public void BorrowBook()
        {
            Console.WriteLine("Please enter the title of the book which you want to borrow");
            String BorrowTitle = Console.ReadLine();
            //IsAvailable = !string.IsNullOrEmpty(BorrowTitle)&& string.Equals(Title, BorrowTitle, StringComparison.CurrentCultureIgnoreCase);
            //if (IsAvailable) 
            //{
            //    Console.WriteLine("Book is Available You have borrowed the book on Date " + (DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt")));
            //    return;
            //}
            //Console.WriteLine("Book not Available ");

            if (BorrowTitle == Title && IsAvailable)
            {

                Console.WriteLine("Book is Available You have borrowed the book on Date " + (DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt")));


            }
                else if (BorrowTitle == Title && IsAvailable == false)
            {
                Console.WriteLine("Book not Available ");
            }
            IsAvailable = false;
        }
                public void ReturnBook()
                {
                    Console.WriteLine("Enter Book name which you are returning");
                    String ReturnTitle = Console.ReadLine();

                    if (ReturnTitle == Title && IsAvailable == false)
                    {
                        Console.WriteLine("Book Returned");
                    }
                    IsAvailable = true;
                }
        class Execute
        {
            public static void Main(string[] args)
            {
                Book B1 = new Book(1, "Ramayan", "Valmiki");
                Book B2 = new Book(2, "Mahabharat", "vyasa");
                    B1.BorrowBook();
                    B1.BorrowBook();
                    B1.ReturnBook();
                    B1.DisplayValue();
                    B1.BorrowBook();
            }

        }
    } 
}
