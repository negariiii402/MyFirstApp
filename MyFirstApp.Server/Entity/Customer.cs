using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class Customer{
       public int CustomerId {get; set;}
       public int PhoneNumber {get; set;}
       public string Name {get; set;}= string.Empty;
       public string Address {get; set;}= string.Empty;
       public List<Factor> Factories {get; set;}= new List<Factor>();
    }
}