using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Service
    {
        private static Service Instance = null;
        private DataAccessObject DataAccess;
        private static int CountOfShop = 0;
        private Service(string DataAccessDevice)
        {
            if (DataAccessDevice == "DataBase")
            {
                DataAccess = new DataBaseAccessObject();
                CountOfShop = DataAccess.GetCountOfShop();
            }
            if (DataAccessDevice == "File")
            {
                DataAccess = new DataFileAccessObject();
                CountOfShop = DataAccess.GetCountOfShop();
            }
        }
        public static Service GetInstance(string DataAccessDevice)
        {
            if (Instance == null)
            {
                Instance = new Service(DataAccessDevice);
            }
            return Instance;
        }
        public void Add(string ShopName, string GoodsName, int GoodsCount)
        {
            int ShopID = DataAccess.IsShopExist(ShopName);
            Goods AddedGoods = GoodsInShop(ShopName, GoodsName);
            AddedGoods.Add(GoodsCount);
            DataAccess.AddGoods(AddedGoods);
        }
        public void Add(string ShopName, string GoodsName, int GoodsCount, double GoodsCost)
        {
            int ShopID = DataAccess.IsShopExist(ShopName);
            if (ShopID == -1)
            {
                ShopID = CountOfShop;
                CountOfShop++;
                DataAccess.AddShop(ShopName, ShopID);
            }
            Goods AddedGoods = new Goods(GoodsName, GoodsCount, GoodsCost, ShopID);
            DataAccess.AddGoods(AddedGoods);
        }
        public KeyValuePair<string,double> SearchCheapestShop(string GoodsName)
        {
            int ID = -1;
            double LowestCost = -1;
            KeyValuePair<string, double> KVP;
            List<Goods> ListOfGoods = DataAccess.ListOfGoods(GoodsName);
            foreach (var i in ListOfGoods)
            {
                if (LowestCost == -1 || (i.GetCost() < LowestCost && i.GetCount() != 0))
                {
                    ID = i.GetShopID();
                    LowestCost = i.GetCost();
                }
            }
            KVP = new KeyValuePair<string, double>(DataAccess.GetShop(ID), LowestCost);
            return KVP;
        }
        public Procurement SearchGoodsByMoney(string ShopName, double AmountOfMoney)
        {
            int ShopID = DataAccess.IsShopExist(ShopName);
            List<Goods> ListOfGoods = DataAccess.SelectGoodsByShop(ShopID);
            var Ans = new Procurement();
            foreach (var i in ListOfGoods)
            {
                if (i.GetCost() < AmountOfMoney)
                {
                    int Count = Convert.ToInt32(Math.Truncate(AmountOfMoney / i.GetCost()));
                    Ans.Add(i.GetName(), Count); 
                }
            }
            return Ans;
        }
        public double GetCost(string Shop, Procurement ProcurementOfGoods)
        {
            double TotalCost = 0;
            foreach (var i in ProcurementOfGoods.Purchases)
            {
                int ShopID = DataAccess.IsShopExist(Shop);
                if (ShopID != -1 && GoodsInShop(Shop, i.Key) != null && GoodsInShop(Shop, i.Key).GetCount() > i.Value)
                {

                    TotalCost += GoodsInShop(Shop, i.Key).GetCost() * i.Value;
                }
                else
                {
                    return -1;
                }
            }
            return TotalCost;
        }
        public bool Buy(string Shop, Procurement ProcurementOfGoods)
        {
            int ShopID;
            if ((ShopID = DataAccess.IsShopExist(Shop)) != -1)
            {
                bool IsCorrect = true;
                foreach (var i in ProcurementOfGoods.Purchases)
                {
                    Goods iGoods = GoodsInShop(Shop, i.Key);
                    IsCorrect &= (iGoods != null && iGoods.GetCount() >= i.Value);
                }
                if (IsCorrect)
                {
                    DataAccess.DeleteGoods(ShopID, ProcurementOfGoods);
                    return true;
                }
            }
            return false;
        }
        public KeyValuePair<string, double> SearchCheapestShop(Procurement ProcurementOfGoods)
        {
            int ID = -1;
            double LowestCost = -1;
            KeyValuePair<string, double> KVP;
            for (int i = 0; i < CountOfShop; i++)
            {
                double CostInShop = GetCost(DataAccess.GetShop(i), ProcurementOfGoods);
                if (CountOfShop != -1 && (LowestCost < CostInShop || LowestCost == -1))
                {
                    LowestCost = CostInShop;
                    ID = i;
                }
            }
            KVP = new KeyValuePair<string, double>(DataAccess.GetShop(ID), LowestCost);
            return KVP;
        }
        public Goods GoodsInShop(string ShopName, string GoodsName)
        {
            int ShopID = DataAccess.IsShopExist(ShopName);
            List<Goods> ListOfGoods;
            if ((ListOfGoods = DataAccess.ListOfGoods(GoodsName)) != null)
            {
                foreach (var i in ListOfGoods)
                {
                    if (i.GetShopID() == ShopID)
                    {
                        return i;
                    }
                }
            }
            return null;
        }
        public bool IsShopExists(string ShopName)
        {
            return DataAccess.IsShopExist(ShopName) != -1;
        }
    }
}
