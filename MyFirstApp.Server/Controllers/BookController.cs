using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity;
using MyFirstApp.Server.Dtos;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Server.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace MyFirstApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookController : Controller
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

            foreach (var book in books)
            {
                var bookDto = new BooksDto()
                {
                    Name = book.Name,
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
                Name = book.Name,
                Author = book.Author,
                Price = book.Price,
                Publisher = book.Publisher
            };

            return Ok(bookDto);
        }

        [HttpPost]
        public IActionResult CreateBook(BooksDto booksDto)
        {
            var book = new Book()
            {
                Name = booksDto.Name,
                Author = booksDto.Author,
                Price = booksDto.Price,
                Publisher = booksDto.Publisher,
            };
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return Ok(book);
        }
        [HttpPut("{Id}")]
        public IActionResult UpdateBook(int Id, BooksDto booksDto)
        {
            var book = _dbContext.Books.Find(Id);
            if (book is null)
            {
                return NotFound();
            }
            book.Name = booksDto.Name;
            book.Author = booksDto.Author;
            book.Price = booksDto.Price;
            book.Publisher = booksDto.Publisher;

            _dbContext.SaveChanges();
            return Ok(book);

        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteBook(int Id)
        {
            var book = _dbContext.Books.Find(Id);
            if (book is null)
            {
                return NotFound();
            }

            _dbContext.Books.Remove(book);

            _dbContext.SaveChanges();
            return Ok();
        }
    }
}