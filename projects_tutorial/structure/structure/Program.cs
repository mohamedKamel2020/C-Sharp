using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Books Book1;
            Books Book2;
            
            Book1.title = "C sharp";
            Book2.title = "Data structure";
            
            Book1.author = "john";
            Book2.author = "walid";
            
            Book1.subject = "C# tutrial ";
            Book2.subject = "Data Structure tutrial";
            
            Book1.book_id = 2020;
            Book2.book_id = 2002;                        


            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);
        }
    }
}
