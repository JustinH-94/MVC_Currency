using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_MVC.Models
{
    public class Pokemon : IPokemon
    {
        public int Level { get; set; }
        public string Name { get; set; }
        public string AttackMove { get; set; }
        public string Type { get; set; }

        public Pokemon() : this("Pokemon") { }
        public Pokemon(string name) : this(name, 1, "Normal", "Tackle") { }
        public Pokemon(string name, int lvl, string type, string attackMove) {
            this.Name = name;
            this.Level = lvl;
            this.AttackMove = attackMove;
            this.Type = type;
        }

        public virtual void LevelUp()
        {
            this.Level++;
        }

        public string About()
        {
            return $"{this.Name} is a {this.Type} Pokemon. Its current level is {this.Level} and knows {this.AttackMove}";
        }

    }
}
