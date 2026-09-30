using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity;
using MyFirstApp.Server.Dtos;
using MyFirstApp.Server.Mapping;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookStore: Controller
    {
        private readonly BooksDto _booksDto;
        public BookStore (BooksDto booksDto)
        {
             _booksDto = booksDto;

        }
       
        [HttpGet]
        public IActionResult GetAllBooks(BooksDto booksDto)
        {
            var books= _booksDto.ToList();
            var book= _booksDto.GetAllBooks();

            return Ok(books);
        }

        [HttpGet("{Id}")]
        public IActionResult GetBookById(int Id)
        {
            var Book= 
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

    internal class _BooksDto
    {
    }
}