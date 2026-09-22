using System.ComponentModel.DataAnnotations;

namespace entity
{
    public class Chashier{
      
      public int Id {get; set;}
      public  string Name { get; set; }= string.Empty;
      public List<Factor> Factories { get; set; }= new List<Factor>();
    }
}