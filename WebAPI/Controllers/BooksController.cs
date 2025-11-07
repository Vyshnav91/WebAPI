using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        static private List<Book> books = new List<Book>
            {

             new Book { Id = 1, Author = "J.R.R. Tolkien", Title = "The Hobbit", YearPublished = 1937 },
             new Book { Id = 2, Author = "George Orwell", Title = "1984", YearPublished = 1949 },
             new Book { Id = 3, Author = "Harper Lee", Title = "To Kill a Mockingbird", YearPublished = 1960 },


            };
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = (from b in books
                        where b.Id == id
                        select b).FirstOrDefault();
            if (book == null)
                return NotFound();

            return Ok(book);

        }

        [HttpPost]
        public ActionResult<Book> AddBook(Book newBook)
        {

            if (newBook == null)
                return BadRequest();

            books.Add(newBook);

            return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);

        }

        [HttpPut("{id}")]

        public IActionResult UpdateBook(int id, Book updatedBook)
        {
            var book = (from b in books
                        where b.Id == id
                        select b
                         ).FirstOrDefault();

            if (book == null)
                return NotFound();

            book.Id = updatedBook.Id;
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.YearPublished = updatedBook.YearPublished;

            return NoContent();


        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = (
                    from b in books
                    where b.Id == id
                    select b
                ).FirstOrDefault();

            if (book == null)
                return NotFound();

            books.Remove(book);
            return NoContent();


        }


    }




}   
