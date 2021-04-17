using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    public abstract class USCoin : Coin
    {
        static List<ICoin> usCoins = new List<ICoin>();
        public USCoinMintMark MintMark  { get; set; }

        public USCoin()
        {
            
        }

        public USCoin(USCoinMintMark MintMark)
        {
            
        }

        /// <summary>
        /// Tells informatrion about  a US Coin
        /// </summary>
        /// <returns></returns>
        public override string About()
        {
            string strAbout = "";
            
            return "US " + strAbout;
        }

        /// <summary>
        /// Returns the full name of a coind Mint Mark
        /// </summary>
        /// <param name="MintMark"></param>
        /// <returns>Full Mint Namt</returns>
        public static string GetMintNameFromMark(USCoinMintMark MintMark)
        {
            string MintName = "";
            if (MintMark == USCoinMintMark.D)
                return "Denver";
            if (MintMark == USCoinMintMark.P)
                return "Philadephia";
            if (MintMark == USCoinMintMark.S)
                return "San Francisco";
            if (MintMark == USCoinMintMark.W)
                return "West Point";
            return MintName;
        }

        public static List<ICoin> GetUSCoinList()
        {

            usCoins.Add(new DollarCoin());
            usCoins.Add(new HalfDollar()); 
            usCoins.Add(new Quarter()); 
            usCoins.Add(new Dime()); 
            usCoins.Add(new Nickel());
            usCoins.Add(new Penny());
            return usCoins;

        }

    }

    public enum USCoinMintMark
    {
        P, D, S, W
    }
}
