using System;

namespace ViradaGames
{
    [Serializable]
    class Accessory : Item
    {
        private string platformType;

        public Accessory(string id, string description, int stockQuantity, double retailPrice, string platformType)
        {
            ItemID = id;
            Description = description;
            StockQuantity = stockQuantity;
            RetailPrice = retailPrice;
            PlatformType = platformType;
        }

        public string PlatformType
        {
            get => platformType;
            set => platformType = value;
        }
    }
}