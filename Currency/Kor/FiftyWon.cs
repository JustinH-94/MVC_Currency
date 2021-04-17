using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Kor
{
    class FiftyWon: KorCoin
    {
        public FiftyWon(KrCoinMintMark mintMark) { }

        public FiftyWon()
        {
            Name = "FiftyWon";
            MonetaryValue = .005M;
            this.Year = System.DateTime.Now.Year;
            Portait = "Stalk Of Rice";
            ReverseMotif = "50";
        }

        public override string About()
        {
            return $"Korean 50 Won is from {this.Year}. It is worth {MonetaryValue:c}. It was made in DaeJeon";
        }
    }
}
