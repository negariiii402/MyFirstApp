

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;

namespace entity
{
    [Table("Factor")]
   
    public class Factor{
        //primary key
        public int Id {get;set;}
        //foreign key
        public int CashierId { get; set; }
        public int CustomerId { get; set; }
        public Chashier Cashier { get; set; }
        public Customer Customer { get; set; }
        public List<FactorItem> FactorItems { get; set; }
  }

  
    public class FactorItem{
        public int Id { get; set; }
       public int FactorId{get; set;}
       public int BookId { get; set; }
       public Factor Factor { get; set; }
       public Book Book {get;set;}
    }
    
}