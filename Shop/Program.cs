using System;
using System.IO;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-GB");
            string DataAccessDevice = null;
            if (!File.Exists("Lab_5.property"))
            {
                Console.Write("File \"Lab_5.property\" does not exist");
                return;
            }
            using (StreamReader Reader = new StreamReader("Lab_5.property"))
            {
                string Line, FirstWord = "", SecondWord = "";
                bool IsNotFound = true;
                while ((Line = Reader.ReadLine()) != null)
                {
                    IsNotFound = true;
                    foreach (var i in Line)
                    {
                        if (i != '=' && i != ':')
                        {
                            if (i != ' ')
                            {
                                if (IsNotFound)
                                {
                                    FirstWord += i;
                                }
                                else
                                {
                                    SecondWord += i;
                                }
                            }
                        }
                        else
                        {
                            IsNotFound = false;
                        }
                    }
                    if (FirstWord == "DataAccessDevice")
                    {
                        DataAccessDevice = SecondWord;
                    }
                }
            }
            if (DataAccessDevice == null)
            {
                Console.Write("Variable \"DataAccessDevice\" does not exist");
                return;
            }
            Service MainService = Service.GetInstance(DataAccessDevice);
            while (true)
            {
                int Count, Key;
                double Cost;
                string Shop, Goods;
                Procurement ThisProcurement;
                Goods ThisGoods;
                Console.WriteLine("If you want to add some goods to shop press 1");
                Console.WriteLine("If you want to buy some goods press 2");
                Console.WriteLine("If you want to exite press 3");
                Key = Console.ReadKey().KeyChar;
                if (Key == '1')
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter shop in which you want to add good");
                    Shop = Console.ReadLine();
                    Console.WriteLine("Enter good that you want to add");
                    Goods = Console.ReadLine();
                    ThisGoods = MainService.GoodsInShop(Shop, Goods);
                    Console.WriteLine("Enter count of goods that you want to add");
                    while (!Int32.TryParse(Console.ReadLine(), out Count))
                    {
                        Console.WriteLine("Enter correct count of goods");
                    }
                    if (ThisGoods != null)
                    {
                        bool NeedToBreak = false;
                        while (true)
                        {
                            Console.WriteLine("If you want to change cost press 1");
                            Console.WriteLine("If you don't want to change cost press 2");
                            Console.WriteLine("If you want to exite press 3");
                            Key = Console.ReadKey().KeyChar;
                            if (Key == '1')
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter cost of goods that you want to add");
                                while (!Double.TryParse(Console.ReadLine(), out Cost))
                                {
                                    Console.WriteLine("Enter correct cost of goods");
                                }
                                MainService.Add(Shop, Goods, Count, Cost);
                                Console.WriteLine("Goods were added");
                            }
                            else if (Key == '2')
                            {
                                Console.WriteLine();
                                MainService.Add(Shop, Goods, Count);
                                Console.WriteLine("Goods were added");
                            }
                            else if (Key == '3')
                            {
                                Console.WriteLine();
                                NeedToBreak = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("You write wrong key");
                            }
                        }
                        if (NeedToBreak)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter cost of goods that you want to add");
                        while (!Double.TryParse(Console.ReadLine(), out Cost))
                        {
                            Console.WriteLine("Enter correct cost of goods");
                        }
                        MainService.Add(Shop, Goods, Count, Cost);
                        Console.WriteLine("Goods were added");
                    }
                }
                else if (Key == '2')
                {
                    Console.WriteLine();
                    Console.WriteLine("If you want to find out cost of goods press 1");
                    Console.WriteLine("If you want to find out what goods can you buy on the entered sum press 2");
                    Console.WriteLine("If you want to buy some goods press 3");
                    Console.WriteLine("If you want to exite press 4");
                    Key = Console.ReadKey().KeyChar;
                    if (Key == '1')
                    {
                        Console.WriteLine();
                        Console.WriteLine("If you want to find out cost of one good press 1");
                        Console.WriteLine("If you want to find out cost of list of goods press 2");
                        Console.WriteLine("If you want to exite press 3");
                        Key = Console.ReadKey().KeyChar;
                        if (Key == '1')
                        {
                            Console.WriteLine();
                            Console.WriteLine("Enter good that you want to find");
                            Goods = Console.ReadLine();
                            Shop = MainService.SearchCheapestShop(Goods).Key;
                            Cost = MainService.SearchCheapestShop(Goods).Value;
                            Console.Write("Cheapest shop is: ");
                            Console.Write(Shop);
                            Console.Write(". There in will cost: ");
                            Console.WriteLine(Cost);
                        }
                        else if (Key == '2')
                        {
                            Console.WriteLine();
                            bool NeedToBreak = false;
                            ThisProcurement = new Procurement();
                            while (true)
                            {
                                Console.WriteLine("If you want to add good press 1");
                                Console.WriteLine("If you finish include goods press 2");
                                Console.WriteLine("If you want to exite press 3");
                                Key = Console.ReadKey().KeyChar;
                                if (Key == '1')
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Enter name of good");
                                    Goods = Console.ReadLine();
                                    Console.WriteLine("Enter count of goods");
                                    while (!Int32.TryParse(Console.ReadLine(), out Count))
                                    {
                                        Console.WriteLine("Enter correct count of goods");
                                    }
                                    ThisProcurement.Add(Goods, Count);
                                }
                                else if (Key == '2')
                                {
                                    Console.WriteLine();
                                    break;
                                }
                                else if (Key == '3')
                                {
                                    Console.WriteLine();
                                    NeedToBreak = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("You write wrong key");
                                }
                            }
                            if (NeedToBreak)
                            {
                                break;
                            }
                            Shop = MainService.SearchCheapestShop(ThisProcurement).Key;
                            Cost = MainService.SearchCheapestShop(ThisProcurement).Value;
                            Console.Write("Cheapest shop is: ");
                            Console.Write(Shop);
                            Console.Write(". There in will cost: ");
                            Console.WriteLine(Cost);
                        }
                        else if (Key == '3')
                        {
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("You write wrong key");
                        }
                    }
                    else if (Key == '2')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter shop where you want to buy");
                        Shop = Console.ReadLine();
                        if (MainService.IsShopExists(Shop))
                        {
                            Console.WriteLine("Enter sum thet you can spend");
                            while (!Double.TryParse(Console.ReadLine(), out Cost))
                            {
                                Console.WriteLine("Enter correct sum");
                            }
                            ThisProcurement = MainService.SearchGoodsByMoney(Shop, Cost);
                            foreach (var i in ThisProcurement.Purchases)
                            {
                                Console.Write("You can buy ");
                                Console.Write(i.Key);
                                Console.Write(" in the amount of ");
                                Console.Write(i.Value);
                                Console.WriteLine(" pieces.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("We havn't information about this shop");
                        }
                    }
                    else if (Key == '3')
                    {
                        Console.WriteLine();
                        bool NeedToBreak = false;
                        Console.WriteLine("Enter name of shop");
                        Shop = Console.ReadLine();
                        ThisProcurement = new Procurement();
                        while (true)
                        {
                            Console.WriteLine("If you want to add good press 1");
                            Console.WriteLine("If you finish include goods press 2");
                            Console.WriteLine("If you want to exite press 3");
                            Key = Console.ReadKey().KeyChar;
                            if (Key == '1')
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter name of good");
                                Goods = Console.ReadLine();
                                Console.WriteLine("Enter count of goods");
                                while (!Int32.TryParse(Console.ReadLine(), out Count))
                                {
                                    Console.WriteLine("Enter correct count of goods");
                                }
                                ThisProcurement.Add(Goods, Count);
                            }
                            else if (Key == '2')
                            {
                                Console.WriteLine();
                                break;
                            }
                            else if (Key == '3')
                            {
                                Console.WriteLine();
                                NeedToBreak = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("You write wrong key");
                            }
                        }
                        if (NeedToBreak)
                        {
                            break;
                        }
                        if (MainService.GetCost(Shop, ThisProcurement) != -1)
                        {
                            while (true)
                            {
                                Console.Write("It will cost: ");
                                Console.WriteLine(MainService.GetCost(Shop, ThisProcurement));
                                Console.WriteLine("Do you want to buy it?");
                                Console.WriteLine("If you want to buy it press 1");
                                Console.WriteLine("If you want to return to mait menu press 2");
                                Console.WriteLine("If you want to exite press 3");
                                Key = Console.ReadKey().KeyChar;
                                if (Key == '1')
                                {
                                    Console.WriteLine();
                                    if (MainService.Buy(Shop, ThisProcurement))
                                    {
                                        Console.WriteLine("Goods successfully bought.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Opetation was failed.");
                                    }
                                    break;
                                }
                                else if (Key == '2')
                                {
                                    Console.WriteLine();
                                    break;
                                }
                                else if (Key == '3')
                                {
                                    Console.WriteLine();
                                    NeedToBreak = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("You write wrong key");
                                }
                            }
                            if (NeedToBreak)
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opperation was failed");
                        }
                    }
                    else if (Key == '4')
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("You write wrong key");
                    }
                }
                else if (Key == '3')
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You write wrong key");
                }
            }
        }
    }
}
