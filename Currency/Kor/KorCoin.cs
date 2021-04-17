using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Kor
{
    public class KorCoin : Coin
    {
        static List<ICoin> krCoin = new List<ICoin>();
        public KrCoinMintMark MintMark { get; set; }
        public KorCoin() { }
        public KorCoin(KrCoinMintMark mintMark)
        {

        }

        public override string About()
        {
            string strAbout = "";
            return "Korea " + strAbout; 
        }

        public static string GetMintNameFromMark(KrCoinMintMark mintMark)
        {
            string MintName = "";
            if (mintMark == KrCoinMintMark.D)
                return "Daejeon";
            return MintName;
        }

        public static List<ICoin> GetKorCoinList()
        {
            krCoin.Add(new Obaegwon());
            return krCoin;
        }

    }

    public enum KrCoinMintMark
    {
        D
    }
}
