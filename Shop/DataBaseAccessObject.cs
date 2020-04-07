using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Configuration;

namespace Lab_5
{
    class DataBaseAccessObject : DataAccessObject
    {
        SQLiteConnection Connection;
        SQLiteFactory Factory;
        SQLiteCommand Command;
        SQLiteDataReader Reader;
        public DataBaseAccessObject()
        {
            if (!File.Exists("ShopBace.db3"))
            {
                SQLiteConnection.CreateFile("ShopBace.db3");
            }
            DbProviderFactories.RegisterFactory("System.Data.SQLite", SQLiteFactory.Instance);
            Factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
            Connection = (SQLiteConnection)Factory.CreateConnection();
            Connection.ConnectionString = "Data Source = ShopBace.db3";
            Connection.Open();
            using (Command = new SQLiteCommand(Connection))
            {
                Command.CommandText = @"CREATE TABLE IF NOT EXISTS [Shops] (
                    [id] INT NOT NULL,
                    [name] TEXT NOT NULL
                    );";
                Command.CommandType = CommandType.Text;
                Command.ExecuteNonQuery();
                Command.CommandText = @"CREATE TABLE IF NOT EXISTS [Goods] (
                    [name] TEXT NOT NULL,
                    [shop] INT NOT NULL,
                    [cost] REAL NOT NULL,
                    [count] INT NOT NULL
                    );";
                Command.CommandType = CommandType.Text;
                Command.ExecuteNonQuery();
            }
        }
        override public int GetCountOfShop()
        {
            int Count = 0;
            Command = new SQLiteCommand("SELECT [id] FROM [Shops]", Connection);
            Reader = Command.ExecuteReader();
            while (Reader.Read())
            {
                Count++;
            }
            return Count;
        }
        override public void AddShop(string ShopName, int ShopID)
        {
            Command = new SQLiteCommand("INSERT INTO Shops (id, name) VALUES (@ID, @Name)", Connection);
            Command.Parameters.AddWithValue("@ID", ShopID);
            Command.Parameters.AddWithValue("@Name", ShopName);
            Command.ExecuteNonQuery();
        }
        override public void AddGoods(Goods NewGoods)
        {
            Command = new SQLiteCommand("SELECT * FROM [Goods] WHERE [name] = @Name AND [shop] = @ShopID", Connection);
            Command.Parameters.AddWithValue("@Name", NewGoods.GetName());
            Command.Parameters.AddWithValue("@ShopID", NewGoods.GetShopID());
            Reader = Command.ExecuteReader();
            int Count = -1;
            float Cost = -1;
            while (Reader.Read())
            {
                Count = (int)Reader["count"];
                Cost =  (float)Reader["cost"];
            }
            if (Count != -1)
            {
                Count += NewGoods.GetCount();
                if (Cost != NewGoods.GetCost())
                {
                    Command = new SQLiteCommand("UPDATE [Goods] SET [cost] = @Cost WHERE [name] = @Name AND [shop] = @ShopID", Connection);
                    Command.Parameters.AddWithValue("@Name", NewGoods.GetName());
                    Command.Parameters.AddWithValue("@ShopID", NewGoods.GetShopID());
                    Command.Parameters.AddWithValue("@Cost", NewGoods.GetCost());
                    Command.ExecuteNonQuery();
                }
                else
                {
                    Command = new SQLiteCommand("UPDATE [Goods] SET [count] = @Count WHERE [name] = @Name AND [shop] = @ShopID", Connection);
                    Command.Parameters.AddWithValue("@Name", NewGoods.GetName());
                    Command.Parameters.AddWithValue("@ShopID", NewGoods.GetShopID());
                    Command.Parameters.AddWithValue("@Count", Count);
                    Command.ExecuteNonQuery();
                }
            }
            else
            {
                Command = new SQLiteCommand("INSERT INTO Goods (name, shop, cost, count) VALUES (@Name, @ShopID, @Cost, @Count)", Connection);
                Command.Parameters.AddWithValue("@Name", NewGoods.GetName());
                Command.Parameters.AddWithValue("@ShopID", NewGoods.GetShopID());
                Command.Parameters.AddWithValue("@Cost", NewGoods.GetCost());
                Command.Parameters.AddWithValue("@Count", NewGoods.GetCount());
                Command.ExecuteNonQuery();
            }
        }
        override public int IsShopExist(string ShopName)
        {
            Command = new SQLiteCommand("SELECT [id] FROM [Shops] WHERE [name] = @Name", Connection);
            Command.Parameters.AddWithValue("@Name", ShopName);
            Reader = Command.ExecuteReader();
            int ID = -1;
            while (Reader.Read())
            {
                ID = (int)Reader["id"];
            }
            return ID;
        }
        override public string GetShop(int ShopID)
        {
            Command = new SQLiteCommand("SELECT [name] FROM [Shops] WHERE [id] = @ID", Connection);
            Command.Parameters.AddWithValue("@ID", ShopID);
            Reader = Command.ExecuteReader();
            string Name = null;
            while (Reader.Read())
            {
                Name = (string)Reader["name"];
            }
            return Name;
        }
        override public List<Goods> ListOfGoods(string GoodsName)
        {
            Command = new SQLiteCommand("SELECT * FROM [Goods] WHERE [name] = @Name", Connection);
            Command.Parameters.AddWithValue("@Name", GoodsName);
            Reader = Command.ExecuteReader();
            var LOG = new List<Goods>();
            Goods ReturnedGoods;
            string Name;
            double Cost;
            int ID, Count;
            while (Reader.Read())
            {
                Name = (string)Reader["name"];
                ID = (int)Reader["shop"];
                Cost = (double)Reader["cost"];
                Count = (int)Reader["count"];
                ReturnedGoods = new Goods(Name, Count, Cost, ID);
                LOG.Add(ReturnedGoods);
            }
            return LOG;
        }
        override public List<Goods> SelectGoodsByShop(int ShopID)
        {
            Command = new SQLiteCommand("SELECT * FROM [Goods] WHERE [shop] = @ShopID", Connection);
            Command.Parameters.AddWithValue("@ShopID", ShopID);
            Reader = Command.ExecuteReader();
            var LOG = new List<Goods>();
            Goods ReturnedGoods;
            string Name;
            double Cost;
            int ID, Count;
            while (Reader.Read())
            {
                Name = (string)Reader["name"];
                ID = (int)Reader["shop"];
                Cost = (double)Reader["cost"];
                Count = (int)Reader["count"];
                ReturnedGoods = new Goods(Name, ID, Cost, Count);
                LOG.Add(ReturnedGoods);
            }
            return LOG;
        }
        override public void DeleteGoods(int ShopID, Procurement ProcurementOfGoods)
        {
            for (int i = 0; i < ProcurementOfGoods.Purchases.Count; i++)
            {
                Command = new SQLiteCommand("SELECT [count] FROM [Goods] WHERE [name] = @Name AND [shop] = @ShopID", Connection);
                Command.Parameters.AddWithValue("@Name", ProcurementOfGoods.Purchases[i].Key);
                Command.Parameters.AddWithValue("@ShopID", ShopID);
                Reader = Command.ExecuteReader();
                int Count = -1;
                while (Reader.Read())
                {
                    Count = (int)Reader["count"] - ProcurementOfGoods.Purchases[i].Value;
                }
                if (Count != 0)
                {
                    Command = new SQLiteCommand("UPDATE [Goods] SET [count] = @Count WHERE [name] = @Name AND [shop] = @ShopID", Connection);
                    Command.Parameters.AddWithValue("@Name", ProcurementOfGoods.Purchases[i].Key);
                    Command.Parameters.AddWithValue("@ShopID", ShopID);
                    Command.Parameters.AddWithValue("@Count", Count);
                    Command.ExecuteNonQuery();
                }
                else
                {
                    Command = new SQLiteCommand("DELETE FROM [Goods] WHERE [name] = @Name AND [shop] = @ShopID", Connection);
                    Command.Parameters.AddWithValue("@Name", ProcurementOfGoods.Purchases[i].Key);
                    Command.Parameters.AddWithValue("@ShopID", ShopID);
                    Command.ExecuteNonQuery();
                }
            }
        }
    }
}
