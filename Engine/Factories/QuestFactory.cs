using Engine.Models;
using System.Collections.Generic;
using System.Linq;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1002, 1));

            Quest gardenQuest = new Quest(1, "Clear the herb garden", "Defeat the snakes in the Herbalist's garden. Bring back 5 fangs as a proof.", itemsToComplete, 25, 10, rewardItems);
            _quests.Add(gardenQuest);
        }

        /// <summary>
        /// Récupère une quête par son identifiant
        /// </summary>
        /// <param name="questId">Identifiant de la quête à récupérer</param>
        /// <returns>Un objet Quest</returns>
        internal static Quest GetQuestByID(int questId)
        {
            return _quests.FirstOrDefault(quest => quest.ID == questId);
        }
    }
}
