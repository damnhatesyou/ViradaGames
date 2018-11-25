using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViradaGames
{
    [Serializable]
    class Customer
    {
        private string customerID;
        private string familyName;
        private string firstname;
        private string emailAddress;

        public Customer()
        {
            CustomerId = "C000";
            FamilyName = "Unknown";
            Firstname = "Unknown";
            EmailAddress = "Unknown";
        }

        public Customer(string custId, string familyName, string firstname, string emailAddress)
        {
            CustomerId = custId;
            FamilyName = familyName;
            Firstname = firstname;
            EmailAddress = emailAddress;
        }

        public string CustomerId
        {
            get => customerID;
            set => customerID = value;
        }
        public string FamilyName
        {
            get => familyName;
            set => familyName = value;
        }
        public string Firstname
        {
            get => firstname;
            set => firstname = value;
        }
        public string EmailAddress
        {
            get => emailAddress;
            set => emailAddress = value;
        }
    }
}
