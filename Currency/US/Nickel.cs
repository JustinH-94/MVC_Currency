using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    public class Nickel : USCoin
    {
        public Nickel(USCoinMintMark MintMark)
        {
            
        }

        public Nickel() : this(USCoinMintMark.D)
        {
            Name = "Nickey";
            MonetaryValue = 0.05M;
            ReverseMotif = "Monticello";
            Portait = "Thomas Jefferson";
        }

        public override string About()
        {

            return $"US Nickel is from {System.DateTime.Now.Year}. It is worth ${MonetaryValue}. It was made in Denver";
        }
    }
}
