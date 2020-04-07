using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Goods
    {
        private string Name;
        private int Count;
        private double Cost;
        private int ShopID;
        public Goods(string GoodsName, int GoodsCount, double GoodsCost, int ShopIdentifier)
        {
            Name = GoodsName;
            Count = GoodsCount;
            Cost = GoodsCost;
            ShopID = ShopIdentifier;
        }
        public void Add(int OtherCount)
        {
            Count += OtherCount;
        }
        public string GetName()
        {
            return Name;
        }
        public int GetCount()
        {
            return Count;
        }
        public double GetCost()
        {
            return Cost;
        }
        public int GetShopID()
        {
            return ShopID;
        }
    }
}
