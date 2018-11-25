using System;
using System.Globalization;

namespace ViradaGames
{
    [Serializable]
    class Game : Item
    {
        private string publisher;
        private string mediaType;

        public Game(string id, string description, int stockQuantity, double retailPrice, string publisher, string mediaType)
        {
            ItemID = id;
            Description = description;
            StockQuantity = stockQuantity;
            RetailPrice = retailPrice;
            Publisher = publisher;
            MediaType = mediaType;
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public string MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }

    }
}