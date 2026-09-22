

using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class Factor{
        public int Id {get;set;}
        public int CustomerId {get;set;} 
        public int ChashierId {get;set;}
        public Chashier Cashier { get; set; }= new Chashier();
        public Customer Customer { get; set; }= new Customer();
    }
    public class FactorItem{
       public int FactorId{get; set;}
       public int CustomerId {get; set;}
       public int BookId {get;set;}
    }
}