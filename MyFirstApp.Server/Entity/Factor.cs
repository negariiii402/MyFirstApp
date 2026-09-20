namespace entity
{
    public class Factor{
        public int Id {get;set;}
        public int CustomerId {get;set;} 
        public int ChashierId {get;set;}
        public Cashier Cashier { get; set; }
        public Customrt Customer { get; set; }
    }
    public class FactorItem{
       public int FactorId{get; set;}
       public int BookId {get;set;}
    }
}