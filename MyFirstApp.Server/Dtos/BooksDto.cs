using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity;
namespace MyFirstApp.Server.Dtos
{
    public class BooksDto
    {
       public string Name {get; set;}= string.Empty;
       public string Author { get; set; }= string.Empty;
       public decimal Price { get; set; }
       public string Publisher { get; set; }= string.Empty;

        internal object GetAllBooks()
        {
            throw new NotImplementedException();
        }
    }
}