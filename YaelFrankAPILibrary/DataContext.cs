using YaelFrankAPILibrary.Entities;

namespace YaelFrankAPILibrary
{
    public class DataContext
    {
        public  List<Book> books;
        public  List<Loan> loans;
        public  List<Member> members;
        public DataContext()
        {
            books = new List<Book>
        {
        new Book { Name = "The Great Gatsby", NumberOfPages = 180 },
        new Book { Name = "To Kill a Mockingbird", NumberOfPages = 320 },
        new Book { Name = "1984", NumberOfPages = 328 },
        new Book { Name = "Pride and Prejudice", NumberOfPages = 432 }
          };
            loans = new List<Loan>
        {
        new Loan { Name = "John Doe", Date = DateTime.Now },
        new Loan { Name = "Jane Smith", Date = DateTime.Now.AddDays(-5) },
        new Loan { Name = "Michael Johnson", Date = DateTime.Now.AddDays(-2) }
         };

            members = new List<Member>
        {
        new Member { Name = "John Doe", Age = 25 },
        new Member { Name = "Jane Smith", Age = 30 },
        new Member { Name = "Michael Johnson", Age = 35 },
        new Member { Name = "Emily Davis", Age = 28 }
        };
        }

    }
}
