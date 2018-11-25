using System;

namespace ViradaGames
{
    [Serializable]
    class Platform : Item
    {
        private string modelNumber;

        public Platform(string id, string description, int stockQuantity, double retailPrice, string modelNumber)
        {
            ItemID = id;
            Description = description;
            StockQuantity = stockQuantity;
            RetailPrice = retailPrice;
            ModelNumber = modelNumber;
        }

        public string ModelNumber
        {
            get { return modelNumber; }
            set { modelNumber = value; }
        }
    }
}