using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace RpgMysticalforge.Models
{
    public class CourseClass
    {
        public int id { get; set; }
        public string? CouseName { get; set; }
        public string? Description { get; set; }
        public Attributes Attributes { get; set; } = new Attributes(); 
        public List<string> SpecialAbilities { get; set; } = new List<string>();
    }
}