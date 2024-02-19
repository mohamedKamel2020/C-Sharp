using System;

namespace _12_structure_tutorial
{
    struct Books
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;
    };
    public class Program
    {
        public static void Main(string[] args)
        {
            Books Book1;
            Books Book2;
            Book1.title = "C Programming";
            Book1.author = "Mohamed Kamel";
            Book1.subject = "C Programming";
            Book1.book_id = 69288327;
            Book2.title = "C Programming";
            Book2.author = "Mohamed Kamel";
            Book2.subject = "C Programming";
            Book2.book_id = 69288327;
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            /* print Book2 info */
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);


        }
    }
}
