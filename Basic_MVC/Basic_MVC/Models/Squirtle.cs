using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_MVC.Models
{
    public class Squirtle : Pokemon
    {
        public string attackMove
        {
            get { return this.AttackMove; }
            set
            {
                this.AttackMove = value;
            }
        }

        public Squirtle() : this("Squirtle", 1, "Water", "WaterGun") { }

        public Squirtle(string name, int lvl, string type, string attackMove)
        {
            this.Name = name;
            this.Level = lvl;
            this.Type = type;
            this.AttackMove = attackMove;
        }

        public string UseAttack()
        {
            return $"{this.Name} used {this.attackMove}";
        }
    }
}
