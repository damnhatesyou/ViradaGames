using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViradaGames
{
    public partial class ViradaGames : Form
    {
        #region PublicVariables

        List<Item> ItemsList = new List<Item>();
        List<Customer> CustomerList = new List<Customer>();
        List<Transaction> TransactionList = new List<Transaction>();
        DateTime currentDate = new DateTime();

        #endregion

        #region AddButtons

        /// <summary>
        /// Add a Item to the List and Item Collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productAddButton_Click(object sender, EventArgs e)
        {
            // Does it Have Item Data
            if (HasItem())
            {
                // Is it a Game
                if (HasGame() && !(HasPlatforms() || HasAccessory()))
                {
                    productsListBox.Items.Add(string.Join(" ", productIDItemInfoTextBox.Text,
                        descriptionItemInfoTextBox.Text)); // Add to Product Listbox
                    ItemsList.Add(new Game(productIDItemInfoTextBox.Text, descriptionItemInfoTextBox.Text,
                        int.Parse(stockQuantityItemInfoTextBox.Text), double.Parse(retailPriceItemInfoTextBox.Text),
                        publisherGamesTextBox.Text, mediaTypeGamesTextBox.Text)); // Add a Game To Item Collection 
                    return;
                }

                // Is it a Platform
                if (HasPlatforms() && !(HasGame() || HasAccessory()))
                {
                    productsListBox.Items.Add(string.Join(" ", productIDItemInfoTextBox.Text,
                        descriptionItemInfoTextBox.Text)); // Add to Product Listbox
                    ItemsList.Add(new Platform(productIDItemInfoTextBox.Text, descriptionItemInfoTextBox.Text,
                        int.Parse(stockQuantityItemInfoTextBox.Text), double.Parse(retailPriceItemInfoTextBox.Text),
                        modelNumberPlatformsTextBox.Text)); // Add a Platform To Item Collection
                    return;
                }

                // Is it an Accessory
                if (HasAccessory() && !(HasGame() || HasPlatforms()))
                {
                    productsListBox.Items.Add(string.Join(" ", productIDItemInfoTextBox.Text,
                        descriptionItemInfoTextBox.Text)); // Add to Product Listbox
                    ItemsList.Add(new Accessory(productIDItemInfoTextBox.Text, descriptionItemInfoTextBox.Text,
                        int.Parse(stockQuantityItemInfoTextBox.Text), double.Parse(retailPriceItemInfoTextBox.Text),
                        platformTypeAccessoriesTextBox.Text)); // Add an Accessory To Item Collection
                    return;
                }
                // Otherwise
                else
                {
                    MessageBox.Show("Please Enter a Games/Platform/Accessory");
                }

                
            }
            else
            {
                MessageBox.Show("Please enter an Item");
            }
            ClearItemTextBoxes();
        }
        
        /// <summary>
        /// Add a Customer to the List and Customer Collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerAddButton_Click(object sender, EventArgs e)
        {
            // Does it have Customer Data
            if (HasCustomer())
            {
                customerListBox.Items.Add(CustomerIDCustomerTextBox.Text + ": " + familyNameCustomerTextBox.Text +
                                          ", " +
                                          firstNameCustomerTextBox.Text); // Add to Customer Listbox
                CustomerList.Add(new Customer(CustomerIDCustomerTextBox.Text, familyNameCustomerTextBox.Text,
                    firstNameCustomerTextBox.Text, emailCustomerTextBox.Text)); // Add an Customer To Customer Collection
            }
            else
            {
                customerListBox.Items.Add("C001" + ": " + "Unknown" + ", " + "Unknown"); // Adds a Default Customer to Listbox
                CustomerList.Add(new Customer());// Add a Default Customer To Customer Collection

            }

            ClearCustomerTextBoxes();
        }

        /// <summary>
        /// Add a Transaction to the List and Transaction Collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transactionAddButton_Click(object sender, EventArgs e)
        {
            // Does it have Transaction Data
            if (HasTransaction())
            {
                transactionListBox.Items.Add(string.Join(" ", customerIDTransactionTextBox.Text,
                    productIDTransactionTextBox.Text,
                    quantityTransactionTextBox.Text, retailPriceTransactionTextBox.Text, dateTransactionTextBox.Text)); // Add to Transaction Listbox
                TransactionList.Add(new Transaction(customerIDTransactionTextBox.Text, productIDTransactionTextBox.Text,
                    int.Parse(quantityTransactionTextBox.Text), double.Parse(retailPriceTransactionTextBox.Text),
                    DateTime.Parse(dateTransactionTextBox.Text))); // Add an Transaction To Transaction Collection
            }
            else
            {
                MessageBox.Show("Please Select a Customer and an Item then enter a Quantity");
            }
        }

        #endregion

        #region HasChecks

        /// <summary>
        /// Test For a Item
        /// </summary>
        /// <returns>bool</returns>
        private bool HasItem()
        {
            return !string.IsNullOrEmpty(productIDItemInfoTextBox.Text) &&
                   !string.IsNullOrEmpty(descriptionItemInfoTextBox.Text) &&
                   !string.IsNullOrEmpty(stockQuantityItemInfoTextBox.Text) &&
                   !string.IsNullOrEmpty(retailPriceItemInfoTextBox.Text);
        }

        /// <summary>
        /// Test for a game
        /// </summary>
        /// <returns>bool</returns>
        private bool HasGame()
        {
            return !string.IsNullOrEmpty(publisherGamesTextBox.Text) &&
                   !string.IsNullOrEmpty(mediaTypeGamesTextBox.Text);
        }

        /// <summary>
        /// Test for a Platform
        /// </summary>
        /// <returns>bool</returns>
        private bool HasPlatforms()
        {
            return !string.IsNullOrEmpty(modelNumberPlatformsTextBox.Text);
        }

        /// <summary>
        /// Test for a Accessory
        /// </summary>
        /// <returns>bool</returns>
        private bool HasAccessory()
        {
            return !string.IsNullOrEmpty(platformTypeAccessoriesTextBox.Text);
        }

        /// <summary>
        /// Test for Customer
        /// </summary>
        /// <returns>bool</returns>
        private bool HasCustomer()
        {
            return !string.IsNullOrEmpty(CustomerIDCustomerTextBox.Text) &&
                   !string.IsNullOrEmpty(familyNameCustomerTextBox.Text) &&
                   !string.IsNullOrEmpty(firstNameCustomerTextBox.Text) &&
                   !string.IsNullOrEmpty(emailCustomerTextBox.Text);
        }

        /// <summary>
        /// Test for Transaction
        /// </summary>
        /// <returns>bool</returns>
        private bool HasTransaction()
        {
            return !string.IsNullOrEmpty(customerIDTransactionTextBox.Text) &&
                   !string.IsNullOrEmpty(productIDTransactionTextBox.Text) &&
                   !string.IsNullOrEmpty(quantityTransactionTextBox.Text) &&
                   !string.IsNullOrEmpty(retailPriceTransactionTextBox.Text) &&
                   !string.IsNullOrEmpty(dateTransactionTextBox.Text);
        }

        #endregion

        #region Reading and Writing from files

        /// <summary>
        /// Write Item List to File "items.dat"
        /// </summary>
        public void WriteItemList()
        {
            try
            {
                using (Stream writeStream = File.Open("items.dat", FileMode.Create))
                {
                    BinaryFormatter binaryData = new BinaryFormatter();
                    // Create the binary formatter and serialize
                    binaryData.Serialize(writeStream, ItemsList);
                }
            }
            catch (IOException oe)
            {
                MessageBox.Show("Could not write to items.dat " + oe.Message);
            }
        }

        /// <summary>
        /// Read Items from "items.dat"
        /// </summary>
        public void ReadItemList()
        {
            try
            {
                using (Stream readStream = File.Open("items.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    ItemsList = (List<Item>)formatter.Deserialize(readStream);
                }
            }
            catch (IOException oe)
            {
                Console.WriteLine("Could not read item.dat " + oe);
                throw;
            }

        }

        /// <summary>
        /// Write Customers List to File "customer.dat"
        /// </summary>
        public void WriteCustomerList()
        {
            try
            {
                using (Stream writeStream = File.Open("customer.dat", FileMode.Create))
                {
                    BinaryFormatter binaryData = new BinaryFormatter();
                    // Create the binary formatter and serialize
                    binaryData.Serialize(writeStream, CustomerList);
                }
            }
            catch (IOException oe)
            {
                MessageBox.Show("Could not write to customer.dat " + oe.Message);
            }
        }

        /// <summary>
        /// Read Customers from "customer.dat"
        /// </summary>
        public void ReadCustomerList()
        {
            try
            {
                using (Stream readStream = File.Open("customer.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    CustomerList = (List<Customer>)formatter.Deserialize(readStream);
                }
            }
            catch (IOException oe)
            {
                Console.WriteLine("Could not read customer.dat " + oe);
                throw;
            }
        }

        /// <summary>
        /// Write Transactions List to File "transaction.dat"
        /// </summary>
        public void WriteTransactionList()
        {
            try
            {
                using (Stream writeStream = File.Open("transaction.dat", FileMode.Create))
                {
                    BinaryFormatter binaryData = new BinaryFormatter();
                    // Create the binary formatter and serialize
                    binaryData.Serialize(writeStream, TransactionList);
                }
            }
            catch (IOException oe)
            {
                MessageBox.Show("Could not write to transaction.dat " + oe.Message);
            }
        }

        /// <summary>
        /// Read Transactions from "transaction.dat"
        /// </summary>
        public void ReadTransactionList()
        {
            try
            {
                using (Stream readStream = File.Open("transaction.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    TransactionList = (List<Transaction>)formatter.Deserialize(readStream);
                }
            }
            catch (IOException oe)
            {
                Console.WriteLine("Could not read transaction.dat " + oe);
                throw;
            }

        }

        #endregion

        #region Listbox Control

        /// <summary>
        /// Controls the behaviour of Customer ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerListBox.SelectedIndex >= 0)
            {
                ClearCustomerTextBoxes();
                CustomerIDCustomerTextBox.Text = CustomerList[customerListBox.SelectedIndex].CustomerId;
                familyNameCustomerTextBox.Text = CustomerList[customerListBox.SelectedIndex].FamilyName;
                firstNameCustomerTextBox.Text = CustomerList[customerListBox.SelectedIndex].Firstname;
                emailCustomerTextBox.Text = CustomerList[customerListBox.SelectedIndex].EmailAddress;

                customerIDTransactionTextBox.Text = CustomerList[customerListBox.SelectedIndex].CustomerId;
            }

        }
        
        /// <summary>
        /// Controls the behaviour of Transaction ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void transactionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (transactionListBox.SelectedIndex >= 0)
            {
                ClearTransactionTextBoxes();
                customerIDTransactionTextBox.Text = TransactionList[transactionListBox.SelectedIndex].CustId;
                productsListBox.Text = TransactionList[transactionListBox.SelectedIndex].ItemId;
                quantityTransactionTextBox.Text = TransactionList[transactionListBox.SelectedIndex].Quantity.ToString();
                retailPriceTransactionTextBox.Text =
                    TransactionList[transactionListBox.SelectedIndex].RetailPrice.ToString("0.##");
                dateTransactionTextBox.Text =
                    TransactionList[transactionListBox.SelectedIndex].Date.ToShortDateString();

                int itemPos = 0;
                int custPos = 0;
                foreach (Item item in ItemsList)
                {
                    if (TransactionList[transactionListBox.SelectedIndex].ItemId == item.ItemID)
                    {
                        productsListBox.SelectedIndex = itemPos;
                    }

                    itemPos++;
                }

                foreach (Customer customer in CustomerList)
                {
                    if (TransactionList[transactionListBox.SelectedIndex].CustId == customer.CustomerId)
                    {
                        customerListBox.SelectedIndex = custPos;
                    }

                    custPos++;
                }
            }
           
        }

        /// <summary>
        /// Controls the behaviour of Products ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productsListBox.SelectedIndex >= 0)
            {
                ClearItemTextBoxes();
                productIDItemInfoTextBox.Text = ItemsList[productsListBox.SelectedIndex].ItemID;
                descriptionItemInfoTextBox.Text = ItemsList[productsListBox.SelectedIndex].Description;
                stockQuantityItemInfoTextBox.Text = ItemsList[productsListBox.SelectedIndex].StockQuantity.ToString();
                retailPriceItemInfoTextBox.Text = ItemsList[productsListBox.SelectedIndex].RetailPrice.ToString("0.##");
                if (ItemsList[productsListBox.SelectedIndex].GetType() == typeof(Game))
                {
                    Game game = (Game)ItemsList[productsListBox.SelectedIndex];
                    publisherGamesTextBox.Text = game.Publisher;
                    mediaTypeGamesTextBox.Text = game.MediaType;
                }

                if (ItemsList[productsListBox.SelectedIndex].GetType() == typeof(Platform))
                {
                    Platform platform = (Platform)ItemsList[productsListBox.SelectedIndex];
                    modelNumberPlatformsTextBox.Text = platform.ModelNumber;
                }

                if (ItemsList[productsListBox.SelectedIndex].GetType() == typeof(Accessory))
                {
                    Accessory accessory = (Accessory)ItemsList[productsListBox.SelectedIndex];
                    platformTypeAccessoriesTextBox.Text = accessory.PlatformType;
                }

                productIDTransactionTextBox.Text = ItemsList[productsListBox.SelectedIndex].ItemID;
                retailPriceTransactionTextBox.Text =
                    ItemsList[productsListBox.SelectedIndex].RetailPrice.ToString("0.##");
            }
        }

        #endregion

        #region Textbox Control

        /// <summary>
        /// Clears the Items Textboxes
        /// </summary>
        public void ClearItemTextBoxes()
        {
            productIDItemInfoTextBox.Text = "";
            descriptionItemInfoTextBox.Text = "";
            stockQuantityItemInfoTextBox.Text = "";
            retailPriceItemInfoTextBox.Text = "";
            publisherGamesTextBox.Text = "";
            mediaTypeGamesTextBox.Text = "";
            modelNumberPlatformsTextBox.Text = "";
            platformTypeAccessoriesTextBox.Text = "";
        }

        /// <summary>
        /// Clears the Customer Textboxes
        /// </summary>
        public void ClearCustomerTextBoxes()
        {
            CustomerIDCustomerTextBox.Text = "";
            familyNameCustomerTextBox.Text = "";
            firstNameCustomerTextBox.Text = "";
            emailCustomerTextBox.Text = "";
        }
        
        /// <summary>
        /// Clears the Transaction Textboxes
        /// </summary>
        public void ClearTransactionTextBoxes()
        {
            customerIDTransactionTextBox.Text = "";
            productIDTransactionTextBox.Text = "";
            quantityTransactionTextBox.Text = "";
            retailPriceTransactionTextBox.Text = "";
            dateTransactionTextBox.Text = currentDate.ToShortDateString();
        }

        /// <summary>
        /// Double clicks to clear Products Textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void productIDItemInfoTextBox_DoubleClick(object sender, EventArgs e)
        {
            ClearItemTextBoxes();
        }

        /// <summary>
        /// Double clicks to clear Customer Textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerIDCustomerTextBox_DoubleClick(object sender, EventArgs e)
        {
            ClearCustomerTextBoxes();
        }

        /// <summary>
        /// Double clicks to clear Transaction Textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerIDTransactionTextBox_DoubleClick(object sender, EventArgs e)
        {
            ClearTransactionTextBoxes();
        }

        /// <summary>
        /// Populates Transaction date textbox with Today's Date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTransactionTextBox_DoubleClick(object sender, EventArgs e)
        {
            // Sets the current Date
            currentDate = DateTime.Now;
            dateTransactionTextBox.Text = currentDate.Date.ToShortDateString();
        }

        #endregion

        #region Misc 

        /// <summary>
        /// Read Binary files and populate Listboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViradaGames_Load(object sender, EventArgs e)
        {
            ReadItemList();
            ReadCustomerList();
            ReadTransactionList();

            foreach (Item item in ItemsList)
            {
                productsListBox.Items.Add(string.Join(" ", item.ItemID, item.Description));
            }

            foreach (Customer customer in CustomerList)
            {
                customerListBox.Items.Add(string.Join(" ", customer.CustomerId,
                    customer.FamilyName + " " + customer.Firstname));
            }

            foreach (Transaction transaction in TransactionList)
            {
                transactionListBox.Items.Add(string.Join(" ", transaction.CustId, transaction.ItemId, transaction.Quantity.ToString() + " x " +
                    transaction.RetailPrice.ToString("0.##"), transaction.Date.ToShortDateString()));
            }
        }

        /// <summary>
        /// Write to Files on closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViradaGames_FormClosed(object sender, FormClosedEventArgs e)
        {
            WriteCustomerList();
            WriteItemList();
            WriteTransactionList();
        }

        public ViradaGames()
        {
            InitializeComponent();
        }

        #endregion
    }
}