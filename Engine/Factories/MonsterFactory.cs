using Engine.Models;
using System;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonsterByID(int monsterId)
        {
            switch (monsterId)
            {
                case 1:
                    Monster snake = new Monster("Snake", "Snake.png", 4, 4, 1, 2, 5, 1);

                    AddLootItem(snake, 9001, 25);
                    AddLootItem(snake, 9002, 75);

                    return snake;

                case 2:
                    Monster rat = new Monster("Rat", "Rat.png", 5, 5, 1, 2, 5, 1);

                    AddLootItem(rat, 9003, 25);
                    AddLootItem(rat, 9004, 75);

                    return rat;

                case 3:
                    Monster spider = new Monster("Spider", "Spider.png", 10, 10, 1, 4, 10, 3);

                    AddLootItem(spider, 9005, 25);
                    AddLootItem(spider, 9006, 75);

                    return spider;

                default:
                    throw new ArgumentException($"MonsterType '{monsterId}' does not exists");
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int dropRatePercentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= dropRatePercentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}
