using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Kor
{
    class HundredWon : KorCoin
    {
        public HundredWon(KrCoinMintMark mintMark) { }

        public HundredWon()
        {
            Name = "HundredWon";
            MonetaryValue = .01M;
            this.Year = System.DateTime.Now.Year;
            Portait = "Yi Sun-Sin";
            ReverseMotif = "100";
        }

        public override string About()
        {
            return $"Korean 100 Won is from {this.Year}. It is worth {MonetaryValue:c}. It was made in DaeJeon";
        }
    }
}
