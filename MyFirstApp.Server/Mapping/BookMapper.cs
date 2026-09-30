using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity;
using MyFirstApp.Server.Dtos;

namespace MyFirstApp.Server.Mapping
{
    public static class BookMapper
    {
        public static BooksDto ToBookDto(this Book book)
        {
            return new BooksDto
            {
            Name= book.Name, 
            Author= book.Author,
            Price= book.Price, 
            Publisher= book.Publisher,      
            };
        }
        
    }
}