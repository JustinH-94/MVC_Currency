using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Kor
{
    public class Obaegwon : KorCoin
    {
        public Obaegwon()
        {
            Name = "Obaegwon";
            MonetaryValue = .5M;
            this.Year = System.DateTime.Now.Year;
            Portait = "Red-Crowned Crane";
            ReverseMotif = "500";
        }

        public override string About()
        {
            return $"Korean Obaegwon is from {this.Year}. It is worth {MonetaryValue:c}. It was made in DaeJeon.";
        }
    }
}
