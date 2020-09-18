using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();

        static TraderFactory()
        {
            Trader lou = new Trader("Lou");
            lou.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            Trader pauline = new Trader("Farmer Pauline");
            pauline.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            Trader myriam = new Trader("Myriam the Herbalist");
            myriam.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            AddTraderToList(lou);
            AddTraderToList(pauline);
            AddTraderToList(myriam);
        }

        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }

        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'.");
            }

            _traders.Add(trader);
        }
    }
}
