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
        public static Book ToBookDto(this Book book)
        {
            return new Book
            {
            Id= book.Id, 
            Name= book.Name, 
            Author= book.Author,
            Price= book.Price, 
            Publisher= book.Publisher,      
            };
        }
        
    }
}