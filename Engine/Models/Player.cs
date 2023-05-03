using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player
    {
        private string Name { get; set; }
        private string CharacterClass { get; set; }
        private int HitPoints { get; set; }
        private int ExperiencePoints { get; set; }
        private int Level { get; set; }
        private int Gold { get; set; }

        public void setName(string playerName)
        {
            Name = playerName;
        }

        public void setGold(int gold) { 
            Gold = gold;
        }
    }
}
