using Microsoft.AspNetCore.Mvc;
using YaelFrankAPILibrary.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YaelFrankAPILibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Books : ControllerBase
    {

        public static DataContext data ;
        public Books(DataContext d)
        {
            data = d;  
        }

        // GET: api/<Books>
        [HttpGet]
        public List<Book> Get()
        {
            return data.books;
        }

        // GET api/<Books>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return data.books[id];
        }

        // POST api/<Books>
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            data.books.Add(value);
        }

        // PUT api/<Books>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book updatedBook)
        {
            Book b = data.books.Find(x => x.BookId == id);
            if (b != null)
            {
                if (!string.IsNullOrEmpty(updatedBook.Name)&& updatedBook.Name!= "string")
                {
                    b.Name = updatedBook.Name;
                }

                if (updatedBook.NumberOfPages != 0)
                {
                    b.NumberOfPages = updatedBook.NumberOfPages;
                }
            }
        }



        // DELETE api/<Books>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            data.books.Remove(data.books.Find(x => x.BookId == id));


        }
    }
}
