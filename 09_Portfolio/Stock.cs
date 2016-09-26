using System;

namespace _09_Portfolio
{
    internal class Stock
    {
        public Stock(string symbol, double pricePerShare, int numShares)
        {
            Symbol = symbol;
            PricePerShare = pricePerShare;
            NumShares = numShares;
        }

        public Stock()
        {

        }

        public int NumShares { get; internal set; }
        public double PricePerShare { get; internal set; }
        public string Symbol { get; internal set; }

        internal double GetValue()
        {
            return PricePerShare * NumShares;
        }

        internal static double TotalValue(Stock[] stocks)
        {
            return stocks[0].GetValue() + stocks[1].GetValue();
        }

        public override string ToString()
        {
            return "Stock[symbol="+Symbol+",pricePerShare="+PricePerShare+",numShares="+NumShares+"]";
        }

        public override bool Equals(object obj)
        {
            Stock abc = (Stock) obj;

            return (Symbol == abc.Symbol && PricePerShare == abc.PricePerShare && NumShares == abc.NumShares);
        }
    }
}