using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgMysticalforge.Data.Dtos
{
    public class  CourseClassDTO
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public AttributesDTO Attributes { get; set; } = new AttributesDTO();
        public List<string> SpecialAbilities { get; set; } = new List<string>();
    }
}