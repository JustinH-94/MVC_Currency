using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    public class CurrencyRepo : ICurrencyRepo
    {
        decimal total, returnCost;
        public List<ICoin> Coins { get; set; }
        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public static ICurrencyRepo CreateChange(decimal Amount)
        {
            CurrencyRepo repo = new CurrencyRepo();
            return repo.MakeChange(Amount);
        }

        public static ICurrencyRepo CreateChange(decimal amountTendered, decimal TotalCost)
        {
            CurrencyRepo repo = new CurrencyRepo();
            return repo.MakeChange(amountTendered, TotalCost);
        }

        public string About()
        {
            throw new NotImplementedException();
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public int GetCoinCount()
        {
            return Coins.Count;
        }

        public int GetCoinCount(US.USCoin coin)
        {
            Coins.Add(coin);
            return Coins.Count;
        }

        public ICurrencyRepo MakeChange(decimal Amount)
        {
            ICoin coin;
            while (Amount > 0)
            {
                if (Amount >= 1) {
                    Amount -= 1;
                    coin = new US.DollarCoin();
                    Coins.Add(coin);
                    continue;
                }
                else if (Amount >= 0.5m)
                {
                    Amount -= 0.5m;
                    coin = new US.HalfDollar();
                    Coins.Add(coin);
                    continue;
                }
                else if (Amount >= 0.25m)
                {
                    Amount -= 0.25m;
                    coin = new US.Quarter();
                    Coins.Add(coin);
                    continue;
                }
                else if (Amount >= 0.10m)
                {
                    Amount -= 0.10m;
                    coin = new US.Dime();
                    Coins.Add(coin);
                    continue;
                }
                else if (Amount >= 0.05m)
                {
                    Amount -= 0.05m;
                    coin = new US.Nickel();
                    Coins.Add(coin);
                    continue;
                }
                else if (Amount >= 0.01m)
                {
                    Amount -= 0.01m;
                    coin = new US.Penny();
                    Coins.Add(coin);
                    continue;
                }
            }
            return this;
        }

        public ICurrencyRepo MakeChange(decimal AmountTendered, decimal TotalCost)
        {

            return (ICurrencyRepo)Coins;
        }

        public ICoin RemoveCoin(ICoin c)
        {
            Coins.Remove(c);
            return c;
        }

        public decimal TotalValue()
        {
            total = 0;
            foreach(ICoin c in Coins)
            {
                total += c.MonetaryValue;
            }
            return total;
        }
    }
}
