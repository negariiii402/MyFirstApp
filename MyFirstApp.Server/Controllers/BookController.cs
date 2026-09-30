using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity;
using MyFirstApp.Server.Dtos;
using MyFirstApp.Server.Mapping;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Server.Storage;

namespace MyFirstApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookController: Controller
    {
        private readonly RepositoryDbContext _dbContext;
        public BookController(RepositoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _dbContext.Books.ToList();

            List<BooksDto> booksDtos = new();

            foreach(var book in books)
            {
            var bookDto = new BooksDto()
                {
                Name =   book.Name,
                Author = book.Author,
                Price = book.Price,
                Publisher = book.Publisher
                };
                booksDtos.Add(bookDto);
            }

            return Ok(booksDtos);
        }

        [HttpGet("{Id}")]
        public IActionResult GetBookById(int Id)
        {
            var book = _dbContext.Books.Find(Id);

            var bookDto = new BooksDto()
            {
              Name =   book.Name,
              Author = book.Author,
              Price = book.Price,
              Publisher = book.Publisher
            };

            return Ok(bookDto);
        }

        [HttpPost]
        public IActionResult CreateBook()
        {
            
        }
        [HttpPut]
        public IActionResult UpdateBook()
        {
            
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteBook(int Id)
        {
            
        }

        

        
    }

}