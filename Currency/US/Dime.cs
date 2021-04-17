using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Currency.US
{
    public class Dime : USCoin
    {
        public Dime(USCoinMintMark MintMark)
        {
            
        }

        public Dime() 
        {
            Name = "Dime";
            MonetaryValue = .1M;
            this.Year = System.DateTime.Now.Year;
            Portait = "Franklin D. Roosevelt";
            ReverseMotif = "torch, oak branch, olive branch";
        }

        public override string About()
        {
            return $"US Dime is from {System.DateTime.Now.Year}. It is worth {MonetaryValue:c}. It was made in Denver";
        }
    }
}
