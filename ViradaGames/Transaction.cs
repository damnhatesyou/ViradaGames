using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViradaGames
{
    [Serializable]
    class Transaction
    {
        private string custID;
        private string itemID;
        private int quantity;
        private double retailPrice;
        private DateTime date;

        public Transaction(string custId, string itemId, int quantity, double retailPrice, DateTime date)
        {
            CustId = custId;
            ItemId = itemId;
            Quantity = quantity;
            RetailPrice = retailPrice;
            Date = date;
        }

        public string CustId
        {
            get => custID;
            set => custID = value;
        }

        public string ItemId
        {
            get => itemID;
            set => itemID = value;
        }

        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }

        public double RetailPrice
        {
            get => retailPrice;
            set => retailPrice = value;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }
    }
}
