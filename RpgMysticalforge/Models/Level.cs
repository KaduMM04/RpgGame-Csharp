using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgMysticalforge.Models
{
    public class Level
    {
        public int id { get; set; }
        public int CurrentXp { get; set; }
        public int CurrentLevel { get; set; }


        public void GainXp(int xp) {
            CurrentXp += xp;
            while (CurrentLevel >= XpToNextLevel()) {
                CurrentLevel -= XpToNextLevel();
                CurrentLevel++;
            }
        }

        private int XpToNextLevel() => CurrentLevel * 100;
    }
}