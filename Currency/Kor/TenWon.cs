using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Kor
{
    class TenWon : KorCoin
    {
        public TenWon(KrCoinMintMark mintMark) { }

        public TenWon()
        {
            Name = "TenWon";
            MonetaryValue = .001M;
            this.Year = System.DateTime.Now.Year;
            Portait = "Dabotap pagoda";
            ReverseMotif = "10";
        }

        public override string About()
        {
            return $"Korean 10 Won is from {this.Year}. It is worth {MonetaryValue:c}. It was made in DaeJeon";
        }
    }
}
