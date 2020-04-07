using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    abstract class DataAccessObject
    {
        abstract public int IsShopExist(string ShopName);
        abstract public string GetShop(int ShopID);
        abstract public void AddShop(string ShopName, int ShopID);
        abstract public void AddGoods(Goods NewGoods);
        abstract public void DeleteGoods(int ShopID, Procurement ProcurementOfGoods);
        abstract public List<Goods> ListOfGoods(string GoodsName);
        abstract public List<Goods> SelectGoodsByShop(int ShopID);
        abstract public int GetCountOfShop();
    }
}
