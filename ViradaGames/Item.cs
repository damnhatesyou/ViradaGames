using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViradaGames
{
    [Serializable]
    class Item
    {
        protected string itemID;
        protected string description;
        protected int stockQuantity;
        protected double retailPrice;

        public string ItemID
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