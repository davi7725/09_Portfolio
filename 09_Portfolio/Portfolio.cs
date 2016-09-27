using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        private List<IAsset> listOfAssets;
        public Portfolio(List<IAsset> stocks)
        {
            listOfAssets = stocks;
        }
        public Portfolio()
        {
            listOfAssets = new List<IAsset>();
        }

        public void AddAsset(IAsset asset)
        {
            listOfAssets.Add(asset);
        }  

        internal double GetTotalValue()
        {
            double totalValue = 0;
            foreach(IAsset stock in listOfAssets)
            {
                totalValue = totalValue + stock.GetValue();
            }
            return totalValue;
        }
    }
}