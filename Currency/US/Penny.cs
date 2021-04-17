using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    public class Penny : USCoin
    {

        public Penny(USCoinMintMark MintMark)
        {
            MintMark = USCoinMintMark.D;
        }

        public Penny() 
        {
            Name = "Penny";
            ReverseMotif = "Union shield";
            Portait = "Abraham Lincoln";
            MonetaryValue = 0.01M;
            Year = 2021;
            MintMark = USCoinMintMark.D;
        }

        public override string About()
        {
            return $"US Penny is from {System.DateTime.Now.Year}. It is worth {MonetaryValue:c}. It was made in Denver";
        }
    }
}
