using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViradaGames
{
    class Item
    {
        private int itemID;
        private string description;
        private int stockQuantity;
        private double retailPrice;

        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int StockQuantity
        {
            get { return stockQuantity; }
            set { stockQuantity = value; }
        }

        public double RetailPrice
        {
            get { return retailPrice; }
            set { retailPrice = value; }
        }
    }
}