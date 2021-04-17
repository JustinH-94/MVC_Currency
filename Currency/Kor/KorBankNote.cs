using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Kor
{
    class KorBankNote : BankNote
    {
        public override string About()
        {
            string bnAbout = $"{MonetaryValue} is 5000 won.";
            return base.About();
        }
    }
}
