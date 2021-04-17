using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.US
{
    public class USBankNote : BankNote
    {
        public override string About()
        {
            string bnAbout = $"{MonetaryValue} is 20 USD.";
            return base.About();
        }
    }
}
