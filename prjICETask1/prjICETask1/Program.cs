namespace prjICETask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books(67, "Harry Potter and the Chamber of Secrets", "Kelly Botha", 670.50);
            Books book2 = new Books(170, "How to be funny", "George Bekker", 0.10);

            Console.WriteLine("Book 1 Details");

            Console.WriteLine("ID: " + book1[0]);
            Console.WriteLine("Title: " + book1[1]);
            Console.WriteLine("Author: " + book1[2]);
            Console.WriteLine("Price: R" + book1[3]);

            Console.WriteLine();

            Console.WriteLine("Book's ID: " + book1["bookid"]);
            Console.WriteLine("Book Title: " + book1["booktitle"]);
            Console.WriteLine("Book Author: " + book1["bookauthor"]);
            Console.WriteLine("Book Price: R" + book1["price"]);

            Console.WriteLine();
            Console.WriteLine("Book 2 Details");

            Console.WriteLine("ID: " + book2[0]);
            Console.WriteLine("Title: " + book2[1]);
            Console.WriteLine("Author: " + book2[2]);
            Console.WriteLine("Price: R" + book2[3]);

            Console.WriteLine();

            Console.WriteLine("Book's ID: " + book2["bookid"]);
            Console.WriteLine("Book Title: " + book2["booktitle"]);
            Console.WriteLine("Book Author: " + book2["bookauthor"]);
            Console.WriteLine("Book Price: R" + book2["price"]);
        }
    }
}
