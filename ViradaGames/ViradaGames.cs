using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViradaGames
{
    public partial class ViradaGames : Form
    {
        public ViradaGames()
        {
            InitializeComponent();
        }


        private void productAddButton_Click(object sender, EventArgs e)
        {
            // Does it Have Item Data
            if (HasItem())
            {
                // Is it a Game
                if (HasGame() && !(HasPlatforms() || HasAccessory()))
                {
                    productsListBox.Items.Add(productIDItemInfoTextBox.Text + descriptionItemInfoTextBox.Text);
                }

                // Is it a Platform
                if (HasPlatforms() && !(HasGame() || HasAccessory()))
                {
                    productsListBox.Items.Add(productIDItemInfoTextBox.Text + descriptionItemInfoTextBox.Text);
                }

                // Is it an Accessory
                if (HasAccessory() && !(HasGame() || HasPlatforms()))
                {
                    productsListBox.Items.Add(productIDItemInfoTextBox.Text + descriptionItemInfoTextBox.Text);
                }
                // Otherwise
                else
                {
                    Console.WriteLine("Please Enter a Games/Platform/Accessory");
                }
            }
            else
            {
                Console.WriteLine("Please The Some Data");
            }
        }

        private void customerAddButton_Click(object sender, EventArgs e)
        {
            if (HasCustomer())
            {
                customerListBox.Items.Add(customerCustomerIDTextBox.Text + ": " + familyNameCustomerTextBox.Text + ", " + 
                                          firstNameCustomerTextBox.Text);
            }
        }

        private void transactionAddButton_Click(object sender, EventArgs e)
        {

        }

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
            return !string.IsNullOrEmpty(customerCustomerIDTextBox.Text) &&
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
                   !string.IsNullOrEmpty(dateTransactionTextBoxTransactionTextBox.Text);
        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void transactionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
