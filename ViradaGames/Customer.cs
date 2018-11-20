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
    class Customer
    {
        private int custID;
        private string surname;
        private string firstname;
        private string emailAddress;

        public Customer()
        {
            CustId = 0000;
        }

        public int CustId
        {
            get => custID;
            set => custID = value;
        }
        public string Surname
        {
            get => surname;
            set => surname = value;
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

        private void WriteListToBinaryFile()
        {
            try
            {
                using (Stream writeStream = File.Open("customers.bin", FileMode.Create))
                {
                    BinaryFormatter binaryData = new BinaryFormatter();
                    // Create the binary formatter and serialize
                    binaryData.Serialize(writeStream, custID);
                    binaryData.Serialize(writeStream, surname);
                    binaryData.Serialize(writeStream, firstname);
                    binaryData.Serialize(writeStream, emailAddress);
                }
            }
            catch (IOException oe)
            {
                MessageBox.Show("Could not write to file !\n" + oe.Message);
            }
        }

    }
}
