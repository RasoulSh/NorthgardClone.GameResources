using System;
using Northgard.Core.Abstraction.Logger;
using Northgard.GameResources.Enums;
using Zenject;

namespace Northgard.GameResources.Entities
{
    [Serializable]
    public class GameResourceCatalog
    {
        [Inject] private ILogger _logger;
        public int golds;
        public int foods;
        public int woods;
        public int irons;
        public int stones;
        public int lore;
        public int fame;

        public int GetResourceCount(GameResourceType resourceType)
        {
            switch (resourceType)
            {
                case GameResourceType.Gold:
                    return golds;
                case GameResourceType.Food:
                    return foods;
                case GameResourceType.Wood:
                    return woods;
                case GameResourceType.Iron:
                    return irons;
                case GameResourceType.Stone:
                    return stones;
                case GameResourceType.Lore:
                    return lore;
                case GameResourceType.Fame:
                    return fame;
                default:
                    _logger.LogError("The resource type doesn't exist", this);
                    return 0;
            }
        }
        
        public void SetResourceCount(GameResourceType resourceType, int value)
        {
            switch (resourceType)
            {
                case GameResourceType.Gold:
                    golds = value;
                    break;
                case GameResourceType.Food:
                    foods = value;
                    break;
                case GameResourceType.Wood:
                    woods = value;
                    break;
                case GameResourceType.Iron:
                    irons = value;
                    break;
                case GameResourceType.Stone:
                    stones = value;
                    break;
                case GameResourceType.Lore:
                    lore = value;
                    break;
                case GameResourceType.Fame:
                    fame = value;
                    break;
                default:
                    _logger.LogError("The resource type doesn't exist", this);
                    break;
            }
        }

        public void Increase(GameResourceType resourceType, int amount) =>
            SetResourceCount(resourceType, GetResourceCount(resourceType) + amount);

        public void Decrease(GameResourceType resourceType, int amount) =>
            Increase(resourceType, -amount);
    }
}