using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace entity
{
    [Table("Books")]

       public class Book
    {
       public int Id {get; set;}
       public string Name {get; set;}= string.Empty;
       public string Author { get; set; }= string.Empty;
       [Column(TypeName = "decimal(18,2)")]
       public decimal Price { get; set; }
       public string Publisher { get; set; }= string.Empty;
    }
}