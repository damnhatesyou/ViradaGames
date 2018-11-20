using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViradaGames
{
    class Transaction
    {
        private int custID;
        private int itemID;
        private int quantity;
        private double retailPrice;
        private DateTime date;

        public int CustId
        {
            get => custID;
            set => custID = value;
        }

        public int ItemId
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
