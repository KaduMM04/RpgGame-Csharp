using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgMysticalforge.Models
{
    public class  Attributes
    {
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }

        public Attributes(int intelligence = 0, int strength = 0, int dexterity = 0)
        {
            Intelligence = intelligence;
            Strength = strength;
            Dexterity = dexterity;
        }

        public Attributes Clone() {
            return new Attributes(Strength, Intelligence, Dexterity);
        }
    }
}