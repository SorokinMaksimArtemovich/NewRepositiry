using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Procurement
    {
        public readonly List<KeyValuePair<string, int>> Purchases;
        public Procurement()
        {
            Purchases = new List<KeyValuePair<string, int>>();
        }
        public void Add(string OtherGoodsName, int OtherGoodsCount)
        {
            var KVP = new KeyValuePair<string, int>(OtherGoodsName, OtherGoodsCount);
            Purchases.Add(KVP);
        }
    }
}
