using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_MVC.Models
{
    public interface IPokemon
    {
        string Name { get; set; }
        int Level { get; set; }
        string Type { get; set; }
        string AttackMove { get; set; }

        void LevelUp();

    }
}
