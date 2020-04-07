using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab_5
{
    class DataFileAccessObject : DataAccessObject
    {
        StreamWriter ShopsWriter;
        StreamWriter GoodsWriter;
        StreamReader ShopsReader;
        StreamReader GoodsReader;
        string ShopFile = "Shops.csv", GoodsFile = "Goods.csv";
        public DataFileAccessObject(){ }
        override public void AddShop(string ShopName, int ShopID)
        {
            using (ShopsWriter = new StreamWriter(ShopFile, true))
            {
                ShopsWriter.Write(ShopID);
                ShopsWriter.Write(",");
                ShopsWriter.WriteLine(ShopName);
            }
        }
        override public int GetCountOfShop()
        {
            int Count = 0;
            using (ShopsReader = new StreamReader(ShopFile))
            {
                string Line;
                while ((Line = ShopsReader.ReadLine()) != null)
                {
                    Count++;
                }
            }
            return Count;
        }
        private List<List<string>> Split(string Text)
        {
            var AllLines = new List<List<string>>();
            var Lines = new List<string>();
            string SmallLine = "";
            foreach (var i in Text)
            {
                if (i != '\r')
                {
                    if (i != '\n')
                    {
                        if (i != ',')
                        {
                            SmallLine += i;
                        }
                        else
                        {
                            Lines.Add(SmallLine);
                            SmallLine = "";
                        }
                    }
                    else
                    {
                        Lines.Add(SmallLine);
                        SmallLine = "";
                        AllLines.Add(Lines);
                        Lines = new List<string>();
                    }
                }
            }
            return AllLines;
        }
        private void Write(List<string> Lines, bool Append)
        {
            using (GoodsWriter = new StreamWriter(GoodsFile, Append))
            {
                for (int i = 0; i < Lines.Count; i++)
                {
                    if (i == 0)
                    {
                        GoodsWriter.Write(Lines[i]);
                    }
                    else
                    {
                        GoodsWriter.Write(",");
                        GoodsWriter.Write(Lines[i]);
                    }
                }
                GoodsWriter.WriteLine();
            }
        }
        override public void AddGoods(Goods NewGoods)
        {
            string Text;
            using (GoodsReader = new StreamReader(GoodsFile))
            {
                Text = GoodsReader.ReadToEnd();
            }
            List<List<string>> AllLines = Split(Text);
            bool IsFound = false;
            int j = 0;
            foreach (var Lines in AllLines)
            {
                if (Lines[0] == NewGoods.GetName())
                {
                    IsFound = false;
                    for (int i = 1; i + 2 < Lines.Count; i += 3)
                    {
                        if (Lines[i] == Convert.ToString(NewGoods.GetShopID()))
                        {
                            IsFound = true;
                            Lines[i + 1] = Convert.ToString(Convert.ToInt32(Lines[i + 1]) + NewGoods.GetCount());
                            if (Convert.ToSingle(Lines[i + 2]) != NewGoods.GetCost())
                            {
                                Lines[i + 2] = Convert.ToString(NewGoods.GetCost());
                            }
                            IsFound = true;
                            break;
                        }
                    }
                    if (!IsFound)
                    {
                        Lines.Add(Convert.ToString(NewGoods.GetShopID()));
                        Lines.Add(Convert.ToString(NewGoods.GetCount()));
                        Lines.Add(Convert.ToString(NewGoods.GetCost()));
                    }
                    IsFound = true;
                    if (j == 0)
                    {
                        Write(Lines, false);
                    }
                    else
                    {
                        Write(Lines, true);
                    }
                }
                j++;
            }
            if (!IsFound)
            {
                using (GoodsWriter = new StreamWriter(GoodsFile, true))
                {
                    GoodsWriter.Write(NewGoods.GetName());
                    GoodsWriter.Write(",");
                    GoodsWriter.Write(NewGoods.GetShopID());
                    GoodsWriter.Write(",");
                    GoodsWriter.Write(NewGoods.GetCount());
                    GoodsWriter.Write(",");
                    GoodsWriter.WriteLine(NewGoods.GetCost());
                }
            }
        }
        override public int IsShopExist(string ShopName)
        {
            using (ShopsReader = new StreamReader(ShopFile))
            {
                string Text;
                if ((Text = ShopsReader.ReadToEnd()) != "")
                {
                    List<List<string>> AllLines = Split(Text);
                    if (AllLines != null)
                    {
                        foreach (var i in AllLines)
                        {
                            if (i[1] == ShopName)
                            {
                                return Convert.ToInt32(i[0]);
                            }
                        }
                    }
                }
            }
            return -1;
        }
        override public string GetShop(int ShopID)
        {
            using (ShopsReader = new StreamReader(ShopFile))
            {
                string Text;
                if ((Text = ShopsReader.ReadToEnd()) != null)
                {
                    List<List<string>> AllLines = Split(Text);
                    foreach (var i in AllLines)
                    {
                        if (i[0] == Convert.ToString(ShopID))
                        {
                            return i[1];
                        }
                    }
                }
            }
            return null;
        }
        override public List<Goods> ListOfGoods(string GoodsName)
        {
            using (GoodsReader = new StreamReader(GoodsFile))
            {
                string Text;
                if ((Text = GoodsReader.ReadToEnd()) != "")
                {
                    List<List<string>> AllLines = Split(Text);
                    foreach (var i in AllLines)
                    {
                        if (i[0] == GoodsName)
                        {
                            var LOG = new List<Goods>();
                            Goods NewGoods;
                            for (int j = 1; j + 2 < i.Count; j += 3)
                            {
                                NewGoods = new Goods(i[0], Convert.ToInt32(i[j + 1]), Convert.ToSingle(i[j + 1]), Convert.ToInt32(i[j]));
                                LOG.Add(NewGoods);
                            }
                            return LOG;
                        }
                    }
                }
            }
            return null;
        }
        override public List<Goods> SelectGoodsByShop(int ShopID)
        {
            using (GoodsReader = new StreamReader(GoodsFile))
            {
                string Text;
                if ((Text = GoodsReader.ReadToEnd()) != "")
                {
                    var LOG = new List<Goods>();
                    Goods NewGoods;
                    List<List<string>> AllLines = Split(Text);
                    foreach (var i in AllLines)
                    {
                        for (int j = 1; j + 2 < i.Count; j += 3)
                        {
                            if (i[j] == Convert.ToString(ShopID))
                            {
                                NewGoods = new Goods(i[0], Convert.ToInt32(i[j + 1]), Convert.ToSingle(i[j + 1]), Convert.ToInt32(i[j]));
                                LOG.Add(NewGoods);
                            }
                        }
                    }
                    if (LOG.Count != 0)
                    {
                        return LOG;
                    }
                }
            }
            return null;
        }
        override public void DeleteGoods(int ShopID, Procurement ProcurementOfGoods)
        {
            bool IsNotNULL = false;
            string Text;
            using (GoodsReader = new StreamReader(GoodsFile))
            {
                IsNotNULL = (Text = GoodsReader.ReadToEnd()) != "";

            }
            if (IsNotNULL)
            {
                int t = 0;
                List<List<string>> AllLines = Split(Text);
                foreach (var i in AllLines)
                {
                    bool IsFound = false;
                    foreach (var k in ProcurementOfGoods.Purchases)
                    {
                        if (i[0] == k.Key)
                        {
                            for (int j = 1; j + 2 < i.Count; j += 3)
                            {
                                if (i[j] == Convert.ToString(ShopID))
                                {
                                    IsFound = true;
                                    i[j + 1] = Convert.ToString(Convert.ToInt32(i[j + 1]) - k.Value);
                                    if (t == 0)
                                    {
                                        Write(i, false);
                                    }
                                    else
                                    {
                                        Write(i, true);
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    if (!IsFound)
                    {
                        if (t == 0)
                        {
                            Write(i, false);
                        }
                        else
                        {
                            Write(i, true);
                        }
                    }
                    t++;
                }
            }
        }
    }
}
