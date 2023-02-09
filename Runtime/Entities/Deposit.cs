using System;
using Northgard.GameResources.Enums;

namespace Northgard.GameResources.Entities
{
    [Serializable]
    public class Deposit
    {
        public GameResourceType resourceType;
        public int amount;
    }
}