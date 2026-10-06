using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using entity;

namespace MyFirstApp.Server.Dtos
{
    public class ChachierDto
    {
        public  string Name { get; set; }= string.Empty;
        public List<Factor> Factories { get; set; }= new List<Factor>();
    }
}